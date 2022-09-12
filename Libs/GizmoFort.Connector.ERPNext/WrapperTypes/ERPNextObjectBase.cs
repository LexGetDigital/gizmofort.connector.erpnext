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
        private static IDictionary<string, string>? _cachedLookupColumnNameByPropertyName = null;
        public static string GetColumnName<T>(string propertyName)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                throw new ArgumentNullException(nameof(propertyName), "'propertyName' cannot be null or empty.");
            }

            if (_cachedLookupColumnNameByPropertyName is null)
            {
                var lookup = new Dictionary<string, string>();

                var classType = typeof(T);
                var properties = classType.GetProperties(BindingFlags.GetProperty
                                                         | BindingFlags.Instance
                                                         | BindingFlags.Public);

                foreach (var property in properties)
                {
                    var columnAttribute = (ColumnAttribute?)property
                                                               .GetCustomAttributes(attributeType: typeof(ColumnAttribute), inherit: false)
                                                               .FirstOrDefault();
                    if ((columnAttribute is not null)
                        && (!string.IsNullOrEmpty(columnAttribute.Name)))
                    {
                        lookup.Add(property.Name, columnAttribute.Name);
                    }
                }

                _cachedLookupColumnNameByPropertyName = lookup;
            }

            if (!_cachedLookupColumnNameByPropertyName.ContainsKey(propertyName))
            {
                //
                // return the property name by default
                //
                return propertyName;
            }

            return _cachedLookupColumnNameByPropertyName[propertyName];
        }

        private static IDictionary<string, string>? _cachedLookupPropertyNameByColumnName = null;
        public static string GetPropertyName<T>(string columnName)
        {
            if (string.IsNullOrWhiteSpace(columnName))
            {
                throw new ArgumentNullException(nameof(columnName), "'columnName' cannot be null or empty.");
            }

            if (_cachedLookupPropertyNameByColumnName is null)
            {
                var lookup = new Dictionary<string, string>();

                var classType = typeof(T);
                var properties = classType.GetProperties(BindingFlags.GetProperty
                                                         | BindingFlags.Instance
                                                         | BindingFlags.Public);

                foreach (var property in properties)
                {
                    var columnAttribute = (ColumnAttribute?)property
                                                               .GetCustomAttributes(attributeType: typeof(ColumnAttribute), inherit: false)
                                                               .FirstOrDefault();
                    if ((columnAttribute is not null)
                        && (!string.IsNullOrEmpty(columnAttribute.Name)))
                    {
                        lookup.Add(columnAttribute.Name, property.Name);
                    }
                }

                _cachedLookupPropertyNameByColumnName = lookup;
            }

            if (!_cachedLookupPropertyNameByColumnName.ContainsKey(columnName))
            {
                //
                // return the column name by default
                //
                return columnName;
            }

            return _cachedLookupPropertyNameByColumnName[columnName];

        }

        public static T? Deserialize<T>(string value, JsonSerializerOptions? _options = null)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            // also, the date time formats TO ERPNext/mariadb will be in the
            // server timezone. So set the server to UTC and convert assuming UTC
            //

            var enhancedOptions = _options ?? new JsonSerializerOptions();
            enhancedOptions.Converters.Add(new CustomDateTimeConverter());
            var result = typeof(JsonSerializer)
                            .GetMethod("Deserialize", new Type[] { typeof(string), typeof(JsonSerializerOptions) } )!
                            .MakeGenericMethod(new Type[] { typeof(T) })
                            .Invoke(null, new object[] { value, enhancedOptions });
            return (T?)result;
        }

        public static object? Deserialize(string value, Type type, JsonSerializerOptions? _options = null)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            // also, the date time formats TO ERPNext/mariadb will be in the
            // server timezone. So set the server to UTC and convert assuming UTC
            //

            var enhancedOptions = _options ?? new JsonSerializerOptions();
            enhancedOptions.Converters.Add(new CustomDateTimeConverter());

            return JsonSerializer.Deserialize(value, type, enhancedOptions);

        }

        public static string Serialize(ERPNextObjectBase value, JsonSerializerOptions? _options = null)
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            // also, the date time formats FROM ERPNext/mariadb will be in the
            // server timezone. So set the server to UTC and convert assuming UTC
            //

            Type policyGenericWithType = typeof(CustomJsonNamingPolicy<>).MakeGenericType(new Type[] { value.GetType() });
            var policy = Activator.CreateInstance(policyGenericWithType)!;

            var enhancedOptions = _options ?? new JsonSerializerOptions();
            enhancedOptions.DictionaryKeyPolicy = (JsonNamingPolicy)policy;
            enhancedOptions.Converters.Add(new CustomDateTimeConverter());

            var castValue = (ERPNextObjectBase)value;

            return JsonSerializer.Serialize(castValue.Object.Data, enhancedOptions);
        }


    }
}