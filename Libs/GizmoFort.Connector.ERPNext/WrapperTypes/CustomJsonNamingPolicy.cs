using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.WrapperTypes
{
    public class CustomJsonNamingPolicy<T> : JsonNamingPolicy
    {
        public override string ConvertName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<T>(columnName);
        }
    }
}
