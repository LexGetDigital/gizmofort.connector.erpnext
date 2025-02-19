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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Email.Notification
{
    public partial class ERP_Email_Notification : ERPNextObjectBase
    {
        public ERP_Email_Notification() : this(new ERPObject(_DocType.Email_Notification)) { }
        public ERP_Email_Notification(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("enabled", "int(1)", isNullable: false)]
        public bool Enabled
        {
            get { return ERPNextConverter.IntToBool((int)data.enabled); }
            set { data.enabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("channel", "varchar(140)", isNullable: true)]
        public string? Channel
        {
            get { return data.channel; }
            set { data.channel = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("slack_webhook_url", "varchar(140)", isNullable: true)]
        public string? SlackWebhookUrl
        {
            get { return data.slack_webhook_url; }
            set { data.slack_webhook_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("subject", "varchar(140)", isNullable: true)]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("document_type", "varchar(140)", isNullable: true)]
        public string? DocumentType
        {
            get { return data.document_type; }
            set { data.document_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_standard", "int(1)", isNullable: false)]
        public bool IsStandard
        {
            get { return ERPNextConverter.IntToBool((int)data.is_standard); }
            set { data.is_standard = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("module", "varchar(140)", isNullable: true)]
        public string? Module
        {
            get { return data.module; }
            set { data.module = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("@event", "varchar(140)", isNullable: true)]
        public string? Event
        {
            get { return data.@event; }
            set { data.@event = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("method", "varchar(140)", isNullable: true)]
        public string? Method
        {
            get { return data.method; }
            set { data.method = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("date_changed", "varchar(140)", isNullable: true)]
        public string? DateChanged
        {
            get { return data.date_changed; }
            set { data.date_changed = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("days_in_advance", "int(11)", isNullable: false)]
        public int DaysInAdvance
        {
            get { return data.days_in_advance; }
            set { data.days_in_advance = value; }
        }

        [ColumnInfo("value_changed", "varchar(140)", isNullable: true)]
        public string? ValueChanged
        {
            get { return data.value_changed; }
            set { data.value_changed = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sender", "varchar(140)", isNullable: true)]
        public string? Sender
        {
            get { return data.sender; }
            set { data.sender = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("send_system_notification", "int(1)", isNullable: false)]
        public bool SendSystemNotification
        {
            get { return ERPNextConverter.IntToBool((int)data.send_system_notification); }
            set { data.send_system_notification = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("sender_email", "varchar(140)", isNullable: true)]
        public string? SenderEmail
        {
            get { return data.sender_email; }
            set { data.sender_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("condition", "longtext", isNullable: true)]
        public string? Condition
        {
            get { return data.condition; }
            set { data.condition = value; }
        }

        [ColumnInfo("set_property_after_alert", "varchar(140)", isNullable: true)]
        public string? SetPropertyAfterAlert
        {
            get { return data.set_property_after_alert; }
            set { data.set_property_after_alert = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("property_value", "varchar(140)", isNullable: true)]
        public string? PropertyValue
        {
            get { return data.property_value; }
            set { data.property_value = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("send_to_all_assignees", "int(1)", isNullable: false)]
        public bool SendToAllAssignees
        {
            get { return ERPNextConverter.IntToBool((int)data.send_to_all_assignees); }
            set { data.send_to_all_assignees = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("message", "longtext", isNullable: true)]
        public string? Message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        [ColumnInfo("attach_print", "int(1)", isNullable: false)]
        public bool AttachPrint
        {
            get { return ERPNextConverter.IntToBool((int)data.attach_print); }
            set { data.attach_print = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("print_format", "varchar(140)", isNullable: true)]
        public string? PrintFormat
        {
            get { return data.print_format; }
            set { data.print_format = ERPNextConverter.TruncateString(value, 140); }
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

