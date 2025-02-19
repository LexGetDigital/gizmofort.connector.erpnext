/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DynamicLink
{
    public class Core_DynamicLink_Service : SubServiceBase<ERP_Core_DynamicLink>
    {
        public Core_DynamicLink_Service(ERPNextClient client) : base(_DockType.Core_DynamicLink, client) { }

        protected override ERP_Core_DynamicLink FromERPObject(ERPObject obj)
        {
            return new ERP_Core_DynamicLink(obj);
        }

        /* custom functions can be added here */

    }
}

