/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.QueryParameters
{
    public class Integrations_QueryParameters_Service : SubServiceBase<ERP_Integrations_QueryParameters>
    {
        public Integrations_QueryParameters_Service(ERPNextClient client) : base(_DockType.Integrations_QueryParameters, client) { }

        protected override ERP_Integrations_QueryParameters FromERPObject(ERPObject obj)
        {
            return new ERP_Integrations_QueryParameters(obj);
        }

        /* custom functions can be added here */

    }
}

