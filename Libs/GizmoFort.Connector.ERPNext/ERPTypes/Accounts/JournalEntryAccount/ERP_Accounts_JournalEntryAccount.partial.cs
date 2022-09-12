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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.JournalEntryAccount
{
    public partial class ERP_Accounts_JournalEntryAccount : ERPNextObjectBase
    {
        public ERP_Accounts_JournalEntryAccount() : this(new ERPObject(_DockType.Accounts_JournalEntryAccount)) { }
        public ERP_Accounts_JournalEntryAccount(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_JournalEntryAccount>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_JournalEntryAccount>(columnName);
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

        [Column("account")]
        public string? Account
        {
            get { return data.account; }
            set { data.account = value; }
        }

        [Column("account_type")]
        public string? AccountType
        {
            get { return data.account_type; }
            set { data.account_type = value; }
        }

        [Column("balance")]
        public decimal Balance
        {
            get { return data.balance; }
            set { data.balance = value; }
        }

        [Column("bank_account")]
        public string? BankAccount
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
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

        [Column("party_balance")]
        public decimal PartyBalance
        {
            get { return data.party_balance; }
            set { data.party_balance = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("account_currency")]
        public string? AccountCurrency
        {
            get { return data.account_currency; }
            set { data.account_currency = value; }
        }

        [Column("exchange_rate")]
        public decimal ExchangeRate
        {
            get { return data.exchange_rate; }
            set { data.exchange_rate = value; }
        }

        [Column("debit_in_account_currency")]
        public decimal DebitInAccountCurrency
        {
            get { return data.debit_in_account_currency; }
            set { data.debit_in_account_currency = value; }
        }

        [Column("debit")]
        public decimal Debit
        {
            get { return data.debit; }
            set { data.debit = value; }
        }

        [Column("credit_in_account_currency")]
        public decimal CreditInAccountCurrency
        {
            get { return data.credit_in_account_currency; }
            set { data.credit_in_account_currency = value; }
        }

        [Column("credit")]
        public decimal Credit
        {
            get { return data.credit; }
            set { data.credit = value; }
        }

        [Column("reference_type")]
        public string? ReferenceType
        {
            get { return data.reference_type; }
            set { data.reference_type = value; }
        }

        [Column("reference_name")]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        [Column("reference_due_date")]
        public string? ReferenceDueDate
        {
            get { return data.reference_due_date; }
            set { data.reference_due_date = value; }
        }

        [Column("reference_detail_no")]
        public string? ReferenceDetailNo
        {
            get { return data.reference_detail_no; }
            set { data.reference_detail_no = value; }
        }

        [Column("is_advance")]
        public string? IsAdvance
        {
            get { return data.is_advance; }
            set { data.is_advance = value; }
        }

        [Column("user_remark")]
        public string? UserRemark
        {
            get { return data.user_remark; }
            set { data.user_remark = value; }
        }

        [Column("against_account")]
        public string? AgainstAccount
        {
            get { return data.against_account; }
            set { data.against_account = value; }
        }

        [Column("parent")]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = value; }
        }

        [Column("parentfield")]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = value; }
        }

        [Column("parenttype")]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = value; }
        }


    }
}

