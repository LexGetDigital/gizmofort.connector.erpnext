/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.ItemPrice
{
    public class Stock_ItemPrice_Service : SubServiceBase<ERP_Stock_ItemPrice>
    {
        public Stock_ItemPrice_Service(ERPNextClient client) : base(_DockType.Stock_ItemPrice, client) { }

        protected override ERP_Stock_ItemPrice FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_ItemPrice(obj);
        }

        /* custom functions can be added here */

    }
}

