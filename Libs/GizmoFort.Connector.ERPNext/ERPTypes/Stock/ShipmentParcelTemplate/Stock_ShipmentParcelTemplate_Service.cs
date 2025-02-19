/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.ShipmentParcelTemplate
{
    public class Stock_ShipmentParcelTemplate_Service : SubServiceBase<ERP_Stock_ShipmentParcelTemplate>
    {
        public Stock_ShipmentParcelTemplate_Service(ERPNextClient client) : base(_DockType.Stock_ShipmentParcelTemplate, client) { }

        protected override ERP_Stock_ShipmentParcelTemplate FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_ShipmentParcelTemplate(obj);
        }

        /* custom functions can be added here */

    }
}

