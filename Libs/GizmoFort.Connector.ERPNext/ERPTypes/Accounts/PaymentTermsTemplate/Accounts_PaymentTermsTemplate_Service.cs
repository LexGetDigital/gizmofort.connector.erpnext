/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentTermsTemplate
{
    public class Accounts_PaymentTermsTemplate_Service : SubServiceBase<ERP_Accounts_PaymentTermsTemplate>
    {
        public Accounts_PaymentTermsTemplate_Service(ERPNextClient client) : base(_DockType.Accounts_PaymentTermsTemplate, client) { }

        protected override ERP_Accounts_PaymentTermsTemplate FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_PaymentTermsTemplate(obj);
        }

        /* custom functions can be added here */

    }
}

