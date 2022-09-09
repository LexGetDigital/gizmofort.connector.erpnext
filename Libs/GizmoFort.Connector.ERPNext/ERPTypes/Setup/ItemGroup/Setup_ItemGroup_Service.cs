/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.ItemGroup
{
    public class Setup_ItemGroup_Service : SubServiceBase<ERP_Setup_ItemGroup>
    {
        public Setup_ItemGroup_Service(ERPNextClient client) : base(_DockType.Setup_ItemGroup, client) { }

        protected override ERP_Setup_ItemGroup FromERPObject(ERPObject obj)
        {
            return new ERP_Setup_ItemGroup(obj);
        }

        /* custom functions can be added here */

    }
}

