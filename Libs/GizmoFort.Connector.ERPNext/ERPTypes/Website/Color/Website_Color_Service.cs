/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.Color
{
    public class Website_Color_Service : SubServiceBase<ERP_Website_Color>
    {
        public Website_Color_Service(ERPNextClient client) : base(_DockType.Website_Color, client) { }

        protected override ERP_Website_Color FromERPObject(ERPObject obj)
        {
            return new ERP_Website_Color(obj);
        }

        /* custom functions can be added here */

    }
}

