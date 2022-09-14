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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.Account
{
    public partial class ERP_Accounts_Account : ERPNextObjectBase
    {
        public ERP_Accounts_Account() : this(new ERPObject(_DocType.Accounts_Account)) { }
        public ERP_Accounts_Account(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Accounts_Account>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Accounts_Account>(columnName);
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

        [ColumnInfo("disabled", "int(1)", isNullable: false)]
        public bool Disabled
        {
            get { return ERPNextConverter.IntToBool((int)data.disabled); }
            set { data.disabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("account_name", "varchar(140)", isNullable: true)]
        public string? AccountName
        {
            get { return data.account_name; }
            set { data.account_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("account_number", "varchar(140)", isNullable: true)]
        public string? AccountNumber
        {
            get { return data.account_number; }
            set { data.account_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_group", "int(1)", isNullable: false)]
        public bool IsGroup
        {
            get { return ERPNextConverter.IntToBool((int)data.is_group); }
            set { data.is_group = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("root_type", "varchar(140)", isNullable: true)]
        public string? RootType
        {
            get { return data.root_type; }
            set { data.root_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("report_type", "varchar(140)", isNullable: true)]
        public string? ReportType
        {
            get { return data.report_type; }
            set { data.report_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("account_currency", "varchar(140)", isNullable: true)]
        public string? AccountCurrency
        {
            get { return data.account_currency; }
            set { data.account_currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("inter_company_account", "int(1)", isNullable: false)]
        public bool InterCompanyAccount
        {
            get { return ERPNextConverter.IntToBool((int)data.inter_company_account); }
            set { data.inter_company_account = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("parent_account", "varchar(140)", isNullable: true)]
        public string? ParentAccount
        {
            get { return data.parent_account; }
            set { data.parent_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("account_type", "varchar(140)", isNullable: true)]
        public string? AccountType
        {
            get { return data.account_type; }
            set { data.account_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("tax_rate", "decimal(21,9)", isNullable: false)]
        public decimal TaxRate
        {
            get { return data.tax_rate; }
            set { data.tax_rate = value; }
        }

        [ColumnInfo("freeze_account", "varchar(140)", isNullable: true)]
        public string? FreezeAccount
        {
            get { return data.freeze_account; }
            set { data.freeze_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("balance_must_be", "varchar(140)", isNullable: true)]
        public string? BalanceMustBe
        {
            get { return data.balance_must_be; }
            set { data.balance_must_be = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lft", "int(11)", isNullable: false)]
        public int Lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        [ColumnInfo("rgt", "int(11)", isNullable: false)]
        public int Rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        [ColumnInfo("old_parent", "varchar(140)", isNullable: true)]
        public string? OldParent
        {
            get { return data.old_parent; }
            set { data.old_parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("include_in_gross", "int(1)", isNullable: false)]
        public bool IncludeInGross
        {
            get { return ERPNextConverter.IntToBool((int)data.include_in_gross); }
            set { data.include_in_gross = ERPNextConverter.BoolToInt(value); }
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

