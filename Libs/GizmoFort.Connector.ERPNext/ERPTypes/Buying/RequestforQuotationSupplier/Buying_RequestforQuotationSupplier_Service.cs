/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.RequestforQuotationSupplier
{
    public class Buying_RequestforQuotationSupplier_Service : SubServiceBase<ERP_Buying_RequestforQuotationSupplier>
    {
        public Buying_RequestforQuotationSupplier_Service(ERPNextClient client) : base(_DockType.Buying_RequestforQuotationSupplier, client) { }

        protected override ERP_Buying_RequestforQuotationSupplier FromERPObject(ERPObject obj)
        {
            return new ERP_Buying_RequestforQuotationSupplier(obj);
        }

        /* custom functions can be added here */

    }
}

