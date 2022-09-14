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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.BankGuarantee
{
    public partial class ERP_Accounts_BankGuarantee : ERPNextObjectBase
    {
        public ERP_Accounts_BankGuarantee() : this(new ERPObject(_DocType.Accounts_BankGuarantee)) { }
        public ERP_Accounts_BankGuarantee(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Accounts_BankGuarantee>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Accounts_BankGuarantee>(columnName);
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

        [ColumnInfo("bg_type", "varchar(140)", isNullable: true)]
        public string? BgType
        {
            get { return data.bg_type; }
            set { data.bg_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_doctype", "varchar(140)", isNullable: true)]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_docname", "varchar(140)", isNullable: true)]
        public string? ReferenceDocname
        {
            get { return data.reference_docname; }
            set { data.reference_docname = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("supplier", "varchar(140)", isNullable: true)]
        public string? Supplier
        {
            get { return data.supplier; }
            set { data.supplier = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("project", "varchar(140)", isNullable: true)]
        public string? Project
        {
            get { return data.project; }
            set { data.project = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amount", "decimal(21,9)", isNullable: false)]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [ColumnInfo("start_date", "date", isNullable: true)]
        public DateOnly? StartDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.start_date); }
            set { data.start_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("validity", "int(11)", isNullable: false)]
        public int Validity
        {
            get { return data.validity; }
            set { data.validity = value; }
        }

        [ColumnInfo("end_date", "date", isNullable: true)]
        public DateOnly? EndDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.end_date); }
            set { data.end_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("bank", "varchar(140)", isNullable: true)]
        public string? Bank
        {
            get { return data.bank; }
            set { data.bank = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("bank_account", "varchar(140)", isNullable: true)]
        public string? BankAccount
        {
            get { return data.bank_account; }
            set { data.bank_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("account", "varchar(140)", isNullable: true)]
        public string? Account
        {
            get { return data.account; }
            set { data.account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("bank_account_no", "varchar(140)", isNullable: true)]
        public string? BankAccountNo
        {
            get { return data.bank_account_no; }
            set { data.bank_account_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("iban", "varchar(140)", isNullable: true)]
        public string? Iban
        {
            get { return data.iban; }
            set { data.iban = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("branch_code", "varchar(140)", isNullable: true)]
        public string? BranchCode
        {
            get { return data.branch_code; }
            set { data.branch_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("swift_number", "varchar(140)", isNullable: true)]
        public string? SwiftNumber
        {
            get { return data.swift_number; }
            set { data.swift_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("more_information", "longtext", isNullable: true)]
        public string? MoreInformation
        {
            get { return data.more_information; }
            set { data.more_information = value; }
        }

        [ColumnInfo("bank_guarantee_number", "varchar(140)", isNullable: true)]
        public string? BankGuaranteeNumber
        {
            get { return data.bank_guarantee_number; }
            set { data.bank_guarantee_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("name_of_beneficiary", "varchar(140)", isNullable: true)]
        public string? NameOfBeneficiary
        {
            get { return data.name_of_beneficiary; }
            set { data.name_of_beneficiary = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("margin_money", "decimal(21,9)", isNullable: false)]
        public decimal MarginMoney
        {
            get { return data.margin_money; }
            set { data.margin_money = value; }
        }

        [ColumnInfo("charges", "decimal(21,9)", isNullable: false)]
        public decimal Charges
        {
            get { return data.charges; }
            set { data.charges = value; }
        }

        [ColumnInfo("fixed_deposit_number", "varchar(140)", isNullable: true)]
        public string? FixedDepositNumber
        {
            get { return data.fixed_deposit_number; }
            set { data.fixed_deposit_number = ERPNextConverter.TruncateString(value, 140); }
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

