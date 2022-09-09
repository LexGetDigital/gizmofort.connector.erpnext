/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Geo.Currency
{
    public class Geo_Currency_Service : SubServiceBase<ERP_Geo_Currency>
    {
        public Geo_Currency_Service(ERPNextClient client) : base(_DockType.Geo_Currency, client) { }

        protected override ERP_Geo_Currency FromERPObject(ERPObject obj)
        {
            return new ERP_Geo_Currency(obj);
        }

        /* custom functions can be added here */

    }
}

