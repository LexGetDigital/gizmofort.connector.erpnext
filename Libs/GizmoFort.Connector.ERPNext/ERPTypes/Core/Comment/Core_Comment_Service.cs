/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.Comment
{
    public class Core_Comment_Service : SubServiceBase<ERP_Core_Comment>
    {
        public Core_Comment_Service(ERPNextClient client) : base(_DockType.Core_Comment, client) { }

        protected override ERP_Core_Comment FromERPObject(ERPObject obj)
        {
            return new ERP_Core_Comment(obj);
        }

        /* custom functions can be added here */

    }
}

