/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.CompanyHistory
{
    public class Website_CompanyHistory_Service : SubServiceBase<ERP_Website_CompanyHistory>
    {
        public Website_CompanyHistory_Service(ERPNextClient client) : base(_DockType.Website_CompanyHistory, client) { }

        protected override ERP_Website_CompanyHistory FromERPObject(ERPObject obj)
        {
            return new ERP_Website_CompanyHistory(obj);
        }

        /* custom functions can be added here */

    }
}

