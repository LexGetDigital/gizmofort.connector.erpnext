/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.ProcessLoanInterestAccrual
{
    public class LoanManagement_ProcessLoanInterestAccrual_Service : SubServiceBase<ERP_LoanManagement_ProcessLoanInterestAccrual>
    {
        public LoanManagement_ProcessLoanInterestAccrual_Service(ERPNextClient client) : base(_DockType.LoanManagement_ProcessLoanInterestAccrual, client) { }

        protected override ERP_LoanManagement_ProcessLoanInterestAccrual FromERPObject(ERPObject obj)
        {
            return new ERP_LoanManagement_ProcessLoanInterestAccrual(obj);
        }

        /* custom functions can be added here */

    }
}

