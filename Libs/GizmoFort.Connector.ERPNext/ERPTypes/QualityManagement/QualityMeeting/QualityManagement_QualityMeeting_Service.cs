/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.QualityManagement.QualityMeeting
{
    public class QualityManagement_QualityMeeting_Service : SubServiceBase<ERP_QualityManagement_QualityMeeting>
    {
        public QualityManagement_QualityMeeting_Service(ERPNextClient client) : base(_DockType.QualityManagement_QualityMeeting, client) { }

        protected override ERP_QualityManagement_QualityMeeting FromERPObject(ERPObject obj)
        {
            return new ERP_QualityManagement_QualityMeeting(obj);
        }

        /* custom functions can be added here */

    }
}

