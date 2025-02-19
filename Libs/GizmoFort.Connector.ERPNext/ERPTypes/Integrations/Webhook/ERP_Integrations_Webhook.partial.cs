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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.Webhook
{
    public partial class ERP_Integrations_Webhook : ERPNextObjectBase
    {
        public ERP_Integrations_Webhook() : this(new ERPObject(_DocType.Integrations_Webhook)) { }
        public ERP_Integrations_Webhook(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("webhook_doctype", "varchar(140)", isNullable: true)]
        public string? WebhookDoctype
        {
            get { return data.webhook_doctype; }
            set { data.webhook_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("webhook_docevent", "varchar(140)", isNullable: true)]
        public string? WebhookDocevent
        {
            get { return data.webhook_docevent; }
            set { data.webhook_docevent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("enabled", "int(1)", isNullable: false)]
        public bool Enabled
        {
            get { return ERPNextConverter.IntToBool((int)data.enabled); }
            set { data.enabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("condition", "text", isNullable: true)]
        public string? Condition
        {
            get { return data.condition; }
            set { data.condition = value; }
        }

        [ColumnInfo("request_url", "varchar(140)", isNullable: true)]
        public string? RequestUrl
        {
            get { return data.request_url; }
            set { data.request_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("request_method", "varchar(140)", isNullable: true)]
        public string? RequestMethod
        {
            get { return data.request_method; }
            set { data.request_method = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("request_structure", "varchar(140)", isNullable: true)]
        public string? RequestStructure
        {
            get { return data.request_structure; }
            set { data.request_structure = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("enable_security", "int(1)", isNullable: false)]
        public bool EnableSecurity
        {
            get { return ERPNextConverter.IntToBool((int)data.enable_security); }
            set { data.enable_security = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("webhook_secret", "text", isNullable: true)]
        public string? WebhookSecret
        {
            get { return data.webhook_secret; }
            set { data.webhook_secret = value; }
        }

        [ColumnInfo("webhook_json", "longtext", isNullable: true)]
        public string? WebhookJson
        {
            get { return data.webhook_json; }
            set { data.webhook_json = value; }
        }

        [ColumnInfo("preview_document", "varchar(140)", isNullable: true)]
        public string? PreviewDocument
        {
            get { return data.preview_document; }
            set { data.preview_document = ERPNextConverter.TruncateString(value, 140); }
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

