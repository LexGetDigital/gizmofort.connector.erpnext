/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.WorkspaceLink
{
    public class Desk_WorkspaceLink_Service : SubServiceBase<ERP_Desk_WorkspaceLink>
    {
        public Desk_WorkspaceLink_Service(ERPNextClient client) : base(_DockType.Desk_WorkspaceLink, client) { }

        protected override ERP_Desk_WorkspaceLink FromERPObject(ERPObject obj)
        {
            return new ERP_Desk_WorkspaceLink(obj);
        }

        /* custom functions can be added here */

    }
}

