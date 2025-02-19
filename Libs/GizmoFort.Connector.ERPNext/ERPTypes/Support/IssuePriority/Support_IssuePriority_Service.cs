/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Support.IssuePriority
{
    public class Support_IssuePriority_Service : SubServiceBase<ERP_Support_IssuePriority>
    {
        public Support_IssuePriority_Service(ERPNextClient client) : base(_DockType.Support_IssuePriority, client) { }

        protected override ERP_Support_IssuePriority FromERPObject(ERPObject obj)
        {
            return new ERP_Support_IssuePriority(obj);
        }

        /* custom functions can be added here */

    }
}

