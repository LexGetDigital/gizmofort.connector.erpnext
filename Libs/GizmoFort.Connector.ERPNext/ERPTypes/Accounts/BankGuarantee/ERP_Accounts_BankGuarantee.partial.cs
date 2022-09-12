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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.BankGuarantee
{
    public partial class ERP_Accounts_BankGuarantee : ERPNextObjectBase
    {
        public ERP_Accounts_BankGuarantee() : this(new ERPObject(_DockType.Accounts_BankGuarantee)) { }
        public ERP_Accounts_BankGuarantee(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_BankGuarantee>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_BankGuarantee>(columnName);
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

        [Column("bg_type")]
        public string? BgType
        {
            get { return data.bg_type; }
            set { data.bg_type = value; }
        }

        [Column("reference_doctype")]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        [Column("reference_docname")]
        public string? ReferenceDocname
        {
            get { return data.reference_docname; }
            set { data.reference_docname = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("supplier")]
        public string? Supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("amount")]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [Column("start_date")]
        public DateOnly? StartDate
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        [Column("validity")]
        public int Validity
        {
            get { return data.validity; }
            set { data.validity = value; }
        }

        [Column("end_date")]
        public DateOnly? EndDate
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        [Column("bank")]
        public string? Bank
        {
            get { return data.bank; }
            set { data.bank = value; }
        }

        [Column("bank_account")]
        public string? BankAccount
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }

        [Column("account")]
        public string? Account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        [Column("bank_account_no")]
        public string? BankAccountNo
        {
            get { return data.bank_account_no; }
            set { data.bank_account_no = value; }
        }

        [Column("iban")]
        public string? Iban
        {
            get { return data.iban; }
            set { data.iban = value; }
        }

        [Column("branch_code")]
        public string? BranchCode
        {
            get { return data.branch_code; }
            set { data.branch_code = value; }
        }

        [Column("swift_number")]
        public string? SwiftNumber
        {
            get { return data.swift_number; }
            set { data.swift_number = value; }
        }

        [Column("more_information")]
        public string? MoreInformation
        {
            get { return data.more_information; }
            set { data.more_information = value; }
        }

        [Column("bank_guarantee_number")]
        public string? BankGuaranteeNumber
        {
            get { return data.bank_guarantee_number; }
            set { data.bank_guarantee_number = value; }
        }

        [Column("name_of_beneficiary")]
        public string? NameOfBeneficiary
        {
            get { return data.name_of_beneficiary; }
            set { data.name_of_beneficiary = value; }
        }

        [Column("margin_money")]
        public decimal MarginMoney
        {
            get { return data.margin_money; }
            set { data.margin_money = value; }
        }

        [Column("charges")]
        public decimal Charges
        {
            get { return data.charges; }
            set { data.charges = value; }
        }

        [Column("fixed_deposit_number")]
        public string? FixedDepositNumber
        {
            get { return data.fixed_deposit_number; }
            set { data.fixed_deposit_number = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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

