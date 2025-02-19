﻿using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GizmoFort.Connector.ERPNext.Serialization
{
    public class ERPNextObjectBaseJsonConverter<T> : JsonConverter<T> where T : ERPNextObjectBase
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType.IsAssignableTo(typeof(ERPNextObjectBase));
        }

        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            //
            // will only deserialize the properties in json... nothing more to do!
            //
            return JsonSerializer.Deserialize<T>(ref reader, options);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            //
            // reference: https://github.com/dotnet/runtime/issues/593#issuecomment-999324650
            //

            if (value is not null)
            {
                writer.WriteStartObject();

                var obj = value.Object as ERPObject;
                var data = obj.Data;
                var dataViaIDictionary = (IDictionary<string, object?>)data;

                foreach (var columnName in dataViaIDictionary.Keys)
                {
                    var propertyInfo = ERPNextConverter.GetPropertyInfoByColumnName<T>(columnName);
                    if (propertyInfo is not null)
                    {
                        writer.WritePropertyName(propertyInfo.Name);
                        var propValue = propertyInfo.GetValue(value);
                        JsonSerializer.Serialize(writer, propValue, options);
                    }
                }

                writer.WriteEndObject();
            }
        }
    }
}
