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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.Dunning
{
    public partial class ERP_Accounts_Dunning : ERPNextObjectBase
    {
        public ERP_Accounts_Dunning() : this(new ERPObject(_DocType.Accounts_Dunning)) { }
        public ERP_Accounts_Dunning(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("title", "varchar(140)", isNullable: true)]
        public string? Title
        {
            get { return data.title; }
            set { data.title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sales_invoice", "varchar(140)", isNullable: true)]
        public string? SalesInvoice
        {
            get { return data.sales_invoice; }
            set { data.sales_invoice = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_name", "varchar(140)", isNullable: true)]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("outstanding_amount", "decimal(21,9)", isNullable: false)]
        public decimal OutstandingAmount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        [ColumnInfo("currency", "varchar(140)", isNullable: true)]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("conversion_rate", "decimal(21,9)", isNullable: false)]
        public decimal ConversionRate
        {
            get { return data.conversion_rate; }
            set { data.conversion_rate = value; }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("posting_date", "date", isNullable: true)]
        public DateOnly? PostingDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.posting_date); }
            set { data.posting_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("posting_time", "time(6)", isNullable: true)]
        public TimeSpan? PostingTime
        {
            get { return ERPNextConverter.StringToTimeSpan(data.posting_time); }
            set { data.posting_time = ERPNextConverter.TimeSpanToString(value, 6); }
        }

        [ColumnInfo("due_date", "date", isNullable: true)]
        public DateOnly? DueDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.due_date); }
            set { data.due_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("overdue_days", "int(11)", isNullable: false)]
        public int OverdueDays
        {
            get { return data.overdue_days; }
            set { data.overdue_days = value; }
        }

        [ColumnInfo("address_display", "text", isNullable: true)]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [ColumnInfo("contact_display", "text", isNullable: true)]
        public string? ContactDisplay
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        [ColumnInfo("contact_mobile", "text", isNullable: true)]
        public string? ContactMobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        [ColumnInfo("contact_email", "varchar(140)", isNullable: true)]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company_address_display", "text", isNullable: true)]
        public string? CompanyAddressDisplay
        {
            get { return data.company_address_display; }
            set { data.company_address_display = value; }
        }

        [ColumnInfo("dunning_type", "varchar(140)", isNullable: true)]
        public string? DunningType
        {
            get { return data.dunning_type; }
            set { data.dunning_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("dunning_fee", "decimal(21,9)", isNullable: false)]
        public decimal DunningFee
        {
            get { return data.dunning_fee; }
            set { data.dunning_fee = value; }
        }

        [ColumnInfo("rate_of_interest", "decimal(21,9)", isNullable: false)]
        public decimal RateOfInterest
        {
            get { return data.rate_of_interest; }
            set { data.rate_of_interest = value; }
        }

        [ColumnInfo("interest_amount", "decimal(21,9)", isNullable: false)]
        public decimal InterestAmount
        {
            get { return data.interest_amount; }
            set { data.interest_amount = value; }
        }

        [ColumnInfo("dunning_amount", "decimal(21,9)", isNullable: false)]
        public decimal DunningAmount
        {
            get { return data.dunning_amount; }
            set { data.dunning_amount = value; }
        }

        [ColumnInfo("grand_total", "decimal(21,9)", isNullable: false)]
        public decimal GrandTotal
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }

        [ColumnInfo("income_account", "varchar(140)", isNullable: true)]
        public string? IncomeAccount
        {
            get { return data.income_account; }
            set { data.income_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("language", "varchar(140)", isNullable: true)]
        public string? Language
        {
            get { return data.language; }
            set { data.language = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("body_text", "longtext", isNullable: true)]
        public string? BodyText
        {
            get { return data.body_text; }
            set { data.body_text = value; }
        }

        [ColumnInfo("letter_head", "varchar(140)", isNullable: true)]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("closing_text", "longtext", isNullable: true)]
        public string? ClosingText
        {
            get { return data.closing_text; }
            set { data.closing_text = value; }
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

