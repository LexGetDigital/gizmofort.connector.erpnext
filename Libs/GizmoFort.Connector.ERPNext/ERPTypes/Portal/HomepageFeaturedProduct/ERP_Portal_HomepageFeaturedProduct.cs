/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:56:52 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.WrapperTypes;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Portal.HomepageFeaturedProduct
{
    /*** NOTE: This file can be modified and will not be re-generated unless deleted ***/

    public partial class ERP_Portal_HomepageFeaturedProduct : ERPNextObjectBase
    {
        public static ERP_Portal_HomepageFeaturedProduct CreateNew(string name /* add other parameters as needed */ )
        {
            ERP_Portal_HomepageFeaturedProduct obj = new()
            {
                Name = name
                /* set other properties from parameters here */
            };
            return obj;
        }
    }
}

