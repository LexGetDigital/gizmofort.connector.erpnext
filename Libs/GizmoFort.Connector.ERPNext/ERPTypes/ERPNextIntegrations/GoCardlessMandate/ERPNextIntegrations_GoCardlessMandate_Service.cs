/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.ERPNextIntegrations.GoCardlessMandate
{
    public class ERPNextIntegrations_GoCardlessMandate_Service : SubServiceBase<ERP_ERPNextIntegrations_GoCardlessMandate>
    {
        public ERPNextIntegrations_GoCardlessMandate_Service(ERPNextClient client) : base(_DockType.ERPNextIntegrations_GoCardlessMandate, client) { }

        protected override ERP_ERPNextIntegrations_GoCardlessMandate FromERPObject(ERPObject obj)
        {
            return new ERP_ERPNextIntegrations_GoCardlessMandate(obj);
        }

        /* custom functions can be added here */

    }
}

