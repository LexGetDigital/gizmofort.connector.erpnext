/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.DashboardChart
{
    public class Desk_DashboardChart_Service : SubServiceBase<ERP_Desk_DashboardChart>
    {
        public Desk_DashboardChart_Service(ERPNextClient client) : base(_DockType.Desk_DashboardChart, client) { }

        protected override ERP_Desk_DashboardChart FromERPObject(ERPObject obj)
        {
            return new ERP_Desk_DashboardChart(obj);
        }

        /* custom functions can be added here */

    }
}

