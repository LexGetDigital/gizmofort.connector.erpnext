/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.Dunning
{
    public class Accounts_Dunning_Service : SubServiceBase<ERP_Accounts_Dunning>
    {
        public Accounts_Dunning_Service(ERPNextClient client) : base(_DockType.Accounts_Dunning, client) { }

        protected override ERP_Accounts_Dunning FromERPObject(ERPObject obj)
        {
            return new ERP_Accounts_Dunning(obj);
        }

        /* custom functions can be added here */

    }
}

