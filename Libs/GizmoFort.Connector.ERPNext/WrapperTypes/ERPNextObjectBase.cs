using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.Json;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.Utils;

namespace GizmoFort.Connector.ERPNext.WrapperTypes
{
    public abstract class ERPNextObjectBase
    {
        public ERPObject Object { get; internal set; }

        protected ERPNextObjectBase(ERPObject obj)
        {
            this.Object = obj;
        }

#pragma warning disable IDE1006 // Naming Styles
        protected dynamic data => Object.Data;
#pragma warning restore IDE1006 // Naming Styles

#pragma warning disable IDE1006 // Naming Styles
        public string name
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return Object.Name; }
            set { Object.Name = value; }
        }

        public DocType ObjectType => Object.ObjectType;

        protected static T ParseEnum<T>(string enumString)
        {
            if (!typeof(T).IsEnum) {
                throw new ArgumentException("T must be an enum");
            }

            return (T)Enum.Parse(typeof(T), enumString, true);
        }

        //
        // reference: https://stackoverflow.com/questions/26429612/retrieve-name-value-from-columnattribute-for-entity-framework-batch-deletes
        //
        public static string? GetColumnName<T>(string propertyName)
        {
            string? result = null;

            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentNullException(nameof(propertyName), "'propertyName' cannot be null or empty.");
            }

            var classType = typeof(T);
            var properties = classType.GetProperties(BindingFlags.GetProperty
                                                     | BindingFlags.Instance
                                                     | BindingFlags.Public);

            var property = properties
              .Where(p => p.Name.Equals(propertyName,
                                        StringComparison.CurrentCultureIgnoreCase))
              .FirstOrDefault();

            if (property == null)
            {
                throw new Exception("propertyName not found."); // bad example
            }
            else
            {
                result = property.Name;  //if no column attribute exists;
                var attribute = property.GetCustomAttributes<ColumnAttribute>()
                                        .FirstOrDefault() as ColumnAttribute;
                if (attribute is not null)
                    result = attribute.Name;
            }
            return result;
        }

        public static string GetPropertyName<T>(string columnName)
        {
            if (string.IsNullOrWhiteSpace(columnName))
            {
                throw new ArgumentNullException(nameof(columnName), "'columnName' cannot be null or empty.");
            }

            var classType = typeof(T);
            var properties = classType.GetProperties(BindingFlags.GetProperty
                                                     | BindingFlags.Instance
                                                     | BindingFlags.Public);

            PropertyInfo? propertyWithAttribute = null;
            foreach (var property in properties)
            {
                var columnAttribute = (ColumnAttribute?)property
                                                           .GetCustomAttributes(attributeType: typeof(ColumnAttribute), inherit: false)
                                                           .FirstOrDefault();
                if ((columnAttribute is not null)
                    && (!string.IsNullOrEmpty(columnAttribute.Name))
                    && (columnAttribute.Name == columnName))
                {
                    propertyWithAttribute = property;
                    break;
                }
            }

            if (propertyWithAttribute == null)
            {
                throw new Exception("columnName not found."); // bad example
            }

            return propertyWithAttribute.Name;

        }

        protected class CustomJsonSerializationPolicy<T> : JsonNamingPolicy
        {
            public override string ConvertName(string columnName)
            {
                return GetPropertyName<T>(columnName);
            }
        }

    }
}