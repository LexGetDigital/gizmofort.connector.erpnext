/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Regional.LowerDeductionCertificate
{
    public class Regional_LowerDeductionCertificate_Service : SubServiceBase<ERP_Regional_LowerDeductionCertificate>
    {
        public Regional_LowerDeductionCertificate_Service(ERPNextClient client) : base(_DockType.Regional_LowerDeductionCertificate, client) { }

        protected override ERP_Regional_LowerDeductionCertificate FromERPObject(ERPObject obj)
        {
            return new ERP_Regional_LowerDeductionCertificate(obj);
        }

        /* custom functions can be added here */

    }
}

