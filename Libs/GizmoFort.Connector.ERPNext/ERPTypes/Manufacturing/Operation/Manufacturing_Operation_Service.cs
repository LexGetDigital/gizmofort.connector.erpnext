/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.Operation
{
    public class Manufacturing_Operation_Service : SubServiceBase<ERP_Manufacturing_Operation>
    {
        public Manufacturing_Operation_Service(ERPNextClient client) : base(_DockType.Manufacturing_Operation, client) { }

        protected override ERP_Manufacturing_Operation FromERPObject(ERPObject obj)
        {
            return new ERP_Manufacturing_Operation(obj);
        }

        /* custom functions can be added here */

    }
}

