/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.BankGuarantee
{
    public class Accounts_BankGuarantee_Service : SubServiceBase<ERP_Accounts_BankGuarantee>
    {
        public Accounts_BankGuarantee_Service(ERPNextClient client) : base(_DockType.Accounts_BankGuarantee, client) { }

        protected override ERP_Accounts_BankGuarantee FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_BankGuarantee(obj);
        }

        /* custom functions can be added here */

    }
}

