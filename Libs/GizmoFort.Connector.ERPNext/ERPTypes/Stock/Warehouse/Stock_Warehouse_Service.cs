/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/8/2022 10:31:56 PM
********************************************************************/

using GizmoFort.Connector.ERPNext.PublicInterfaces;
using GizmoFort.Connector.ERPNext.PublicInterfaces.SubServices;
using GizmoFort.Connector.ERPNext.PublicTypes;
using System.Collections.Generic;
using System.Linq;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.Warehouse
{
    public class Stock_Warehouse_Service : SubServiceBase<ERP_Stock_Warehouse>
    {
        public Stock_Warehouse_Service(ERPNextClient client) : base(_DockType.Stock_Warehouse, client) { }

        protected override ERP_Stock_Warehouse FromERPObject(ERPObject obj)
        {
            return new ERP_Stock_Warehouse(obj);
        }

        public List<ERP_Stock_Warehouse>? GetRootWarehouses()
        {
            FetchListOption listOption = new FetchListOption();
            listOption.Filters.Add(new ERPFilter(DocType.Stock_Warehouse, "parent_warehouse", OperatorFilter.Equals, ""));
            List<ERPObject>? warehouses_list = client.ListObjects(DocType.Stock_Warehouse, listOption);
            if (warehouses_list is null)
                return null;
            return warehouses_list.Select(x => new ERP_Stock_Warehouse(x)).ToList();
        }

        /* custom functions can be added here */

    }
}

