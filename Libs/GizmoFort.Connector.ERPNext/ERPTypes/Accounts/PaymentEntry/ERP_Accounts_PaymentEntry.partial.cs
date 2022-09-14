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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentEntry
{
    public partial class ERP_Accounts_PaymentEntry : ERPNextObjectBase
    {
        public ERP_Accounts_PaymentEntry() : this(new ERPObject(_DocType.Accounts_PaymentEntry)) { }
        public ERP_Accounts_PaymentEntry(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Accounts_PaymentEntry>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Accounts_PaymentEntry>(columnName);
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

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_type", "varchar(140)", isNullable: true)]
        public string? PaymentType
        {
            get { return data.payment_type; }
            set { data.payment_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_order_status", "varchar(140)", isNullable: true)]
        public string? PaymentOrderStatus
        {
            get { return data.payment_order_status; }
            set { data.payment_order_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("posting_date", "date", isNullable: true)]
        public DateOnly? PostingDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.posting_date); }
            set { data.posting_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("mode_of_payment", "varchar(140)", isNullable: true)]
        public string? ModeOfPayment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("party_type", "varchar(140)", isNullable: true)]
        public string? PartyType
        {
            get { return data.party_type; }
            set { data.party_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("party", "varchar(140)", isNullable: true)]
        public string? Party
        {
            get { return data.party; }
            set { data.party = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("party_name", "varchar(140)", isNullable: true)]
        public string? PartyName
        {
            get { return data.party_name; }
            set { data.party_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("bank_account", "varchar(140)", isNullable: true)]
        public string? BankAccount
        {
            get { return data.bank_account; }
            set { data.bank_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("party_bank_account", "varchar(140)", isNullable: true)]
        public string? PartyBankAccount
        {
            get { return data.party_bank_account; }
            set { data.party_bank_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("contact_person", "varchar(140)", isNullable: true)]
        public string? ContactPerson
        {
            get { return data.contact_person; }
            set { data.contact_person = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("contact_email", "varchar(140)", isNullable: true)]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("party_balance", "decimal(21,9)", isNullable: false)]
        public decimal PartyBalance
        {
            get { return data.party_balance; }
            set { data.party_balance = value; }
        }

        [ColumnInfo("paid_from", "varchar(140)", isNullable: true)]
        public string? PaidFrom
        {
            get { return data.paid_from; }
            set { data.paid_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("paid_from_account_type", "varchar(140)", isNullable: true)]
        public string? PaidFromAccountType
        {
            get { return data.paid_from_account_type; }
            set { data.paid_from_account_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("paid_from_account_currency", "varchar(140)", isNullable: true)]
        public string? PaidFromAccountCurrency
        {
            get { return data.paid_from_account_currency; }
            set { data.paid_from_account_currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("paid_from_account_balance", "decimal(21,9)", isNullable: false)]
        public decimal PaidFromAccountBalance
        {
            get { return data.paid_from_account_balance; }
            set { data.paid_from_account_balance = value; }
        }

        [ColumnInfo("paid_to", "varchar(140)", isNullable: true)]
        public string? PaidTo
        {
            get { return data.paid_to; }
            set { data.paid_to = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("paid_to_account_type", "varchar(140)", isNullable: true)]
        public string? PaidToAccountType
        {
            get { return data.paid_to_account_type; }
            set { data.paid_to_account_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("paid_to_account_currency", "varchar(140)", isNullable: true)]
        public string? PaidToAccountCurrency
        {
            get { return data.paid_to_account_currency; }
            set { data.paid_to_account_currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("paid_to_account_balance", "decimal(21,9)", isNullable: false)]
        public decimal PaidToAccountBalance
        {
            get { return data.paid_to_account_balance; }
            set { data.paid_to_account_balance = value; }
        }

        [ColumnInfo("paid_amount", "decimal(21,9)", isNullable: false)]
        public decimal PaidAmount
        {
            get { return data.paid_amount; }
            set { data.paid_amount = value; }
        }

        [ColumnInfo("paid_amount_after_tax", "decimal(21,9)", isNullable: false)]
        public decimal PaidAmountAfterTax
        {
            get { return data.paid_amount_after_tax; }
            set { data.paid_amount_after_tax = value; }
        }

        [ColumnInfo("source_exchange_rate", "decimal(21,9)", isNullable: false)]
        public decimal SourceExchangeRate
        {
            get { return data.source_exchange_rate; }
            set { data.source_exchange_rate = value; }
        }

        [ColumnInfo("base_paid_amount", "decimal(21,9)", isNullable: false)]
        public decimal BasePaidAmount
        {
            get { return data.base_paid_amount; }
            set { data.base_paid_amount = value; }
        }

        [ColumnInfo("base_paid_amount_after_tax", "decimal(21,9)", isNullable: false)]
        public decimal BasePaidAmountAfterTax
        {
            get { return data.base_paid_amount_after_tax; }
            set { data.base_paid_amount_after_tax = value; }
        }

        [ColumnInfo("received_amount", "decimal(21,9)", isNullable: false)]
        public decimal ReceivedAmount
        {
            get { return data.received_amount; }
            set { data.received_amount = value; }
        }

        [ColumnInfo("received_amount_after_tax", "decimal(21,9)", isNullable: false)]
        public decimal ReceivedAmountAfterTax
        {
            get { return data.received_amount_after_tax; }
            set { data.received_amount_after_tax = value; }
        }

        [ColumnInfo("target_exchange_rate", "decimal(21,9)", isNullable: false)]
        public decimal TargetExchangeRate
        {
            get { return data.target_exchange_rate; }
            set { data.target_exchange_rate = value; }
        }

        [ColumnInfo("base_received_amount", "decimal(21,9)", isNullable: false)]
        public decimal BaseReceivedAmount
        {
            get { return data.base_received_amount; }
            set { data.base_received_amount = value; }
        }

        [ColumnInfo("base_received_amount_after_tax", "decimal(21,9)", isNullable: false)]
        public decimal BaseReceivedAmountAfterTax
        {
            get { return data.base_received_amount_after_tax; }
            set { data.base_received_amount_after_tax = value; }
        }

        [ColumnInfo("total_allocated_amount", "decimal(21,9)", isNullable: false)]
        public decimal TotalAllocatedAmount
        {
            get { return data.total_allocated_amount; }
            set { data.total_allocated_amount = value; }
        }

        [ColumnInfo("base_total_allocated_amount", "decimal(21,9)", isNullable: false)]
        public decimal BaseTotalAllocatedAmount
        {
            get { return data.base_total_allocated_amount; }
            set { data.base_total_allocated_amount = value; }
        }

        [ColumnInfo("unallocated_amount", "decimal(21,9)", isNullable: false)]
        public decimal UnallocatedAmount
        {
            get { return data.unallocated_amount; }
            set { data.unallocated_amount = value; }
        }

        [ColumnInfo("difference_amount", "decimal(21,9)", isNullable: false)]
        public decimal DifferenceAmount
        {
            get { return data.difference_amount; }
            set { data.difference_amount = value; }
        }

        [ColumnInfo("purchase_taxes_and_charges_template", "varchar(140)", isNullable: true)]
        public string? PurchaseTaxesAndChargesTemplate
        {
            get { return data.purchase_taxes_and_charges_template; }
            set { data.purchase_taxes_and_charges_template = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sales_taxes_and_charges_template", "varchar(140)", isNullable: true)]
        public string? SalesTaxesAndChargesTemplate
        {
            get { return data.sales_taxes_and_charges_template; }
            set { data.sales_taxes_and_charges_template = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("apply_tax_withholding_amount", "int(1)", isNullable: false)]
        public bool ApplyTaxWithholdingAmount
        {
            get { return ERPNextConverter.IntToBool((int)data.apply_tax_withholding_amount); }
            set { data.apply_tax_withholding_amount = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("tax_withholding_category", "varchar(140)", isNullable: true)]
        public string? TaxWithholdingCategory
        {
            get { return data.tax_withholding_category; }
            set { data.tax_withholding_category = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("base_total_taxes_and_charges", "decimal(21,9)", isNullable: false)]
        public decimal BaseTotalTaxesAndCharges
        {
            get { return data.base_total_taxes_and_charges; }
            set { data.base_total_taxes_and_charges = value; }
        }

        [ColumnInfo("total_taxes_and_charges", "decimal(21,9)", isNullable: false)]
        public decimal TotalTaxesAndCharges
        {
            get { return data.total_taxes_and_charges; }
            set { data.total_taxes_and_charges = value; }
        }

        [ColumnInfo("reference_no", "varchar(140)", isNullable: true)]
        public string? ReferenceNo
        {
            get { return data.reference_no; }
            set { data.reference_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_date", "date", isNullable: true)]
        public DateOnly? ReferenceDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.reference_date); }
            set { data.reference_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("clearance_date", "date", isNullable: true)]
        public DateOnly? ClearanceDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.clearance_date); }
            set { data.clearance_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("project", "varchar(140)", isNullable: true)]
        public string? Project
        {
            get { return data.project; }
            set { data.project = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("custom_remarks", "int(1)", isNullable: false)]
        public bool CustomRemarks
        {
            get { return ERPNextConverter.IntToBool((int)data.custom_remarks); }
            set { data.custom_remarks = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("remarks", "text", isNullable: true)]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        [ColumnInfo("letter_head", "varchar(140)", isNullable: true)]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("print_heading", "varchar(140)", isNullable: true)]
        public string? PrintHeading
        {
            get { return data.print_heading; }
            set { data.print_heading = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("bank", "varchar(140)", isNullable: true)]
        public string? Bank
        {
            get { return data.bank; }
            set { data.bank = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("bank_account_no", "varchar(140)", isNullable: true)]
        public string? BankAccountNo
        {
            get { return data.bank_account_no; }
            set { data.bank_account_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_order", "varchar(140)", isNullable: true)]
        public string? PaymentOrder
        {
            get { return data.payment_order; }
            set { data.payment_order = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("auto_repeat", "varchar(140)", isNullable: true)]
        public string? AutoRepeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("title", "varchar(140)", isNullable: true)]
        public string? Title
        {
            get { return data.title; }
            set { data.title = ERPNextConverter.TruncateString(value, 140); }
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

