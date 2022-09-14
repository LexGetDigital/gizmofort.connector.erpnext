/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/13/2022 7:48:39 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.PurchaseOrderItemSupplied
{
    public partial class ERP_Buying_PurchaseOrderItemSupplied : ERPNextObjectBase
    {
        public ERP_Buying_PurchaseOrderItemSupplied() : this(new ERPObject(_DocType.Buying_PurchaseOrderItemSupplied)) { }
        public ERP_Buying_PurchaseOrderItemSupplied(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Buying_PurchaseOrderItemSupplied>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Buying_PurchaseOrderItemSupplied>(columnName);
        //}

        [ColumnInfo("name", "varchar(140)", isNullable: false)]
        public string Name
        {
            get { return data.name; }
            set { data.name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("creation", "datetime(6)", isNullable: true)]
        public DateTimeOffset? Creation
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.creation); }
            set { data.creation = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("modified", "datetime(6)", isNullable: true)]
        public DateTimeOffset? Modified
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.modified); }
            set { data.modified = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("modified_by", "varchar(140)", isNullable: true)]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("owner", "varchar(140)", isNullable: true)]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("docstatus", "int(1)", isNullable: false)]
        public Docstatus Docstatus
        {
            get { return (Docstatus)data.docstatus; }
            set { data.docstatus = (int)value; }
        }

        [ColumnInfo("idx", "int(8)", isNullable: false)]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [ColumnInfo("main_item_code", "varchar(140)", isNullable: true)]
        public string? MainItemCode
        {
            get { return data.main_item_code; }
            set { data.main_item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("rm_item_code", "varchar(140)", isNullable: true)]
        public string? RmItemCode
        {
            get { return data.rm_item_code; }
            set { data.rm_item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("stock_uom", "varchar(140)", isNullable: true)]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reserve_warehouse", "varchar(140)", isNullable: true)]
        public string? ReserveWarehouse
        {
            get { return data.reserve_warehouse; }
            set { data.reserve_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("conversion_factor", "decimal(21,9)", isNullable: false)]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        [ColumnInfo("bom_detail_no", "varchar(140)", isNullable: true)]
        public string? BomDetailNo
        {
            get { return data.bom_detail_no; }
            set { data.bom_detail_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_name", "varchar(140)", isNullable: true)]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("rate", "decimal(21,9)", isNullable: false)]
        public decimal Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [ColumnInfo("amount", "decimal(21,9)", isNullable: false)]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [ColumnInfo("required_qty", "decimal(21,9)", isNullable: false)]
        public decimal RequiredQty
        {
            get { return data.required_qty; }
            set { data.required_qty = value; }
        }

        [ColumnInfo("supplied_qty", "decimal(21,9)", isNullable: false)]
        public decimal SuppliedQty
        {
            get { return data.supplied_qty; }
            set { data.supplied_qty = value; }
        }

        [ColumnInfo("consumed_qty", "decimal(21,9)", isNullable: false)]
        public decimal ConsumedQty
        {
            get { return data.consumed_qty; }
            set { data.consumed_qty = value; }
        }

        [ColumnInfo("returned_qty", "decimal(21,9)", isNullable: false)]
        public decimal ReturnedQty
        {
            get { return data.returned_qty; }
            set { data.returned_qty = value; }
        }

        [ColumnInfo("total_supplied_qty", "decimal(21,9)", isNullable: false)]
        public decimal TotalSuppliedQty
        {
            get { return data.total_supplied_qty; }
            set { data.total_supplied_qty = value; }
        }

        [ColumnInfo("parent", "varchar(140)", isNullable: true)]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parentfield", "varchar(140)", isNullable: true)]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parenttype", "varchar(140)", isNullable: true)]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = ERPNextConverter.TruncateString(value, 140); }
        }


    }
}

