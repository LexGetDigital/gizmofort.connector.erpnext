/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/14/2022 8:42:56 AM
********************************************************************/

using System;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.Bin
{
    public partial class ERP_Stock_Bin : ERPNextObjectBase
    {
        public ERP_Stock_Bin() : this(new ERPObject(_DocType.Stock_Bin)) { }
        public ERP_Stock_Bin(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_code", "varchar(140)", isNullable: true)]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reserved_qty", "decimal(21,9)", isNullable: false)]
        public decimal ReservedQty
        {
            get { return data.reserved_qty; }
            set { data.reserved_qty = value; }
        }

        [ColumnInfo("actual_qty", "decimal(21,9)", isNullable: false)]
        public decimal ActualQty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        [ColumnInfo("ordered_qty", "decimal(21,9)", isNullable: false)]
        public decimal OrderedQty
        {
            get { return data.ordered_qty; }
            set { data.ordered_qty = value; }
        }

        [ColumnInfo("indented_qty", "decimal(21,9)", isNullable: false)]
        public decimal IndentedQty
        {
            get { return data.indented_qty; }
            set { data.indented_qty = value; }
        }

        [ColumnInfo("planned_qty", "decimal(21,9)", isNullable: false)]
        public decimal PlannedQty
        {
            get { return data.planned_qty; }
            set { data.planned_qty = value; }
        }

        [ColumnInfo("projected_qty", "decimal(21,9)", isNullable: false)]
        public decimal ProjectedQty
        {
            get { return data.projected_qty; }
            set { data.projected_qty = value; }
        }

        [ColumnInfo("reserved_qty_for_production", "decimal(21,9)", isNullable: false)]
        public decimal ReservedQtyForProduction
        {
            get { return data.reserved_qty_for_production; }
            set { data.reserved_qty_for_production = value; }
        }

        [ColumnInfo("reserved_qty_for_sub_contract", "decimal(21,9)", isNullable: false)]
        public decimal ReservedQtyForSubContract
        {
            get { return data.reserved_qty_for_sub_contract; }
            set { data.reserved_qty_for_sub_contract = value; }
        }

        [ColumnInfo("ma_rate", "decimal(21,9)", isNullable: false)]
        public decimal MaRate
        {
            get { return data.ma_rate; }
            set { data.ma_rate = value; }
        }

        [ColumnInfo("stock_uom", "varchar(140)", isNullable: true)]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("fcfs_rate", "decimal(21,9)", isNullable: false)]
        public decimal FcfsRate
        {
            get { return data.fcfs_rate; }
            set { data.fcfs_rate = value; }
        }

        [ColumnInfo("valuation_rate", "decimal(21,9)", isNullable: false)]
        public decimal ValuationRate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        [ColumnInfo("stock_value", "decimal(21,9)", isNullable: false)]
        public decimal StockValue
        {
            get { return data.stock_value; }
            set { data.stock_value = value; }
        }

        [ColumnInfo("_user_tags", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [ColumnInfo("_comments", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [ColumnInfo("_assign", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [ColumnInfo("_liked_by", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

