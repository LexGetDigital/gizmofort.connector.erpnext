/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DocTypeState
{
    public class Core_DocTypeState_Service : SubServiceBase<ERP_Core_DocTypeState>
    {
        public Core_DocTypeState_Service(ERPNextClient client) : base(_DockType.Core_DocTypeState, client) { }

        protected override ERP_Core_DocTypeState FromERPObject(ERPObject obj)
        {
            return new ERP_Core_DocTypeState(obj);
        }

        /* custom functions can be added here */

    }
}

