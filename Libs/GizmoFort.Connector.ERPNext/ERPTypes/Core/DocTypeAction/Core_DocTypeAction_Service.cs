/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DocTypeAction
{
    public class Core_DocTypeAction_Service : SubServiceBase<ERP_Core_DocTypeAction>
    {
        public Core_DocTypeAction_Service(ERPNextClient client) : base(_DockType.Core_DocTypeAction, client) { }

        protected override ERP_Core_DocTypeAction FromERPObject(ERPObject obj)
        {
            return new ERP_Core_DocTypeAction(obj);
        }

        /* custom functions can be added here */

    }
}

