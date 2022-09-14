/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/13/2022 7:48:39 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.WebForm
{
    public partial class ERP_Website_WebForm : ERPNextObjectBase
    {
        public ERP_Website_WebForm() : this(new ERPObject(_DocType.Website_WebForm)) { }
        public ERP_Website_WebForm(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Website_WebForm>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Website_WebForm>(columnName);
        //}

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

        [ColumnInfo("title", "varchar(140)", isNullable: true)]
        public string? Title
        {
            get { return data.title; }
            set { data.title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("route", "varchar(140)", isNullable: true)]
        public string? Route
        {
            get { return data.route; }
            set { data.route = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("published", "int(1)", isNullable: false)]
        public bool Published
        {
            get { return ERPNextConverter.IntToBool((int)data.published); }
            set { data.published = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("doc_type", "varchar(140)", isNullable: true)]
        public string? DocType
        {
            get { return data.doc_type; }
            set { data.doc_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("module", "varchar(140)", isNullable: true)]
        public string? Module
        {
            get { return data.module; }
            set { data.module = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_standard", "int(1)", isNullable: false)]
        public bool IsStandard
        {
            get { return ERPNextConverter.IntToBool((int)data.is_standard); }
            set { data.is_standard = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("introduction_text", "longtext", isNullable: true)]
        public string? IntroductionText
        {
            get { return data.introduction_text; }
            set { data.introduction_text = value; }
        }

        [ColumnInfo("login_required", "int(1)", isNullable: false)]
        public bool LoginRequired
        {
            get { return ERPNextConverter.IntToBool((int)data.login_required); }
            set { data.login_required = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_multiple", "int(1)", isNullable: false)]
        public bool AllowMultiple
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_multiple); }
            set { data.allow_multiple = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_edit", "int(1)", isNullable: false)]
        public bool AllowEdit
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_edit); }
            set { data.allow_edit = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_delete", "int(1)", isNullable: false)]
        public bool AllowDelete
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_delete); }
            set { data.allow_delete = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("apply_document_permissions", "int(1)", isNullable: false)]
        public bool ApplyDocumentPermissions
        {
            get { return ERPNextConverter.IntToBool((int)data.apply_document_permissions); }
            set { data.apply_document_permissions = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_print", "int(1)", isNullable: false)]
        public bool AllowPrint
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_print); }
            set { data.allow_print = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("print_format", "varchar(140)", isNullable: true)]
        public string? PrintFormat
        {
            get { return data.print_format; }
            set { data.print_format = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("allow_comments", "int(1)", isNullable: false)]
        public bool AllowComments
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_comments); }
            set { data.allow_comments = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("show_attachments", "int(1)", isNullable: false)]
        public bool ShowAttachments
        {
            get { return ERPNextConverter.IntToBool((int)data.show_attachments); }
            set { data.show_attachments = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_incomplete", "int(1)", isNullable: false)]
        public bool AllowIncomplete
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_incomplete); }
            set { data.allow_incomplete = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("max_attachment_size", "int(11)", isNullable: false)]
        public int MaxAttachmentSize
        {
            get { return data.max_attachment_size; }
            set { data.max_attachment_size = value; }
        }

        [ColumnInfo("show_list", "int(1)", isNullable: false)]
        public bool ShowList
        {
            get { return ERPNextConverter.IntToBool((int)data.show_list); }
            set { data.show_list = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("list_title", "varchar(140)", isNullable: true)]
        public string? ListTitle
        {
            get { return data.list_title; }
            set { data.list_title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("show_sidebar", "int(1)", isNullable: false)]
        public bool ShowSidebar
        {
            get { return ERPNextConverter.IntToBool((int)data.show_sidebar); }
            set { data.show_sidebar = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("website_sidebar", "varchar(140)", isNullable: true)]
        public string? WebsiteSidebar
        {
            get { return data.website_sidebar; }
            set { data.website_sidebar = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("button_label", "varchar(140)", isNullable: true)]
        public string? ButtonLabel
        {
            get { return data.button_label; }
            set { data.button_label = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("banner_image", "text", isNullable: true)]
        public string? BannerImage
        {
            get { return data.banner_image; }
            set { data.banner_image = value; }
        }

        [ColumnInfo("breadcrumbs", "longtext", isNullable: true)]
        public string? Breadcrumbs
        {
            get { return data.breadcrumbs; }
            set { data.breadcrumbs = value; }
        }

        [ColumnInfo("success_title", "varchar(140)", isNullable: true)]
        public string? SuccessTitle
        {
            get { return data.success_title; }
            set { data.success_title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("success_url", "varchar(140)", isNullable: true)]
        public string? SuccessUrl
        {
            get { return data.success_url; }
            set { data.success_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("success_message", "text", isNullable: true)]
        public string? SuccessMessage
        {
            get { return data.success_message; }
            set { data.success_message = value; }
        }

        [ColumnInfo("client_script", "longtext", isNullable: true)]
        public string? ClientScript
        {
            get { return data.client_script; }
            set { data.client_script = value; }
        }

        [ColumnInfo("custom_css", "longtext", isNullable: true)]
        public string? CustomCss
        {
            get { return data.custom_css; }
            set { data.custom_css = value; }
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

        [ColumnInfo("accept_payment", "int(1)", isNullable: false)]
        public bool AcceptPayment
        {
            get { return ERPNextConverter.IntToBool((int)data.accept_payment); }
            set { data.accept_payment = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("payment_gateway", "varchar(140)", isNullable: true)]
        public string? PaymentGateway
        {
            get { return data.payment_gateway; }
            set { data.payment_gateway = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_button_label", "varchar(140)", isNullable: true)]
        public string? PaymentButtonLabel
        {
            get { return data.payment_button_label; }
            set { data.payment_button_label = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_button_help", "text", isNullable: true)]
        public string? PaymentButtonHelp
        {
            get { return data.payment_button_help; }
            set { data.payment_button_help = value; }
        }

        [ColumnInfo("amount_based_on_field", "int(1)", isNullable: false)]
        public bool AmountBasedOnField
        {
            get { return ERPNextConverter.IntToBool((int)data.amount_based_on_field); }
            set { data.amount_based_on_field = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("amount_field", "varchar(140)", isNullable: true)]
        public string? AmountField
        {
            get { return data.amount_field; }
            set { data.amount_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amount", "decimal(21,9)", isNullable: false)]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [ColumnInfo("currency", "varchar(140)", isNullable: true)]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = ERPNextConverter.TruncateString(value, 140); }
        }


    }
}

