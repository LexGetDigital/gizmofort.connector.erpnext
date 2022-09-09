/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.GoogleCalendar
{
    public class Integrations_GoogleCalendar_Service : SubServiceBase<ERP_Integrations_GoogleCalendar>
    {
        public Integrations_GoogleCalendar_Service(ERPNextClient client) : base(_DockType.Integrations_GoogleCalendar, client) { }

        protected override ERP_Integrations_GoogleCalendar FromERPObject(ERPObject obj)
        {
            return new ERP_Integrations_GoogleCalendar(obj);
        }

        /* custom functions can be added here */

    }
}

