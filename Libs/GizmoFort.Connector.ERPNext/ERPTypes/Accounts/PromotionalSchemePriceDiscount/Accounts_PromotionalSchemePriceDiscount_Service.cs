/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PromotionalSchemePriceDiscount
{
    public class Accounts_PromotionalSchemePriceDiscount_Service : SubServiceBase<ERP_Accounts_PromotionalSchemePriceDiscount>
    {
        public Accounts_PromotionalSchemePriceDiscount_Service(ERPNextClient client) : base(_DockType.Accounts_PromotionalSchemePriceDiscount, client) { }

        protected override ERP_Accounts_PromotionalSchemePriceDiscount FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_PromotionalSchemePriceDiscount(obj);
        }

        /* custom functions can be added here */

    }
}

