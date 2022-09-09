/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.Designation
{
    public class Setup_Designation_Service : SubServiceBase<ERP_Setup_Designation>
    {
        public Setup_Designation_Service(ERPNextClient client) : base(_DockType.Setup_Designation, client) { }

        protected override ERP_Setup_Designation FromERPObject(ERPObject obj)
        {
            return new ERP_Setup_Designation(obj);
        }

        /* custom functions can be added here */

    }
}

