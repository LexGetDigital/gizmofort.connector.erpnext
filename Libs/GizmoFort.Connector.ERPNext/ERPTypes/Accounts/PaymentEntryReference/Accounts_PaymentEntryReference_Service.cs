/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentEntryReference
{
    public class Accounts_PaymentEntryReference_Service : SubServiceBase<ERP_Accounts_PaymentEntryReference>
    {
        public Accounts_PaymentEntryReference_Service(ERPNextClient client) : base(_DockType.Accounts_PaymentEntryReference, client) { }

        protected override ERP_Accounts_PaymentEntryReference FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_PaymentEntryReference(obj);
        }

        /* custom functions can be added here */

    }
}

