/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.WorkOrder
{
    public class Manufacturing_WorkOrder_Service : SubServiceBase<ERP_Manufacturing_WorkOrder>
    {
        public Manufacturing_WorkOrder_Service(ERPNextClient client) : base(_DockType.Manufacturing_WorkOrder, client) { }

        protected override ERP_Manufacturing_WorkOrder FromERPObject(ERPObject obj)
        {
            return new ERP_Manufacturing_WorkOrder(obj);
        }

        /* custom functions can be added here */

    }
}

