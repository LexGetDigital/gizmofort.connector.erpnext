/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.PersonalDataDeletionRequest
{
    public class Website_PersonalDataDeletionRequest_Service : SubServiceBase<ERP_Website_PersonalDataDeletionRequest>
    {
        public Website_PersonalDataDeletionRequest_Service(ERPNextClient client) : base(_DockType.Website_PersonalDataDeletionRequest, client) { }

        protected override ERP_Website_PersonalDataDeletionRequest FromERPObject(ERPObject obj)
        {
            return new ERP_Website_PersonalDataDeletionRequest(obj);
        }

        /* custom functions can be added here */

    }
}

