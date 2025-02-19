/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.Vehicle
{
    public class Setup_Vehicle_Service : SubServiceBase<ERP_Setup_Vehicle>
    {
        public Setup_Vehicle_Service(ERPNextClient client) : base(_DockType.Setup_Vehicle, client) { }

        protected override ERP_Setup_Vehicle FromERPObject(ERPObject obj)
        {
            return new ERP_Setup_Vehicle(obj);
        }

        /* custom functions can be added here */

    }
}

