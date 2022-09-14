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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.ProductionPlan
{
    public partial class ERP_Manufacturing_ProductionPlan : ERPNextObjectBase
    {
        public ERP_Manufacturing_ProductionPlan() : this(new ERPObject(_DocType.Manufacturing_ProductionPlan)) { }
        public ERP_Manufacturing_ProductionPlan(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("get_items_from", "varchar(140)", isNullable: true)]
        public string? GetItemsFrom
        {
            get { return data.get_items_from; }
            set { data.get_items_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("posting_date", "date", isNullable: true)]
        public DateOnly? PostingDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.posting_date); }
            set { data.posting_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("item_code", "varchar(140)", isNullable: true)]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("project", "varchar(140)", isNullable: true)]
        public string? Project
        {
            get { return data.project; }
            set { data.project = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sales_order_status", "varchar(140)", isNullable: true)]
        public string? SalesOrderStatus
        {
            get { return data.sales_order_status; }
            set { data.sales_order_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("from_date", "date", isNullable: true)]
        public DateOnly? FromDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.from_date); }
            set { data.from_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("to_date", "date", isNullable: true)]
        public DateOnly? ToDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.to_date); }
            set { data.to_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("from_delivery_date", "date", isNullable: true)]
        public DateOnly? FromDeliveryDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.from_delivery_date); }
            set { data.from_delivery_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("to_delivery_date", "date", isNullable: true)]
        public DateOnly? ToDeliveryDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.to_delivery_date); }
            set { data.to_delivery_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("combine_items", "int(1)", isNullable: false)]
        public bool CombineItems
        {
            get { return ERPNextConverter.IntToBool((int)data.combine_items); }
            set { data.combine_items = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("combine_sub_items", "int(1)", isNullable: false)]
        public bool CombineSubItems
        {
            get { return ERPNextConverter.IntToBool((int)data.combine_sub_items); }
            set { data.combine_sub_items = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("include_non_stock_items", "int(1)", isNullable: false)]
        public bool IncludeNonStockItems
        {
            get { return ERPNextConverter.IntToBool((int)data.include_non_stock_items); }
            set { data.include_non_stock_items = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("include_subcontracted_items", "int(1)", isNullable: false)]
        public bool IncludeSubcontractedItems
        {
            get { return ERPNextConverter.IntToBool((int)data.include_subcontracted_items); }
            set { data.include_subcontracted_items = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("include_safety_stock", "int(1)", isNullable: false)]
        public bool IncludeSafetyStock
        {
            get { return ERPNextConverter.IntToBool((int)data.include_safety_stock); }
            set { data.include_safety_stock = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("ignore_existing_ordered_qty", "int(1)", isNullable: false)]
        public bool IgnoreExistingOrderedQty
        {
            get { return ERPNextConverter.IntToBool((int)data.ignore_existing_ordered_qty); }
            set { data.ignore_existing_ordered_qty = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("for_warehouse", "varchar(140)", isNullable: true)]
        public string? ForWarehouse
        {
            get { return data.for_warehouse; }
            set { data.for_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("total_planned_qty", "decimal(21,9)", isNullable: false)]
        public decimal TotalPlannedQty
        {
            get { return data.total_planned_qty; }
            set { data.total_planned_qty = value; }
        }

        [ColumnInfo("total_produced_qty", "decimal(21,9)", isNullable: false)]
        public decimal TotalProducedQty
        {
            get { return data.total_produced_qty; }
            set { data.total_produced_qty = value; }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
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

