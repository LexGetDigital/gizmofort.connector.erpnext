/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.Report
{
    public class Core_Report_Service : SubServiceBase<ERP_Core_Report>
    {
        public Core_Report_Service(ERPNextClient client) : base(_DockType.Core_Report, client) { }

        protected override ERP_Core_Report FromERPObject(ERPObject obj)
        {
            return new ERP_Core_Report(obj);
        }

        /* custom functions can be added here */

    }
}

