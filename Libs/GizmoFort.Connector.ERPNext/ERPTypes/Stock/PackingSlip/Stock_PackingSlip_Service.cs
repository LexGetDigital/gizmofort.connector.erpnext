/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.PackingSlip
{
    public class Stock_PackingSlip_Service : SubServiceBase<ERP_Stock_PackingSlip>
    {
        public Stock_PackingSlip_Service(ERPNextClient client) : base(_DockType.Stock_PackingSlip, client) { }

        protected override ERP_Stock_PackingSlip FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_PackingSlip(obj);
        }

        /* custom functions can be added here */

    }
}

