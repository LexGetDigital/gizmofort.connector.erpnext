/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.PackingSlipItem
{
    /*** NOTE: This file can be modified and will not be re-generated unless deleted ***/

    public partial class ERP_Stock_PackingSlipItem : ERPNextObjectBase
    {
        public static ERP_Stock_PackingSlipItem CreateNew(string name /* add other parameters as needed */ )
        {
            ERP_Stock_PackingSlipItem obj = new()
            {
                Name = name
                /* set other properties from parameters here */
            };
            return obj;
        }
    }
}

