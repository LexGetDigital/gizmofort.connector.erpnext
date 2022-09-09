/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Contacts.Address
{
    public class Contacts_Address_Service : SubServiceBase<ERP_Contacts_Address>
    {
        public Contacts_Address_Service(ERPNextClient client) : base(_DockType.Contacts_Address, client) { }

        protected override ERP_Contacts_Address FromERPObject(ERPObject obj)
        {
            return new ERP_Contacts_Address(obj);
        }

        /* custom functions can be added here */

    }
}

