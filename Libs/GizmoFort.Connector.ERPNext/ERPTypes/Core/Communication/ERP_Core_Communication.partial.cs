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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.Communication
{
    public partial class ERP_Core_Communication : ERPNextObjectBase
    {
        public ERP_Core_Communication() : this(new ERPObject(_DockType.Core_Communication)) { }
        public ERP_Core_Communication(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Core_Communication>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Core_Communication>(columnName);
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

        [Column("subject")]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        [Column("communication_medium")]
        public string? CommunicationMedium
        {
            get { return data.communication_medium; }
            set { data.communication_medium = value; }
        }

        [Column("sender")]
        public string? Sender
        {
            get { return data.sender; }
            set { data.sender = value; }
        }

        [Column("recipients")]
        public string? Recipients
        {
            get { return data.recipients; }
            set { data.recipients = value; }
        }

        [Column("cc")]
        public string? Cc
        {
            get { return data.cc; }
            set { data.cc = value; }
        }

        [Column("bcc")]
        public string? Bcc
        {
            get { return data.bcc; }
            set { data.bcc = value; }
        }

        [Column("phone_no")]
        public string? PhoneNo
        {
            get { return data.phone_no; }
            set { data.phone_no = value; }
        }

        [Column("delivery_status")]
        public string? DeliveryStatus
        {
            get { return data.delivery_status; }
            set { data.delivery_status = value; }
        }

        [Column("content")]
        public string? Content
        {
            get { return data.content; }
            set { data.content = value; }
        }

        [Column("text_content")]
        public string? TextContent
        {
            get { return data.text_content; }
            set { data.text_content = value; }
        }

        [Column("communication_type")]
        public string? CommunicationType
        {
            get { return data.communication_type; }
            set { data.communication_type = value; }
        }

        [Column("comment_type")]
        public string? CommentType
        {
            get { return data.comment_type; }
            set { data.comment_type = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("sent_or_received")]
        public string? SentOrReceived
        {
            get { return data.sent_or_received; }
            set { data.sent_or_received = value; }
        }

        [Column("communication_date")]
        public DateTimeOffset? CommunicationDate
        {
            get { return data.communication_date; }
            set { data.communication_date = value; }
        }

        [Column("read_receipt")]
        public int ReadReceipt
        {
            get { return data.read_receipt; }
            set { data.read_receipt = value; }
        }

        [Column("sender_full_name")]
        public string? SenderFullName
        {
            get { return data.sender_full_name; }
            set { data.sender_full_name = value; }
        }

        [Column("read_by_recipient")]
        public int ReadByRecipient
        {
            get { return data.read_by_recipient; }
            set { data.read_by_recipient = value; }
        }

        [Column("read_by_recipient_on")]
        public DateTimeOffset? ReadByRecipientOn
        {
            get { return data.read_by_recipient_on; }
            set { data.read_by_recipient_on = value; }
        }

        [Column("reference_doctype")]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        [Column("reference_name")]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        [Column("reference_owner")]
        public string? ReferenceOwner
        {
            get { return data.reference_owner; }
            set { data.reference_owner = value; }
        }

        [Column("email_account")]
        public string? EmailAccount
        {
            get { return data.email_account; }
            set { data.email_account = value; }
        }

        [Column("in_reply_to")]
        public string? InReplyTo
        {
            get { return data.in_reply_to; }
            set { data.in_reply_to = value; }
        }

        [Column("user")]
        public string? User
        {
            get { return data.user; }
            set { data.user = value; }
        }

        [Column("email_template")]
        public string? EmailTemplate
        {
            get { return data.email_template; }
            set { data.email_template = value; }
        }

        [Column("unread_notification_sent")]
        public int UnreadNotificationSent
        {
            get { return data.unread_notification_sent; }
            set { data.unread_notification_sent = value; }
        }

        [Column("seen")]
        public int Seen
        {
            get { return data.seen; }
            set { data.seen = value; }
        }

        [Column("_user_tags")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [Column("message_id")]
        public string? MessageId
        {
            get { return data.message_id; }
            set { data.message_id = value; }
        }

        [Column("uid")]
        public int Uid
        {
            get { return data.uid; }
            set { data.uid = value; }
        }

        [Column("imap_folder")]
        public string? ImapFolder
        {
            get { return data.imap_folder; }
            set { data.imap_folder = value; }
        }

        [Column("email_status")]
        public string? EmailStatus
        {
            get { return data.email_status; }
            set { data.email_status = value; }
        }

        [Column("has_attachment")]
        public int HasAttachment
        {
            get { return data.has_attachment; }
            set { data.has_attachment = value; }
        }

        [Column("rating")]
        public int Rating
        {
            get { return data.rating; }
            set { data.rating = value; }
        }

        [Column("feedback_request")]
        public string? FeedbackRequest
        {
            get { return data.feedback_request; }
            set { data.feedback_request = value; }
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

