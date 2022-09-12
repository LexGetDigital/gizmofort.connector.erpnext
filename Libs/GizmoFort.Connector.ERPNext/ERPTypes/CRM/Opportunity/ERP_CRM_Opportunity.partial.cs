/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/11/2022 7:52:10 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.CRM.Opportunity
{
    public partial class ERP_CRM_Opportunity : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_CRM_Opportunity() : this(new ERPObject(_DockType.CRM_Opportunity)) { }
        public ERP_CRM_Opportunity(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_CRM_Opportunity>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_CRM_Opportunity>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_CRM_Opportunity>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_CRM_Opportunity? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_CRM_Opportunity>(json: json);
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

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("opportunity_from")]
        public string? OpportunityFrom
        {
            get { return data.opportunity_from; }
            set { data.opportunity_from = value; }
        }

        [Column("party_name")]
        public string? PartyName
        {
            get { return data.party_name; }
            set { data.party_name = value; }
        }

        [Column("customer_name")]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("opportunity_type")]
        public string? OpportunityType
        {
            get { return data.opportunity_type; }
            set { data.opportunity_type = value; }
        }

        [Column("source")]
        public string? Source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        [Column("opportunity_owner")]
        public string? OpportunityOwner
        {
            get { return data.opportunity_owner; }
            set { data.opportunity_owner = value; }
        }

        [Column("sales_stage")]
        public string? SalesStage
        {
            get { return data.sales_stage; }
            set { data.sales_stage = value; }
        }

        [Column("expected_closing")]
        public DateOnly? ExpectedClosing
        {
            get { return data.expected_closing; }
            set { data.expected_closing = value; }
        }

        [Column("probability")]
        public decimal Probability
        {
            get { return data.probability; }
            set { data.probability = value; }
        }

        [Column("no_of_employees")]
        public string? NoOfEmployees
        {
            get { return data.no_of_employees; }
            set { data.no_of_employees = value; }
        }

        [Column("annual_revenue")]
        public decimal AnnualRevenue
        {
            get { return data.annual_revenue; }
            set { data.annual_revenue = value; }
        }

        [Column("customer_group")]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        [Column("industry")]
        public string? Industry
        {
            get { return data.industry; }
            set { data.industry = value; }
        }

        [Column("market_segment")]
        public string? MarketSegment
        {
            get { return data.market_segment; }
            set { data.market_segment = value; }
        }

        [Column("website")]
        public string? Website
        {
            get { return data.website; }
            set { data.website = value; }
        }

        [Column("city")]
        public string? City
        {
            get { return data.city; }
            set { data.city = value; }
        }

        [Column("state")]
        public string? State
        {
            get { return data.state; }
            set { data.state = value; }
        }

        [Column("country")]
        public string? Country
        {
            get { return data.country; }
            set { data.country = value; }
        }

        [Column("territory")]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        [Column("conversion_rate")]
        public decimal ConversionRate
        {
            get { return data.conversion_rate; }
            set { data.conversion_rate = value; }
        }

        [Column("opportunity_amount")]
        public decimal OpportunityAmount
        {
            get { return data.opportunity_amount; }
            set { data.opportunity_amount = value; }
        }

        [Column("base_opportunity_amount")]
        public decimal BaseOpportunityAmount
        {
            get { return data.base_opportunity_amount; }
            set { data.base_opportunity_amount = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("campaign")]
        public string? Campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        [Column("transaction_date")]
        public DateOnly? TransactionDate
        {
            get { return data.transaction_date; }
            set { data.transaction_date = value; }
        }

        [Column("language")]
        public string? Language
        {
            get { return data.language; }
            set { data.language = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        [Column("title")]
        public string? Title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        [Column("first_response_time")]
        public decimal? FirstResponseTime
        {
            get { return data.first_response_time; }
            set { data.first_response_time = value; }
        }

        [Column("order_lost_reason")]
        public string? OrderLostReason
        {
            get { return data.order_lost_reason; }
            set { data.order_lost_reason = value; }
        }

        [Column("contact_person")]
        public string? ContactPerson
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        [Column("job_title")]
        public string? JobTitle
        {
            get { return data.job_title; }
            set { data.job_title = value; }
        }

        [Column("contact_email")]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        [Column("contact_mobile")]
        public string? ContactMobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        [Column("whatsapp")]
        public string? Whatsapp
        {
            get { return data.whatsapp; }
            set { data.whatsapp = value; }
        }

        [Column("phone")]
        public string? Phone
        {
            get { return data.phone; }
            set { data.phone = value; }
        }

        [Column("phone_ext")]
        public string? PhoneExt
        {
            get { return data.phone_ext; }
            set { data.phone_ext = value; }
        }

        [Column("customer_address")]
        public string? CustomerAddress
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        [Column("address_display")]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [Column("contact_display")]
        public string? ContactDisplay
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        [Column("base_total")]
        public decimal BaseTotal
        {
            get { return data.base_total; }
            set { data.base_total = value; }
        }

        [Column("total")]
        public decimal Total
        {
            get { return data.total; }
            set { data.total = value; }
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

        [Column("_seen")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}

