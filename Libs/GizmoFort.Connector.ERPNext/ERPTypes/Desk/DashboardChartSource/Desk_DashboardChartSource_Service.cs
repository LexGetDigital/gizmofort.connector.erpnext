/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.DashboardChartSource
{
    public class Desk_DashboardChartSource_Service : SubServiceBase<ERP_Desk_DashboardChartSource>
    {
        public Desk_DashboardChartSource_Service(ERPNextClient client) : base(_DockType.Desk_DashboardChartSource, client) { }

        protected override ERP_Desk_DashboardChartSource FromERPObject(ERPObject obj)
        {
            return new ERP_Desk_DashboardChartSource(obj);
        }

        /* custom functions can be added here */

    }
}

