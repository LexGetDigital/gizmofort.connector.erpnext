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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PricingRuleDetail
{
    public partial class ERP_Accounts_PricingRuleDetail : ERPNextObjectBase
    {
        public ERP_Accounts_PricingRuleDetail() : this(new ERPObject(_DocType.Accounts_PricingRuleDetail)) { }
        public ERP_Accounts_PricingRuleDetail(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Accounts_PricingRuleDetail>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Accounts_PricingRuleDetail>(columnName);
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

        [ColumnInfo("pricing_rule", "varchar(140)", isNullable: true)]
        public string? PricingRule
        {
            get { return data.pricing_rule; }
            set { data.pricing_rule = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_code", "varchar(140)", isNullable: true)]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("margin_type", "varchar(140)", isNullable: true)]
        public string? MarginType
        {
            get { return data.margin_type; }
            set { data.margin_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("rate_or_discount", "varchar(140)", isNullable: true)]
        public string? RateOrDiscount
        {
            get { return data.rate_or_discount; }
            set { data.rate_or_discount = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("child_docname", "varchar(140)", isNullable: true)]
        public string? ChildDocname
        {
            get { return data.child_docname; }
            set { data.child_docname = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("rule_applied", "int(1)", isNullable: false)]
        public bool RuleApplied
        {
            get { return ERPNextConverter.IntToBool((int)data.rule_applied); }
            set { data.rule_applied = ERPNextConverter.BoolToInt(value); }
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

