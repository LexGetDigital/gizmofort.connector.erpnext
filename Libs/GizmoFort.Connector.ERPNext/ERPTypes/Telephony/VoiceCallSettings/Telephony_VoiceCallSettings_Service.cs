/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Telephony.VoiceCallSettings
{
    public class Telephony_VoiceCallSettings_Service : SubServiceBase<ERP_Telephony_VoiceCallSettings>
    {
        public Telephony_VoiceCallSettings_Service(ERPNextClient client) : base(_DockType.Telephony_VoiceCallSettings, client) { }

        protected override ERP_Telephony_VoiceCallSettings FromERPObject(ERPObject obj)
        {
            return new ERP_Telephony_VoiceCallSettings(obj);
        }

        /* custom functions can be added here */

    }
}

