/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.JournalEntryTemplate
{
    public class Accounts_JournalEntryTemplate_Service : SubServiceBase<ERP_Accounts_JournalEntryTemplate>
    {
        public Accounts_JournalEntryTemplate_Service(ERPNextClient client) : base(_DockType.Accounts_JournalEntryTemplate, client) { }

        protected override ERP_Accounts_JournalEntryTemplate FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_JournalEntryTemplate(obj);
        }

        /* custom functions can be added here */

    }
}

