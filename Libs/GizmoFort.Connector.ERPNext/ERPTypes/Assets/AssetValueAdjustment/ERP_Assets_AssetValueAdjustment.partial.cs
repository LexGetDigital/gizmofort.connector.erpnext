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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.AssetValueAdjustment
{
    public partial class ERP_Assets_AssetValueAdjustment : ERPNextObjectBase
    {
        public ERP_Assets_AssetValueAdjustment() : this(new ERPObject(_DocType.Assets_AssetValueAdjustment)) { }
        public ERP_Assets_AssetValueAdjustment(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("asset", "varchar(140)", isNullable: true)]
        public string? Asset
        {
            get { return data.asset; }
            set { data.asset = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("asset_category", "varchar(140)", isNullable: true)]
        public string? AssetCategory
        {
            get { return data.asset_category; }
            set { data.asset_category = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("date", "date", isNullable: true)]
        public DateOnly? Date
        {
            get { return ERPNextConverter.StringToDateOnly(data.date); }
            set { data.date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("finance_book", "varchar(140)", isNullable: true)]
        public string? FinanceBook
        {
            get { return data.finance_book; }
            set { data.finance_book = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("current_asset_value", "decimal(21,9)", isNullable: false)]
        public decimal CurrentAssetValue
        {
            get { return data.current_asset_value; }
            set { data.current_asset_value = value; }
        }

        [ColumnInfo("new_asset_value", "decimal(21,9)", isNullable: false)]
        public decimal NewAssetValue
        {
            get { return data.new_asset_value; }
            set { data.new_asset_value = value; }
        }

        [ColumnInfo("difference_amount", "decimal(21,9)", isNullable: false)]
        public decimal DifferenceAmount
        {
            get { return data.difference_amount; }
            set { data.difference_amount = value; }
        }

        [ColumnInfo("journal_entry", "varchar(140)", isNullable: true)]
        public string? JournalEntry
        {
            get { return data.journal_entry; }
            set { data.journal_entry = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
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

