/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.CRM.EmailCampaign
{
    public partial class ERP_CRM_EmailCampaign : ERPNextObjectBase
    {
        public ERP_CRM_EmailCampaign() : this(new ERPObject(_DockType.CRM_EmailCampaign)) { }
        public ERP_CRM_EmailCampaign(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_CRM_EmailCampaign>(propertyName);
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

        [Column("campaign_name")]
        public string? CampaignName
        {
            get { return data.campaign_name; }
            set { data.campaign_name = value; }
        }

        [Column("email_campaign_for")]
        public string? EmailCampaignFor
        {
            get { return data.email_campaign_for; }
            set { data.email_campaign_for = value; }
        }

        [Column("recipient")]
        public string? Recipient
        {
            get { return data.recipient; }
            set { data.recipient = value; }
        }

        [Column("sender")]
        public string? Sender
        {
            get { return data.sender; }
            set { data.sender = value; }
        }

        [Column("start_date")]
        public DateOnly? StartDate
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        [Column("end_date")]
        public DateOnly? EndDate
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
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

