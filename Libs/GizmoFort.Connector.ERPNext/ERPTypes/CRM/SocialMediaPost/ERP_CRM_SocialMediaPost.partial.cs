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

namespace GizmoFort.Connector.ERPNext.ERPTypes.CRM.SocialMediaPost
{
    public partial class ERP_CRM_SocialMediaPost : ERPNextObjectBase
    {
        public ERP_CRM_SocialMediaPost() : this(new ERPObject(_DockType.CRM_SocialMediaPost)) { }
        public ERP_CRM_SocialMediaPost(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_CRM_SocialMediaPost>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_CRM_SocialMediaPost>(columnName);
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

        [Column("title")]
        public string? Title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        [Column("campaign_name")]
        public string? CampaignName
        {
            get { return data.campaign_name; }
            set { data.campaign_name = value; }
        }

        [Column("scheduled_time")]
        public DateTimeOffset? ScheduledTime
        {
            get { return data.scheduled_time; }
            set { data.scheduled_time = value; }
        }

        [Column("post_status")]
        public string? PostStatus
        {
            get { return data.post_status; }
            set { data.post_status = value; }
        }

        [Column("twitter")]
        public int Twitter
        {
            get { return data.twitter; }
            set { data.twitter = value; }
        }

        [Column("linkedin")]
        public int Linkedin
        {
            get { return data.linkedin; }
            set { data.linkedin = value; }
        }

        [Column("twitter_post_id")]
        public string? TwitterPostId
        {
            get { return data.twitter_post_id; }
            set { data.twitter_post_id = value; }
        }

        [Column("linkedin_post_id")]
        public string? LinkedinPostId
        {
            get { return data.linkedin_post_id; }
            set { data.linkedin_post_id = value; }
        }

        [Column("text")]
        public string? Text
        {
            get { return data.text; }
            set { data.text = value; }
        }

        [Column("linkedin_post")]
        public string? LinkedinPost
        {
            get { return data.linkedin_post; }
            set { data.linkedin_post = value; }
        }

        [Column("image")]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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

