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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.PickList
{
    public partial class ERP_Stock_PickList : ERPNextObjectBase
    {
        public ERP_Stock_PickList() : this(new ERPObject(_DocType.Stock_PickList)) { }
        public ERP_Stock_PickList(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("purpose", "varchar(140)", isNullable: true)]
        public string? Purpose
        {
            get { return data.purpose; }
            set { data.purpose = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_name", "varchar(140)", isNullable: true)]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("work_order", "varchar(140)", isNullable: true)]
        public string? WorkOrder
        {
            get { return data.work_order; }
            set { data.work_order = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("material_request", "varchar(140)", isNullable: true)]
        public string? MaterialRequest
        {
            get { return data.material_request; }
            set { data.material_request = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("for_qty", "decimal(21,9)", isNullable: false)]
        public decimal ForQty
        {
            get { return data.for_qty; }
            set { data.for_qty = value; }
        }

        [ColumnInfo("parent_warehouse", "varchar(140)", isNullable: true)]
        public string? ParentWarehouse
        {
            get { return data.parent_warehouse; }
            set { data.parent_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("scan_barcode", "varchar(140)", isNullable: true)]
        public string? ScanBarcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("scan_mode", "int(1)", isNullable: false)]
        public bool ScanMode
        {
            get { return ERPNextConverter.IntToBool((int)data.scan_mode); }
            set { data.scan_mode = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("prompt_qty", "int(1)", isNullable: false)]
        public bool PromptQty
        {
            get { return ERPNextConverter.IntToBool((int)data.prompt_qty); }
            set { data.prompt_qty = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("group_same_items", "int(1)", isNullable: false)]
        public bool GroupSameItems
        {
            get { return ERPNextConverter.IntToBool((int)data.group_same_items); }
            set { data.group_same_items = ERPNextConverter.BoolToInt(value); }
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

