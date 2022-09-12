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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.AssetValueAdjustment
{
    public partial class ERP_Assets_AssetValueAdjustment : ERPNextObjectBase
    {
        public ERP_Assets_AssetValueAdjustment() : this(new ERPObject(_DockType.Assets_AssetValueAdjustment)) { }
        public ERP_Assets_AssetValueAdjustment(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Assets_AssetValueAdjustment>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Assets_AssetValueAdjustment>(columnName);
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

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("asset")]
        public string? Asset
        {
            get { return data.asset; }
            set { data.asset = value; }
        }

        [Column("asset_category")]
        public string? AssetCategory
        {
            get { return data.asset_category; }
            set { data.asset_category = value; }
        }

        [Column("date")]
        public DateOnly? Date
        {
            get { return data.date; }
            set { data.date = value; }
        }

        [Column("finance_book")]
        public string? FinanceBook
        {
            get { return data.finance_book; }
            set { data.finance_book = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        [Column("current_asset_value")]
        public decimal CurrentAssetValue
        {
            get { return data.current_asset_value; }
            set { data.current_asset_value = value; }
        }

        [Column("new_asset_value")]
        public decimal NewAssetValue
        {
            get { return data.new_asset_value; }
            set { data.new_asset_value = value; }
        }

        [Column("difference_amount")]
        public decimal DifferenceAmount
        {
            get { return data.difference_amount; }
            set { data.difference_amount = value; }
        }

        [Column("journal_entry")]
        public string? JournalEntry
        {
            get { return data.journal_entry; }
            set { data.journal_entry = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("_user_tags")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [Column("_comments")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [Column("_assign")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [Column("_liked_by")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

