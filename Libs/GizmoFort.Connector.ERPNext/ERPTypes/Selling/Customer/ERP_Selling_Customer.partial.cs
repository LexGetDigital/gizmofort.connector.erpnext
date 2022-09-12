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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling.Customer
{
    public partial class ERP_Selling_Customer : ERPNextObjectBase
    {
        public ERP_Selling_Customer() : this(new ERPObject(_DockType.Selling_Customer)) { }
        public ERP_Selling_Customer(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Selling_Customer>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Selling_Customer>(columnName);
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

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("salutation")]
        public string? Salutation
        {
            get { return data.salutation; }
            set { data.salutation = value; }
        }

        [Column("customer_name")]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        [Column("gender")]
        public string? Gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }

        [Column("default_bank_account")]
        public string? DefaultBankAccount
        {
            get { return data.default_bank_account; }
            set { data.default_bank_account = value; }
        }

        [Column("tax_id")]
        public string? TaxId
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        [Column("tax_category")]
        public string? TaxCategory
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        [Column("tax_withholding_category")]
        public string? TaxWithholdingCategory
        {
            get { return data.tax_withholding_category; }
            set { data.tax_withholding_category = value; }
        }

        [Column("lead_name")]
        public string? LeadName
        {
            get { return data.lead_name; }
            set { data.lead_name = value; }
        }

        [Column("opportunity_name")]
        public string? OpportunityName
        {
            get { return data.opportunity_name; }
            set { data.opportunity_name = value; }
        }

        [Column("image")]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [Column("customer_group")]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        [Column("customer_type")]
        public string? CustomerType
        {
            get { return data.customer_type; }
            set { data.customer_type = value; }
        }

        [Column("territory")]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        [Column("account_manager")]
        public string? AccountManager
        {
            get { return data.account_manager; }
            set { data.account_manager = value; }
        }

        [Column("so_required")]
        public int SoRequired
        {
            get { return data.so_required; }
            set { data.so_required = value; }
        }

        [Column("dn_required")]
        public int DnRequired
        {
            get { return data.dn_required; }
            set { data.dn_required = value; }
        }

        [Column("is_internal_customer")]
        public int IsInternalCustomer
        {
            get { return data.is_internal_customer; }
            set { data.is_internal_customer = value; }
        }

        [Column("represents_company")]
        public string? RepresentsCompany
        {
            get { return data.represents_company; }
            set { data.represents_company = value; }
        }

        [Column("disabled")]
        public int Disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        [Column("default_currency")]
        public string? DefaultCurrency
        {
            get { return data.default_currency; }
            set { data.default_currency = value; }
        }

        [Column("default_price_list")]
        public string? DefaultPriceList
        {
            get { return data.default_price_list; }
            set { data.default_price_list = value; }
        }

        [Column("customer_primary_contact")]
        public string? CustomerPrimaryContact
        {
            get { return data.customer_primary_contact; }
            set { data.customer_primary_contact = value; }
        }

        [Column("mobile_no")]
        public string? MobileNo
        {
            get { return data.mobile_no; }
            set { data.mobile_no = value; }
        }

        [Column("email_id")]
        public string? EmailId
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        [Column("customer_primary_address")]
        public string? CustomerPrimaryAddress
        {
            get { return data.customer_primary_address; }
            set { data.customer_primary_address = value; }
        }

        [Column("primary_address")]
        public string? PrimaryAddress
        {
            get { return data.primary_address; }
            set { data.primary_address = value; }
        }

        [Column("payment_terms")]
        public string? PaymentTerms
        {
            get { return data.payment_terms; }
            set { data.payment_terms = value; }
        }

        [Column("customer_details")]
        public string? CustomerDetails
        {
            get { return data.customer_details; }
            set { data.customer_details = value; }
        }

        [Column("market_segment")]
        public string? MarketSegment
        {
            get { return data.market_segment; }
            set { data.market_segment = value; }
        }

        [Column("industry")]
        public string? Industry
        {
            get { return data.industry; }
            set { data.industry = value; }
        }

        [Column("website")]
        public string? Website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        [Column("language")]
        public string? Language
        {
            get { return data.language; }
            set { data.language = value; }
        }

        [Column("is_frozen")]
        public int IsFrozen
        {
            get { return data.is_frozen; }
            set { data.is_frozen = value; }
        }

        [Column("loyalty_program")]
        public string? LoyaltyProgram
        {
            get { return data.loyalty_program; }
            set { data.loyalty_program = value; }
        }

        [Column("loyalty_program_tier")]
        public string? LoyaltyProgramTier
        {
            get { return data.loyalty_program_tier; }
            set { data.loyalty_program_tier = value; }
        }

        [Column("default_sales_partner")]
        public string? DefaultSalesPartner
        {
            get { return data.default_sales_partner; }
            set { data.default_sales_partner = value; }
        }

        [Column("default_commission_rate")]
        public decimal DefaultCommissionRate
        {
            get { return data.default_commission_rate; }
            set { data.default_commission_rate = value; }
        }

        [Column("customer_pos_id")]
        public string? CustomerPosId
        {
            get { return data.customer_pos_id; }
            set { data.customer_pos_id = value; }
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

        [Column("exempt_from_sales_tax")]
        public int ExemptFromSalesTax
        {
            get { return data.exempt_from_sales_tax; }
            set { data.exempt_from_sales_tax = value; }
        }


    }
}

