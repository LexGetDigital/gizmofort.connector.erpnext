/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanInterestAccrual
{
    public class LoanManagement_LoanInterestAccrual_Service : SubServiceBase<ERP_LoanManagement_LoanInterestAccrual>
    {
        public LoanManagement_LoanInterestAccrual_Service(ERPNextClient client) : base(_DockType.LoanManagement_LoanInterestAccrual, client) { }

        protected override ERP_LoanManagement_LoanInterestAccrual FromERPObject(ERPObject obj)
        {
            return new ERP_LoanManagement_LoanInterestAccrual(obj);
        }

        /* custom functions can be added here */

    }
}

