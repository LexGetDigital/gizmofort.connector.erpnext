/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Workflow.WorkflowTransition
{
    public class Workflow_WorkflowTransition_Service : SubServiceBase<ERP_Workflow_WorkflowTransition>
    {
        public Workflow_WorkflowTransition_Service(ERPNextClient client) : base(_DockType.Workflow_WorkflowTransition, client) { }

        protected override ERP_Workflow_WorkflowTransition FromERPObject(ERPObject obj)
        {
            return new ERP_Workflow_WorkflowTransition(obj);
        }

        /* custom functions can be added here */

    }
}

