/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.AdvanceTaxesandCharges
{
    public class Accounts_AdvanceTaxesandCharges_Service : SubServiceBase<ERP_Accounts_AdvanceTaxesandCharges>
    {
        public Accounts_AdvanceTaxesandCharges_Service(ERPNextClient client) : base(_DockType.Accounts_AdvanceTaxesandCharges, client) { }

        protected override ERP_Accounts_AdvanceTaxesandCharges FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_AdvanceTaxesandCharges(obj);
        }

        /* custom functions can be added here */

    }
}

