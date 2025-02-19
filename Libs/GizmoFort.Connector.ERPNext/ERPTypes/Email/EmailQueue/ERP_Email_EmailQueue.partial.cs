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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Email.EmailQueue
{
    public partial class ERP_Email_EmailQueue : ERPNextObjectBase
    {
        public ERP_Email_EmailQueue() : this(new ERPObject(_DocType.Email_EmailQueue)) { }
        public ERP_Email_EmailQueue(ERPObject obj) : base(obj) { }

        [ColumnInfo("name", "bigint(20)", isNullable: false)]
        public long Name
        {
            get { return data.name; }
            set { data.name = value; }
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

        [ColumnInfo("sender", "varchar(140)", isNullable: true)]
        public string? Sender
        {
            get { return data.sender; }
            set { data.sender = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("show_as_cc", "text", isNullable: true)]
        public string? ShowAsCc
        {
            get { return data.show_as_cc; }
            set { data.show_as_cc = value; }
        }

        [ColumnInfo("message", "longtext", isNullable: true)]
        public string? Message
        {
            get { return data.message; }
            set { data.message = value; }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("error", "longtext", isNullable: true)]
        public string? Error
        {
            get { return data.error; }
            set { data.error = value; }
        }

        [ColumnInfo("message_id", "varchar(140)", isNullable: true)]
        public string? MessageId
        {
            get { return data.message_id; }
            set { data.message_id = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("communication", "varchar(140)", isNullable: true)]
        public string? Communication
        {
            get { return data.communication; }
            set { data.communication = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("send_after", "datetime(6)", isNullable: true)]
        public DateTimeOffset? SendAfter
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.send_after); }
            set { data.send_after = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("priority", "int(11)", isNullable: false)]
        public int Priority
        {
            get { return data.priority; }
            set { data.priority = value; }
        }

        [ColumnInfo("add_unsubscribe_link", "int(1)", isNullable: false)]
        public bool AddUnsubscribeLink
        {
            get { return ERPNextConverter.IntToBool((int)data.add_unsubscribe_link); }
            set { data.add_unsubscribe_link = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("unsubscribe_param", "varchar(140)", isNullable: true)]
        public string? UnsubscribeParam
        {
            get { return data.unsubscribe_param; }
            set { data.unsubscribe_param = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("unsubscribe_method", "varchar(140)", isNullable: true)]
        public string? UnsubscribeMethod
        {
            get { return data.unsubscribe_method; }
            set { data.unsubscribe_method = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("expose_recipients", "varchar(140)", isNullable: true)]
        public string? ExposeRecipients
        {
            get { return data.expose_recipients; }
            set { data.expose_recipients = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("attachments", "longtext", isNullable: true)]
        public string? Attachments
        {
            get { return data.attachments; }
            set { data.attachments = value; }
        }

        [ColumnInfo("retry", "int(11)", isNullable: false)]
        public int Retry
        {
            get { return data.retry; }
            set { data.retry = value; }
        }

        [ColumnInfo("email_account", "varchar(140)", isNullable: true)]
        public string? EmailAccount
        {
            get { return data.email_account; }
            set { data.email_account = ERPNextConverter.TruncateString(value, 140); }
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

