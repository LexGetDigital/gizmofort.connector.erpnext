/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/12/2022 2:29:08 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentLedgerEntry
{
    public partial class ERP_Accounts_PaymentLedgerEntry : ERPNextObjectBase
    {
        public ERP_Accounts_PaymentLedgerEntry() : this(new ERPObject(_DockType.Accounts_PaymentLedgerEntry)) { }
        public ERP_Accounts_PaymentLedgerEntry(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_PaymentLedgerEntry>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_PaymentLedgerEntry>(columnName);
        }


        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTimeOffset? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTimeOffset? Modified
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

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("account_type")]
        public string? AccountType
        {
            get { return data.account_type; }
            set { data.account_type = value; }
        }

        [Column("account")]
        public string? Account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        [Column("party_type")]
        public string? PartyType
        {
            get { return data.party_type; }
            set { data.party_type = value; }
        }

        [Column("party")]
        public string? Party
        {
            get { return data.party; }
            set { data.party = value; }
        }

        [Column("due_date")]
        public DateOnly? DueDate
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("finance_book")]
        public string? FinanceBook
        {
            get { return data.finance_book; }
            set { data.finance_book = value; }
        }

        [Column("voucher_type")]
        public string? VoucherType
        {
            get { return data.voucher_type; }
            set { data.voucher_type = value; }
        }

        [Column("voucher_no")]
        public string? VoucherNo
        {
            get { return data.voucher_no; }
            set { data.voucher_no = value; }
        }

        [Column("against_voucher_type")]
        public string? AgainstVoucherType
        {
            get { return data.against_voucher_type; }
            set { data.against_voucher_type = value; }
        }

        [Column("against_voucher_no")]
        public string? AgainstVoucherNo
        {
            get { return data.against_voucher_no; }
            set { data.against_voucher_no = value; }
        }

        [Column("amount")]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [Column("account_currency")]
        public string? AccountCurrency
        {
            get { return data.account_currency; }
            set { data.account_currency = value; }
        }

        [Column("amount_in_account_currency")]
        public decimal AmountInAccountCurrency
        {
            get { return data.amount_in_account_currency; }
            set { data.amount_in_account_currency = value; }
        }

        [Column("delinked")]
        public int Delinked
        {
            get { return data.delinked; }
            set { data.delinked = value; }
        }

        [Column("remarks")]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
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

