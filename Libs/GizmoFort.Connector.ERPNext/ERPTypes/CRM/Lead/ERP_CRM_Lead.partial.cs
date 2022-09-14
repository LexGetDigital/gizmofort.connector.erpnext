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

namespace GizmoFort.Connector.ERPNext.ERPTypes.CRM.Lead
{
    public partial class ERP_CRM_Lead : ERPNextObjectBase
    {
        public ERP_CRM_Lead() : this(new ERPObject(_DocType.CRM_Lead)) { }
        public ERP_CRM_Lead(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("first_name", "varchar(140)", isNullable: true)]
        public string? FirstName
        {
            get { return data.first_name; }
            set { data.first_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("middle_name", "varchar(140)", isNullable: true)]
        public string? MiddleName
        {
            get { return data.middle_name; }
            set { data.middle_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("last_name", "varchar(140)", isNullable: true)]
        public string? LastName
        {
            get { return data.last_name; }
            set { data.last_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lead_name", "varchar(140)", isNullable: true)]
        public string? LeadName
        {
            get { return data.lead_name; }
            set { data.lead_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("job_title", "varchar(140)", isNullable: true)]
        public string? JobTitle
        {
            get { return data.job_title; }
            set { data.job_title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("gender", "varchar(140)", isNullable: true)]
        public string? Gender
        {
            get { return data.gender; }
            set { data.gender = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("source", "varchar(140)", isNullable: true)]
        public string? Source
        {
            get { return data.source; }
            set { data.source = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lead_owner", "varchar(140)", isNullable: true)]
        public string? LeadOwner
        {
            get { return data.lead_owner; }
            set { data.lead_owner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("type", "varchar(140)", isNullable: true)]
        public string? Type
        {
            get { return data.type; }
            set { data.type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("request_type", "varchar(140)", isNullable: true)]
        public string? RequestType
        {
            get { return data.request_type; }
            set { data.request_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("email_id", "varchar(140)", isNullable: true)]
        public string? EmailId
        {
            get { return data.email_id; }
            set { data.email_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("website", "varchar(140)", isNullable: true)]
        public string? Website
        {
            get { return data.website; }
            set { data.website = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("mobile_no", "varchar(140)", isNullable: true)]
        public string? MobileNo
        {
            get { return data.mobile_no; }
            set { data.mobile_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("whatsapp_no", "varchar(140)", isNullable: true)]
        public string? WhatsappNo
        {
            get { return data.whatsapp_no; }
            set { data.whatsapp_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("phone", "varchar(140)", isNullable: true)]
        public string? Phone
        {
            get { return data.phone; }
            set { data.phone = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("phone_ext", "varchar(140)", isNullable: true)]
        public string? PhoneExt
        {
            get { return data.phone_ext; }
            set { data.phone_ext = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company_name", "varchar(140)", isNullable: true)]
        public string? CompanyName
        {
            get { return data.company_name; }
            set { data.company_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("no_of_employees", "varchar(140)", isNullable: true)]
        public string? NoOfEmployees
        {
            get { return data.no_of_employees; }
            set { data.no_of_employees = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("annual_revenue", "decimal(21,9)", isNullable: false)]
        public decimal AnnualRevenue
        {
            get { return data.annual_revenue; }
            set { data.annual_revenue = value; }
        }

        [ColumnInfo("industry", "varchar(140)", isNullable: true)]
        public string? Industry
        {
            get { return data.industry; }
            set { data.industry = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("market_segment", "varchar(140)", isNullable: true)]
        public string? MarketSegment
        {
            get { return data.market_segment; }
            set { data.market_segment = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("territory", "varchar(140)", isNullable: true)]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("fax", "varchar(140)", isNullable: true)]
        public string? Fax
        {
            get { return data.fax; }
            set { data.fax = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("city", "varchar(140)", isNullable: true)]
        public string? City
        {
            get { return data.city; }
            set { data.city = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("state", "varchar(140)", isNullable: true)]
        public string? State
        {
            get { return data.state; }
            set { data.state = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("country", "varchar(140)", isNullable: true)]
        public string? Country
        {
            get { return data.country; }
            set { data.country = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("qualification_status", "varchar(140)", isNullable: true)]
        public string? QualificationStatus
        {
            get { return data.qualification_status; }
            set { data.qualification_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("qualified_by", "varchar(140)", isNullable: true)]
        public string? QualifiedBy
        {
            get { return data.qualified_by; }
            set { data.qualified_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("qualified_on", "date", isNullable: true)]
        public DateOnly? QualifiedOn
        {
            get { return ERPNextConverter.StringToDateOnly(data.qualified_on); }
            set { data.qualified_on = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("campaign_name", "varchar(140)", isNullable: true)]
        public string? CampaignName
        {
            get { return data.campaign_name; }
            set { data.campaign_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("language", "varchar(140)", isNullable: true)]
        public string? Language
        {
            get { return data.language; }
            set { data.language = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("title", "varchar(140)", isNullable: true)]
        public string? Title
        {
            get { return data.title; }
            set { data.title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("disabled", "int(1)", isNullable: false)]
        public bool Disabled
        {
            get { return ERPNextConverter.IntToBool((int)data.disabled); }
            set { data.disabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("unsubscribed", "int(1)", isNullable: false)]
        public bool Unsubscribed
        {
            get { return ERPNextConverter.IntToBool((int)data.unsubscribed); }
            set { data.unsubscribed = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("blog_subscriber", "int(1)", isNullable: false)]
        public bool BlogSubscriber
        {
            get { return ERPNextConverter.IntToBool((int)data.blog_subscriber); }
            set { data.blog_subscriber = ERPNextConverter.BoolToInt(value); }
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

