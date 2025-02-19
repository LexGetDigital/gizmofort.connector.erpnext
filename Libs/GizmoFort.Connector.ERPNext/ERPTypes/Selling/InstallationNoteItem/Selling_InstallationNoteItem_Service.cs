/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling.InstallationNoteItem
{
    public class Selling_InstallationNoteItem_Service : SubServiceBase<ERP_Selling_InstallationNoteItem>
    {
        public Selling_InstallationNoteItem_Service(ERPNextClient client) : base(_DockType.Selling_InstallationNoteItem, client) { }

        protected override ERP_Selling_InstallationNoteItem FromERPObject(ERPObject obj)
        {
            return new ERP_Selling_InstallationNoteItem(obj);
        }

        /* custom functions can be added here */

    }
}

