/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/12/2022 11:57:48 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.MaterialRequestPlanItem
{
    public partial class ERP_Manufacturing_MaterialRequestPlanItem : ERPNextObjectBase
    {
        public ERP_Manufacturing_MaterialRequestPlanItem() : this(new ERPObject(_DockType.Manufacturing_MaterialRequestPlanItem)) { }
        public ERP_Manufacturing_MaterialRequestPlanItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Manufacturing_MaterialRequestPlanItem>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Manufacturing_MaterialRequestPlanItem>(columnName);
        }


        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTime? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTime? Modified
        {
            get { return data.modified; }
            set { data.modified = value; }
        }

        [Column("modified_by")]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = value; }
        }

        [Column("owner")]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = value; }
        }

        [Column("docstatus")]
        public int Docstatus
        {
            get { return data.docstatus; }
            set { data.docstatus = value; }
        }

        [Column("idx")]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("from_warehouse")]
        public string? FromWarehouse
        {
            get { return data.from_warehouse; }
            set { data.from_warehouse = value; }
        }

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("material_request_type")]
        public string? MaterialRequestType
        {
            get { return data.material_request_type; }
            set { data.material_request_type = value; }
        }

        [Column("actual_qty")]
        public decimal ActualQty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        [Column("ordered_qty")]
        public decimal OrderedQty
        {
            get { return data.ordered_qty; }
            set { data.ordered_qty = value; }
        }

        [Column("required_bom_qty")]
        public decimal RequiredBomQty
        {
            get { return data.required_bom_qty; }
            set { data.required_bom_qty = value; }
        }

        [Column("quantity")]
        public decimal Quantity
        {
            get { return data.quantity; }
            set { data.quantity = value; }
        }

        [Column("uom")]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        [Column("projected_qty")]
        public decimal ProjectedQty
        {
            get { return data.projected_qty; }
            set { data.projected_qty = value; }
        }

        [Column("reserved_qty_for_production")]
        public decimal ReservedQtyForProduction
        {
            get { return data.reserved_qty_for_production; }
            set { data.reserved_qty_for_production = value; }
        }

        [Column("safety_stock")]
        public decimal SafetyStock
        {
            get { return data.safety_stock; }
            set { data.safety_stock = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("min_order_qty")]
        public decimal MinOrderQty
        {
            get { return data.min_order_qty; }
            set { data.min_order_qty = value; }
        }

        [Column("sales_order")]
        public string? SalesOrder
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        [Column("requested_qty")]
        public decimal RequestedQty
        {
            get { return data.requested_qty; }
            set { data.requested_qty = value; }
        }

        [Column("parent")]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = value; }
        }

        [Column("parentfield")]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = value; }
        }

        [Column("parenttype")]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = value; }
        }


    }
}

