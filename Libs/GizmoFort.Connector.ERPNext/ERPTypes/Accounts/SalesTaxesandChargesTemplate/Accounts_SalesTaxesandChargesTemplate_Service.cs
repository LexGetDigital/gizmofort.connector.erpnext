/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.SalesTaxesandChargesTemplate
{
    public class Accounts_SalesTaxesandChargesTemplate_Service : SubServiceBase<ERP_Accounts_SalesTaxesandChargesTemplate>
    {
        public Accounts_SalesTaxesandChargesTemplate_Service(ERPNextClient client) : base(_DockType.Accounts_SalesTaxesandChargesTemplate, client) { }

        protected override ERP_Accounts_SalesTaxesandChargesTemplate FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_SalesTaxesandChargesTemplate(obj);
        }

        /* custom functions can be added here */

    }
}

