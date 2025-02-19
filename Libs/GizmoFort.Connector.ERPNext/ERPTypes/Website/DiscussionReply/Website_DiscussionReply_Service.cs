/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.DiscussionReply
{
    public class Website_DiscussionReply_Service : SubServiceBase<ERP_Website_DiscussionReply>
    {
        public Website_DiscussionReply_Service(ERPNextClient client) : base(_DockType.Website_DiscussionReply, client) { }

        protected override ERP_Website_DiscussionReply FromERPObject(ERPObject obj)
        {
            return new ERP_Website_DiscussionReply(obj);
        }

        /* custom functions can be added here */

    }
}

