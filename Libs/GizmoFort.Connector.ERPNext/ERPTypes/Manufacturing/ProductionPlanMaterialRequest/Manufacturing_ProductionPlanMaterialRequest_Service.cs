/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.ProductionPlanMaterialRequest
{
    public class Manufacturing_ProductionPlanMaterialRequest_Service : SubServiceBase<ERP_Manufacturing_ProductionPlanMaterialRequest>
    {
        public Manufacturing_ProductionPlanMaterialRequest_Service(ERPNextClient client) : base(_DockType.Manufacturing_ProductionPlanMaterialRequest, client) { }

        protected override ERP_Manufacturing_ProductionPlanMaterialRequest FromERPObject(ERPObject obj)
        {
            return new ERP_Manufacturing_ProductionPlanMaterialRequest(obj);
        }

        /* custom functions can be added here */

    }
}

