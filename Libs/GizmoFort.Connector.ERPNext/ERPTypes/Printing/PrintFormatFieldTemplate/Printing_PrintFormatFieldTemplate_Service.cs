/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Printing.PrintFormatFieldTemplate
{
    public class Printing_PrintFormatFieldTemplate_Service : SubServiceBase<ERP_Printing_PrintFormatFieldTemplate>
    {
        public Printing_PrintFormatFieldTemplate_Service(ERPNextClient client) : base(_DockType.Printing_PrintFormatFieldTemplate, client) { }

        protected override ERP_Printing_PrintFormatFieldTemplate FromERPObject(ERPObject obj)
        {
            return new ERP_Printing_PrintFormatFieldTemplate(obj);
        }

        /* custom functions can be added here */

    }
}

