/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Regional.UAEVATSettings
{
    public class Regional_UAEVATSettings_Service : SubServiceBase<ERP_Regional_UAEVATSettings>
    {
        public Regional_UAEVATSettings_Service(ERPNextClient client) : base(_DockType.Regional_UAEVATSettings, client) { }

        protected override ERP_Regional_UAEVATSettings FromERPObject(ERPObject obj)
        {
            return new ERP_Regional_UAEVATSettings(obj);
        }

        /* custom functions can be added here */

    }
}

