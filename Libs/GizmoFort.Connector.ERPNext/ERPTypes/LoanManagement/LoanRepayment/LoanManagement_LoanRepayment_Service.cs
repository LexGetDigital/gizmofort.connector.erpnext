/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanRepayment
{
    public class LoanManagement_LoanRepayment_Service : SubServiceBase<ERP_LoanManagement_LoanRepayment>
    {
        public LoanManagement_LoanRepayment_Service(ERPNextClient client) : base(_DockType.LoanManagement_LoanRepayment, client) { }

        protected override ERP_LoanManagement_LoanRepayment FromERPObject(ERPObject obj)
        {
            return new ERP_LoanManagement_LoanRepayment(obj);
        }

        /* custom functions can be added here */

    }
}

