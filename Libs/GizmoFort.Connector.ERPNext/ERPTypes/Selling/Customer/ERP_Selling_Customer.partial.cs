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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling.Customer
{
    public partial class ERP_Selling_Customer : ERPNextObjectBase
    {
        public ERP_Selling_Customer() : this(new ERPObject(_DocType.Selling_Customer)) { }
        public ERP_Selling_Customer(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("salutation", "varchar(140)", isNullable: true)]
        public string? Salutation
        {
            get { return data.salutation; }
            set { data.salutation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_name", "varchar(140)", isNullable: true)]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("gender", "varchar(140)", isNullable: true)]
        public string? Gender
        {
            get { return data.gender; }
            set { data.gender = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("default_bank_account", "varchar(140)", isNullable: true)]
        public string? DefaultBankAccount
        {
            get { return data.default_bank_account; }
            set { data.default_bank_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("tax_id", "varchar(140)", isNullable: true)]
        public string? TaxId
        {
            get { return data.tax_id; }
            set { data.tax_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("tax_category", "varchar(140)", isNullable: true)]
        public string? TaxCategory
        {
            get { return data.tax_category; }
            set { data.tax_category = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("tax_withholding_category", "varchar(140)", isNullable: true)]
        public string? TaxWithholdingCategory
        {
            get { return data.tax_withholding_category; }
            set { data.tax_withholding_category = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lead_name", "varchar(140)", isNullable: true)]
        public string? LeadName
        {
            get { return data.lead_name; }
            set { data.lead_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("opportunity_name", "varchar(140)", isNullable: true)]
        public string? OpportunityName
        {
            get { return data.opportunity_name; }
            set { data.opportunity_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("customer_group", "varchar(140)", isNullable: true)]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_type", "varchar(140)", isNullable: true)]
        public string? CustomerType
        {
            get { return data.customer_type; }
            set { data.customer_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("territory", "varchar(140)", isNullable: true)]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("account_manager", "varchar(140)", isNullable: true)]
        public string? AccountManager
        {
            get { return data.account_manager; }
            set { data.account_manager = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("so_required", "int(1)", isNullable: false)]
        public bool SoRequired
        {
            get { return ERPNextConverter.IntToBool((int)data.so_required); }
            set { data.so_required = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("dn_required", "int(1)", isNullable: false)]
        public bool DnRequired
        {
            get { return ERPNextConverter.IntToBool((int)data.dn_required); }
            set { data.dn_required = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_internal_customer", "int(1)", isNullable: false)]
        public bool IsInternalCustomer
        {
            get { return ERPNextConverter.IntToBool((int)data.is_internal_customer); }
            set { data.is_internal_customer = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("represents_company", "varchar(140)", isNullable: true)]
        public string? RepresentsCompany
        {
            get { return data.represents_company; }
            set { data.represents_company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("disabled", "int(1)", isNullable: false)]
        public bool Disabled
        {
            get { return ERPNextConverter.IntToBool((int)data.disabled); }
            set { data.disabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("default_currency", "varchar(140)", isNullable: true)]
        public string? DefaultCurrency
        {
            get { return data.default_currency; }
            set { data.default_currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("default_price_list", "varchar(140)", isNullable: true)]
        public string? DefaultPriceList
        {
            get { return data.default_price_list; }
            set { data.default_price_list = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_primary_contact", "varchar(140)", isNullable: true)]
        public string? CustomerPrimaryContact
        {
            get { return data.customer_primary_contact; }
            set { data.customer_primary_contact = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("mobile_no", "varchar(140)", isNullable: true)]
        public string? MobileNo
        {
            get { return data.mobile_no; }
            set { data.mobile_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("email_id", "varchar(140)", isNullable: true)]
        public string? EmailId
        {
            get { return data.email_id; }
            set { data.email_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_primary_address", "varchar(140)", isNullable: true)]
        public string? CustomerPrimaryAddress
        {
            get { return data.customer_primary_address; }
            set { data.customer_primary_address = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("primary_address", "text", isNullable: true)]
        public string? PrimaryAddress
        {
            get { return data.primary_address; }
            set { data.primary_address = value; }
        }

        [ColumnInfo("payment_terms", "varchar(140)", isNullable: true)]
        public string? PaymentTerms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_details", "text", isNullable: true)]
        public string? CustomerDetails
        {
            get { return data.customer_details; }
            set { data.customer_details = value; }
        }

        [ColumnInfo("market_segment", "varchar(140)", isNullable: true)]
        public string? MarketSegment
        {
            get { return data.market_segment; }
            set { data.market_segment = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("industry", "varchar(140)", isNullable: true)]
        public string? Industry
        {
            get { return data.industry; }
            set { data.industry = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("website", "varchar(140)", isNullable: true)]
        public string? Website
        {
            get { return data.website; }
            set { data.website = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("language", "varchar(140)", isNullable: true)]
        public string? Language
        {
            get { return data.language; }
            set { data.language = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_frozen", "int(1)", isNullable: false)]
        public bool IsFrozen
        {
            get { return ERPNextConverter.IntToBool((int)data.is_frozen); }
            set { data.is_frozen = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("loyalty_program", "varchar(140)", isNullable: true)]
        public string? LoyaltyProgram
        {
            get { return data.loyalty_program; }
            set { data.loyalty_program = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("loyalty_program_tier", "varchar(140)", isNullable: true)]
        public string? LoyaltyProgramTier
        {
            get { return data.loyalty_program_tier; }
            set { data.loyalty_program_tier = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("default_sales_partner", "varchar(140)", isNullable: true)]
        public string? DefaultSalesPartner
        {
            get { return data.default_sales_partner; }
            set { data.default_sales_partner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("default_commission_rate", "decimal(21,9)", isNullable: false)]
        public decimal DefaultCommissionRate
        {
            get { return data.default_commission_rate; }
            set { data.default_commission_rate = value; }
        }

        [ColumnInfo("customer_pos_id", "varchar(140)", isNullable: true)]
        public string? CustomerPosId
        {
            get { return data.customer_pos_id; }
            set { data.customer_pos_id = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("exempt_from_sales_tax", "int(1)", isNullable: false)]
        public bool ExemptFromSalesTax
        {
            get { return ERPNextConverter.IntToBool((int)data.exempt_from_sales_tax); }
            set { data.exempt_from_sales_tax = ERPNextConverter.BoolToInt(value); }
        }


    }
}

