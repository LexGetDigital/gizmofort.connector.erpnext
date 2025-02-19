/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.ItemAttribute
{
    public class Stock_ItemAttribute_Service : SubServiceBase<ERP_Stock_ItemAttribute>
    {
        public Stock_ItemAttribute_Service(ERPNextClient client) : base(_DockType.Stock_ItemAttribute, client) { }

        protected override ERP_Stock_ItemAttribute FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_ItemAttribute(obj);
        }

        /* custom functions can be added here */

    }
}

