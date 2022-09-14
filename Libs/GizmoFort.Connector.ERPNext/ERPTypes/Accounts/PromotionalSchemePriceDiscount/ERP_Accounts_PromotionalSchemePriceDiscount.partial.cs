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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PromotionalSchemePriceDiscount
{
    public partial class ERP_Accounts_PromotionalSchemePriceDiscount : ERPNextObjectBase
    {
        public ERP_Accounts_PromotionalSchemePriceDiscount() : this(new ERPObject(_DocType.Accounts_PromotionalSchemePriceDiscount)) { }
        public ERP_Accounts_PromotionalSchemePriceDiscount(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("disable", "int(1)", isNullable: false)]
        public bool Disable
        {
            get { return ERPNextConverter.IntToBool((int)data.disable); }
            set { data.disable = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("apply_multiple_pricing_rules", "int(1)", isNullable: false)]
        public bool ApplyMultiplePricingRules
        {
            get { return ERPNextConverter.IntToBool((int)data.apply_multiple_pricing_rules); }
            set { data.apply_multiple_pricing_rules = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("rule_description", "text", isNullable: true)]
        public string? RuleDescription
        {
            get { return data.rule_description; }
            set { data.rule_description = value; }
        }

        [ColumnInfo("min_qty", "decimal(21,9)", isNullable: false)]
        public decimal MinQty
        {
            get { return data.min_qty; }
            set { data.min_qty = value; }
        }

        [ColumnInfo("max_qty", "decimal(21,9)", isNullable: false)]
        public decimal MaxQty
        {
            get { return data.max_qty; }
            set { data.max_qty = value; }
        }

        [ColumnInfo("min_amount", "decimal(21,9)", isNullable: false)]
        public decimal MinAmount
        {
            get { return data.min_amount; }
            set { data.min_amount = value; }
        }

        [ColumnInfo("max_amount", "decimal(21,9)", isNullable: false)]
        public decimal MaxAmount
        {
            get { return data.max_amount; }
            set { data.max_amount = value; }
        }

        [ColumnInfo("rate_or_discount", "varchar(140)", isNullable: true)]
        public string? RateOrDiscount
        {
            get { return data.rate_or_discount; }
            set { data.rate_or_discount = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("rate", "decimal(21,9)", isNullable: false)]
        public decimal Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [ColumnInfo("discount_amount", "decimal(21,9)", isNullable: false)]
        public decimal DiscountAmount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        [ColumnInfo("discount_percentage", "decimal(21,9)", isNullable: false)]
        public decimal DiscountPercentage
        {
            get { return data.discount_percentage; }
            set { data.discount_percentage = value; }
        }

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("threshold_percentage", "decimal(21,9)", isNullable: false)]
        public decimal ThresholdPercentage
        {
            get { return data.threshold_percentage; }
            set { data.threshold_percentage = value; }
        }

        [ColumnInfo("validate_applied_rule", "int(1)", isNullable: false)]
        public bool ValidateAppliedRule
        {
            get { return ERPNextConverter.IntToBool((int)data.validate_applied_rule); }
            set { data.validate_applied_rule = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("priority", "varchar(140)", isNullable: true)]
        public string? Priority
        {
            get { return data.priority; }
            set { data.priority = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("apply_discount_on_rate", "int(1)", isNullable: false)]
        public bool ApplyDiscountOnRate
        {
            get { return ERPNextConverter.IntToBool((int)data.apply_discount_on_rate); }
            set { data.apply_discount_on_rate = ERPNextConverter.BoolToInt(value); }
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

