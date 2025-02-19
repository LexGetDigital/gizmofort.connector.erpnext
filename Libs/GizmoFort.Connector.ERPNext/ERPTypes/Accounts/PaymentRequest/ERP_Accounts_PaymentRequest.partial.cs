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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentRequest
{
    public partial class ERP_Accounts_PaymentRequest : ERPNextObjectBase
    {
        public ERP_Accounts_PaymentRequest() : this(new ERPObject(_DocType.Accounts_PaymentRequest)) { }
        public ERP_Accounts_PaymentRequest(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("payment_request_type", "varchar(140)", isNullable: true)]
        public string? PaymentRequestType
        {
            get { return data.payment_request_type; }
            set { data.payment_request_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("transaction_date", "date", isNullable: true)]
        public DateOnly? TransactionDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.transaction_date); }
            set { data.transaction_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("reference_doctype", "varchar(140)", isNullable: true)]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_name", "varchar(140)", isNullable: true)]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("grand_total", "decimal(21,9)", isNullable: false)]
        public decimal GrandTotal
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }

        [ColumnInfo("is_a_subscription", "int(1)", isNullable: false)]
        public bool IsASubscription
        {
            get { return ERPNextConverter.IntToBool((int)data.is_a_subscription); }
            set { data.is_a_subscription = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("currency", "varchar(140)", isNullable: true)]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("bank_account", "varchar(140)", isNullable: true)]
        public string? BankAccount
        {
            get { return data.bank_account; }
            set { data.bank_account = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("account", "varchar(140)", isNullable: true)]
        public string? Account
        {
            get { return data.account; }
            set { data.account = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("print_format", "varchar(140)", isNullable: true)]
        public string? PrintFormat
        {
            get { return data.print_format; }
            set { data.print_format = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("email_to", "varchar(140)", isNullable: true)]
        public string? EmailTo
        {
            get { return data.email_to; }
            set { data.email_to = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("subject", "varchar(140)", isNullable: true)]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_gateway_account", "varchar(140)", isNullable: true)]
        public string? PaymentGatewayAccount
        {
            get { return data.payment_gateway_account; }
            set { data.payment_gateway_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("make_sales_invoice", "int(1)", isNullable: false)]
        public bool MakeSalesInvoice
        {
            get { return ERPNextConverter.IntToBool((int)data.make_sales_invoice); }
            set { data.make_sales_invoice = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("message", "text", isNullable: true)]
        public string? Message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        [ColumnInfo("mute_email", "int(1)", isNullable: false)]
        public bool MuteEmail
        {
            get { return ERPNextConverter.IntToBool((int)data.mute_email); }
            set { data.mute_email = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("payment_url", "text", isNullable: true)]
        public string? PaymentUrl
        {
            get { return data.payment_url; }
            set { data.payment_url = value; }
        }

        [ColumnInfo("payment_gateway", "varchar(140)", isNullable: true)]
        public string? PaymentGateway
        {
            get { return data.payment_gateway; }
            set { data.payment_gateway = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_account", "varchar(140)", isNullable: true)]
        public string? PaymentAccount
        {
            get { return data.payment_account; }
            set { data.payment_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_channel", "varchar(140)", isNullable: true)]
        public string? PaymentChannel
        {
            get { return data.payment_channel; }
            set { data.payment_channel = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_order", "varchar(140)", isNullable: true)]
        public string? PaymentOrder
        {
            get { return data.payment_order; }
            set { data.payment_order = ERPNextConverter.TruncateString(value, 140); }
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

