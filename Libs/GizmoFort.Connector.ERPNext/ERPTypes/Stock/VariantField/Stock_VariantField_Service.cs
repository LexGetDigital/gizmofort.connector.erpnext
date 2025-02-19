/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.VariantField
{
    public class Stock_VariantField_Service : SubServiceBase<ERP_Stock_VariantField>
    {
        public Stock_VariantField_Service(ERPNextClient client) : base(_DockType.Stock_VariantField, client) { }

        protected override ERP_Stock_VariantField FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_VariantField(obj);
        }

        /* custom functions can be added here */

    }
}

