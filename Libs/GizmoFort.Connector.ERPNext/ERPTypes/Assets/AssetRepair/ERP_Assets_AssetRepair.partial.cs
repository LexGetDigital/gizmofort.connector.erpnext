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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.AssetRepair
{
    public partial class ERP_Assets_AssetRepair : ERPNextObjectBase
    {
        public ERP_Assets_AssetRepair() : this(new ERPObject(_DocType.Assets_AssetRepair)) { }
        public ERP_Assets_AssetRepair(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("asset", "varchar(140)", isNullable: true)]
        public string? Asset
        {
            get { return data.asset; }
            set { data.asset = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("asset_name", "varchar(140)", isNullable: true)]
        public string? AssetName
        {
            get { return data.asset_name; }
            set { data.asset_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("failure_date", "datetime(6)", isNullable: true)]
        public DateTimeOffset? FailureDate
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.failure_date); }
            set { data.failure_date = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("repair_status", "varchar(140)", isNullable: true)]
        public string? RepairStatus
        {
            get { return data.repair_status; }
            set { data.repair_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("completion_date", "datetime(6)", isNullable: true)]
        public DateTimeOffset? CompletionDate
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.completion_date); }
            set { data.completion_date = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("project", "varchar(140)", isNullable: true)]
        public string? Project
        {
            get { return data.project; }
            set { data.project = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("repair_cost", "decimal(21,9)", isNullable: false)]
        public decimal RepairCost
        {
            get { return data.repair_cost; }
            set { data.repair_cost = value; }
        }

        [ColumnInfo("capitalize_repair_cost", "int(1)", isNullable: false)]
        public bool CapitalizeRepairCost
        {
            get { return ERPNextConverter.IntToBool((int)data.capitalize_repair_cost); }
            set { data.capitalize_repair_cost = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("stock_consumption", "int(1)", isNullable: false)]
        public bool StockConsumption
        {
            get { return ERPNextConverter.IntToBool((int)data.stock_consumption); }
            set { data.stock_consumption = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("purchase_invoice", "varchar(140)", isNullable: true)]
        public string? PurchaseInvoice
        {
            get { return data.purchase_invoice; }
            set { data.purchase_invoice = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("total_repair_cost", "decimal(21,9)", isNullable: false)]
        public decimal TotalRepairCost
        {
            get { return data.total_repair_cost; }
            set { data.total_repair_cost = value; }
        }

        [ColumnInfo("stock_entry", "varchar(140)", isNullable: true)]
        public string? StockEntry
        {
            get { return data.stock_entry; }
            set { data.stock_entry = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("increase_in_asset_life", "int(11)", isNullable: false)]
        public int IncreaseInAssetLife
        {
            get { return data.increase_in_asset_life; }
            set { data.increase_in_asset_life = value; }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("actions_performed", "longtext", isNullable: true)]
        public string? ActionsPerformed
        {
            get { return data.actions_performed; }
            set { data.actions_performed = value; }
        }

        [ColumnInfo("downtime", "varchar(140)", isNullable: true)]
        public string? Downtime
        {
            get { return data.downtime; }
            set { data.downtime = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("_seen", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}

