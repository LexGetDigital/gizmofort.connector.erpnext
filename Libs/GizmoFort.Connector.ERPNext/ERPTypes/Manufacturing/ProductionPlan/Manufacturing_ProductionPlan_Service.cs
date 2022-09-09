/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.ProductionPlan
{
    public class Manufacturing_ProductionPlan_Service : SubServiceBase<ERP_Manufacturing_ProductionPlan>
    {
        public Manufacturing_ProductionPlan_Service(ERPNextClient client) : base(_DockType.Manufacturing_ProductionPlan, client) { }

        protected override ERP_Manufacturing_ProductionPlan FromERPObject(ERPObject obj)
        {
            return new ERP_Manufacturing_ProductionPlan(obj);
        }

        /* custom functions can be added here */

    }
}

