/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.DeliveryNoteItem
{
    public class Stock_DeliveryNoteItem_Service : SubServiceBase<ERP_Stock_DeliveryNoteItem>
    {
        public Stock_DeliveryNoteItem_Service(ERPNextClient client) : base(_DockType.Stock_DeliveryNoteItem, client) { }

        protected override ERP_Stock_DeliveryNoteItem FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_DeliveryNoteItem(obj);
        }

        /* custom functions can be added here */

    }
}

