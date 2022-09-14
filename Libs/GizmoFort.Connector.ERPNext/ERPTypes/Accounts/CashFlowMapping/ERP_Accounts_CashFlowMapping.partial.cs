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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.CashFlowMapping
{
    public partial class ERP_Accounts_CashFlowMapping : ERPNextObjectBase
    {
        public ERP_Accounts_CashFlowMapping() : this(new ERPObject(_DocType.Accounts_CashFlowMapping)) { }
        public ERP_Accounts_CashFlowMapping(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Accounts_CashFlowMapping>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Accounts_CashFlowMapping>(columnName);
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

        [ColumnInfo("mapping_name", "varchar(140)", isNullable: true)]
        public string? MappingName
        {
            get { return data.mapping_name; }
            set { data.mapping_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("label", "varchar(140)", isNullable: true)]
        public string? Label
        {
            get { return data.label; }
            set { data.label = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_finance_cost", "int(1)", isNullable: false)]
        public bool IsFinanceCost
        {
            get { return ERPNextConverter.IntToBool((int)data.is_finance_cost); }
            set { data.is_finance_cost = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_working_capital", "int(1)", isNullable: false)]
        public bool IsWorkingCapital
        {
            get { return ERPNextConverter.IntToBool((int)data.is_working_capital); }
            set { data.is_working_capital = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_finance_cost_adjustment", "int(1)", isNullable: false)]
        public bool IsFinanceCostAdjustment
        {
            get { return ERPNextConverter.IntToBool((int)data.is_finance_cost_adjustment); }
            set { data.is_finance_cost_adjustment = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_income_tax_liability", "int(1)", isNullable: false)]
        public bool IsIncomeTaxLiability
        {
            get { return ERPNextConverter.IntToBool((int)data.is_income_tax_liability); }
            set { data.is_income_tax_liability = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_income_tax_expense", "int(1)", isNullable: false)]
        public bool IsIncomeTaxExpense
        {
            get { return ERPNextConverter.IntToBool((int)data.is_income_tax_expense); }
            set { data.is_income_tax_expense = ERPNextConverter.BoolToInt(value); }
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

