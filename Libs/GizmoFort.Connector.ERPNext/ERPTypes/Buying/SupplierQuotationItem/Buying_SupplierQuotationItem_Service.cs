/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.SupplierQuotationItem
{
    public class Buying_SupplierQuotationItem_Service : SubServiceBase<ERP_Buying_SupplierQuotationItem>
    {
        public Buying_SupplierQuotationItem_Service(ERPNextClient client) : base(_DockType.Buying_SupplierQuotationItem, client) { }

        protected override ERP_Buying_SupplierQuotationItem FromERPObject(ERPObject obj)
        {
            return new ERP_Buying_SupplierQuotationItem(obj);
        }

        /* custom functions can be added here */

    }
}

