/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.SlackWebhookURL
{
    public class Integrations_SlackWebhookURL_Service : SubServiceBase<ERP_Integrations_SlackWebhookURL>
    {
        public Integrations_SlackWebhookURL_Service(ERPNextClient client) : base(_DockType.Integrations_SlackWebhookURL, client) { }

        protected override ERP_Integrations_SlackWebhookURL FromERPObject(ERPObject obj)
        {
            return new ERP_Integrations_SlackWebhookURL(obj);
        }

        /* custom functions can be added here */

    }
}

