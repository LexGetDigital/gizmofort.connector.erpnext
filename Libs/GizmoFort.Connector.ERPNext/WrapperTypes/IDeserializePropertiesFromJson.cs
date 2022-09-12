using System;

namespace GizmoFort.Connector.ERPNext.WrapperTypes
{
    public interface IDeserializePropertiesFromJson<T>
    {
        public static T? Deserialize(string value) => throw new NotImplementedException();
    }
}
