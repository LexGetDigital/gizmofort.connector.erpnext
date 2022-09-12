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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Email.EmailAccount
{
    public partial class ERP_Email_EmailAccount : ERPNextObjectBase
    {
        public ERP_Email_EmailAccount() : this(new ERPObject(_DockType.Email_EmailAccount)) { }
        public ERP_Email_EmailAccount(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Email_EmailAccount>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Email_EmailAccount>(columnName);
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

        [Column("email_id")]
        public string? EmailId
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        [Column("email_account_name")]
        public string? EmailAccountName
        {
            get { return data.email_account_name; }
            set { data.email_account_name = value; }
        }

        [Column("domain")]
        public string? Domain
        {
            get { return data.domain; }
            set { data.domain = value; }
        }

        [Column("service")]
        public string? Service
        {
            get { return data.service; }
            set { data.service = value; }
        }

        [Column("auth_method")]
        public string? AuthMethod
        {
            get { return data.auth_method; }
            set { data.auth_method = value; }
        }

        [Column("password")]
        public string? Password
        {
            get { return data.password; }
            set { data.password = value; }
        }

        [Column("awaiting_password")]
        public int AwaitingPassword
        {
            get { return data.awaiting_password; }
            set { data.awaiting_password = value; }
        }

        [Column("ascii_encode_password")]
        public int AsciiEncodePassword
        {
            get { return data.ascii_encode_password; }
            set { data.ascii_encode_password = value; }
        }

        [Column("refresh_token")]
        public string? RefreshToken
        {
            get { return data.refresh_token; }
            set { data.refresh_token = value; }
        }

        [Column("access_token")]
        public string? AccessToken
        {
            get { return data.access_token; }
            set { data.access_token = value; }
        }

        [Column("login_id_is_different")]
        public int LoginIdIsDifferent
        {
            get { return data.login_id_is_different; }
            set { data.login_id_is_different = value; }
        }

        [Column("login_id")]
        public string? LoginId
        {
            get { return data.login_id; }
            set { data.login_id = value; }
        }

        [Column("enable_incoming")]
        public int EnableIncoming
        {
            get { return data.enable_incoming; }
            set { data.enable_incoming = value; }
        }

        [Column("default_incoming")]
        public int DefaultIncoming
        {
            get { return data.default_incoming; }
            set { data.default_incoming = value; }
        }

        [Column("use_imap")]
        public int UseImap
        {
            get { return data.use_imap; }
            set { data.use_imap = value; }
        }

        [Column("use_ssl")]
        public int UseSsl
        {
            get { return data.use_ssl; }
            set { data.use_ssl = value; }
        }

        [Column("use_starttls")]
        public int UseStarttls
        {
            get { return data.use_starttls; }
            set { data.use_starttls = value; }
        }

        [Column("email_server")]
        public string? EmailServer
        {
            get { return data.email_server; }
            set { data.email_server = value; }
        }

        [Column("incoming_port")]
        public string? IncomingPort
        {
            get { return data.incoming_port; }
            set { data.incoming_port = value; }
        }

        [Column("attachment_limit")]
        public int AttachmentLimit
        {
            get { return data.attachment_limit; }
            set { data.attachment_limit = value; }
        }

        [Column("email_sync_option")]
        public string? EmailSyncOption
        {
            get { return data.email_sync_option; }
            set { data.email_sync_option = value; }
        }

        [Column("initial_sync_count")]
        public string? InitialSyncCount
        {
            get { return data.initial_sync_count; }
            set { data.initial_sync_count = value; }
        }

        [Column("append_emails_to_sent_folder")]
        public int AppendEmailsToSentFolder
        {
            get { return data.append_emails_to_sent_folder; }
            set { data.append_emails_to_sent_folder = value; }
        }

        [Column("append_to")]
        public string? AppendTo
        {
            get { return data.append_to; }
            set { data.append_to = value; }
        }

        [Column("create_contact")]
        public int CreateContact
        {
            get { return data.create_contact; }
            set { data.create_contact = value; }
        }

        [Column("enable_automatic_linking")]
        public int EnableAutomaticLinking
        {
            get { return data.enable_automatic_linking; }
            set { data.enable_automatic_linking = value; }
        }

        [Column("notify_if_unreplied")]
        public int NotifyIfUnreplied
        {
            get { return data.notify_if_unreplied; }
            set { data.notify_if_unreplied = value; }
        }

        [Column("unreplied_for_mins")]
        public int UnrepliedForMins
        {
            get { return data.unreplied_for_mins; }
            set { data.unreplied_for_mins = value; }
        }

        [Column("send_notification_to")]
        public string? SendNotificationTo
        {
            get { return data.send_notification_to; }
            set { data.send_notification_to = value; }
        }

        [Column("enable_outgoing")]
        public int EnableOutgoing
        {
            get { return data.enable_outgoing; }
            set { data.enable_outgoing = value; }
        }

        [Column("use_tls")]
        public int UseTls
        {
            get { return data.use_tls; }
            set { data.use_tls = value; }
        }

        [Column("use_ssl_for_outgoing")]
        public int UseSslForOutgoing
        {
            get { return data.use_ssl_for_outgoing; }
            set { data.use_ssl_for_outgoing = value; }
        }

        [Column("smtp_server")]
        public string? SmtpServer
        {
            get { return data.smtp_server; }
            set { data.smtp_server = value; }
        }

        [Column("smtp_port")]
        public string? SmtpPort
        {
            get { return data.smtp_port; }
            set { data.smtp_port = value; }
        }

        [Column("default_outgoing")]
        public int DefaultOutgoing
        {
            get { return data.default_outgoing; }
            set { data.default_outgoing = value; }
        }

        [Column("always_use_account_email_id_as_sender")]
        public int AlwaysUseAccountEmailIdAsSender
        {
            get { return data.always_use_account_email_id_as_sender; }
            set { data.always_use_account_email_id_as_sender = value; }
        }

        [Column("always_use_account_name_as_sender_name")]
        public int AlwaysUseAccountNameAsSenderName
        {
            get { return data.always_use_account_name_as_sender_name; }
            set { data.always_use_account_name_as_sender_name = value; }
        }

        [Column("send_unsubscribe_message")]
        public int SendUnsubscribeMessage
        {
            get { return data.send_unsubscribe_message; }
            set { data.send_unsubscribe_message = value; }
        }

        [Column("track_email_status")]
        public int TrackEmailStatus
        {
            get { return data.track_email_status; }
            set { data.track_email_status = value; }
        }

        [Column("no_smtp_authentication")]
        public int NoSmtpAuthentication
        {
            get { return data.no_smtp_authentication; }
            set { data.no_smtp_authentication = value; }
        }

        [Column("add_signature")]
        public int AddSignature
        {
            get { return data.add_signature; }
            set { data.add_signature = value; }
        }

        [Column("signature")]
        public string? Signature
        {
            get { return data.signature; }
            set { data.signature = value; }
        }

        [Column("enable_auto_reply")]
        public int EnableAutoReply
        {
            get { return data.enable_auto_reply; }
            set { data.enable_auto_reply = value; }
        }

        [Column("auto_reply_message")]
        public string? AutoReplyMessage
        {
            get { return data.auto_reply_message; }
            set { data.auto_reply_message = value; }
        }

        [Column("footer")]
        public string? Footer
        {
            get { return data.footer; }
            set { data.footer = value; }
        }

        [Column("brand_logo")]
        public string? BrandLogo
        {
            get { return data.brand_logo; }
            set { data.brand_logo = value; }
        }

        [Column("uidvalidity")]
        public string? Uidvalidity
        {
            get { return data.uidvalidity; }
            set { data.uidvalidity = value; }
        }

        [Column("uidnext")]
        public int Uidnext
        {
            get { return data.uidnext; }
            set { data.uidnext = value; }
        }

        [Column("no_failed")]
        public int NoFailed
        {
            get { return data.no_failed; }
            set { data.no_failed = value; }
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

