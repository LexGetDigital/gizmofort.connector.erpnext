/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.OnboardingStepMap
{
    public class Desk_OnboardingStepMap_Service : SubServiceBase<ERP_Desk_OnboardingStepMap>
    {
        public Desk_OnboardingStepMap_Service(ERPNextClient client) : base(_DockType.Desk_OnboardingStepMap, client) { }

        protected override ERP_Desk_OnboardingStepMap FromERPObject(ERPObject obj)
        {
            return new ERP_Desk_OnboardingStepMap(obj);
        }

        /* custom functions can be added here */

    }
}

