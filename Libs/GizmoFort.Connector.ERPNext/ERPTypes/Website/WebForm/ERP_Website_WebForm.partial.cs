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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.WebForm
{
    public partial class ERP_Website_WebForm : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Website_WebForm() : this(new ERPObject(_DockType.Website_WebForm)) { }
        public ERP_Website_WebForm(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Website_WebForm>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Website_WebForm>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Website_WebForm>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Website_WebForm? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Website_WebForm>(json: json);
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

        [Column("title")]
        public string? Title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        [Column("route")]
        public string? Route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        [Column("published")]
        public int Published
        {
            get { return data.published; }
            set { data.published = value; }
        }

        [Column("doc_type")]
        public string? DocType
        {
            get { return data.doc_type; }
            set { data.doc_type = value; }
        }

        [Column("module")]
        public string? Module
        {
            get { return data.module; }
            set { data.module = value; }
        }

        [Column("is_standard")]
        public int IsStandard
        {
            get { return data.is_standard; }
            set { data.is_standard = value; }
        }

        [Column("introduction_text")]
        public string? IntroductionText
        {
            get { return data.introduction_text; }
            set { data.introduction_text = value; }
        }

        [Column("login_required")]
        public int LoginRequired
        {
            get { return data.login_required; }
            set { data.login_required = value; }
        }

        [Column("allow_multiple")]
        public int AllowMultiple
        {
            get { return data.allow_multiple; }
            set { data.allow_multiple = value; }
        }

        [Column("allow_edit")]
        public int AllowEdit
        {
            get { return data.allow_edit; }
            set { data.allow_edit = value; }
        }

        [Column("allow_delete")]
        public int AllowDelete
        {
            get { return data.allow_delete; }
            set { data.allow_delete = value; }
        }

        [Column("apply_document_permissions")]
        public int ApplyDocumentPermissions
        {
            get { return data.apply_document_permissions; }
            set { data.apply_document_permissions = value; }
        }

        [Column("allow_print")]
        public int AllowPrint
        {
            get { return data.allow_print; }
            set { data.allow_print = value; }
        }

        [Column("print_format")]
        public string? PrintFormat
        {
            get { return data.print_format; }
            set { data.print_format = value; }
        }

        [Column("allow_comments")]
        public int AllowComments
        {
            get { return data.allow_comments; }
            set { data.allow_comments = value; }
        }

        [Column("show_attachments")]
        public int ShowAttachments
        {
            get { return data.show_attachments; }
            set { data.show_attachments = value; }
        }

        [Column("allow_incomplete")]
        public int AllowIncomplete
        {
            get { return data.allow_incomplete; }
            set { data.allow_incomplete = value; }
        }

        [Column("max_attachment_size")]
        public int MaxAttachmentSize
        {
            get { return data.max_attachment_size; }
            set { data.max_attachment_size = value; }
        }

        [Column("show_list")]
        public int ShowList
        {
            get { return data.show_list; }
            set { data.show_list = value; }
        }

        [Column("list_title")]
        public string? ListTitle
        {
            get { return data.list_title; }
            set { data.list_title = value; }
        }

        [Column("show_sidebar")]
        public int ShowSidebar
        {
            get { return data.show_sidebar; }
            set { data.show_sidebar = value; }
        }

        [Column("website_sidebar")]
        public string? WebsiteSidebar
        {
            get { return data.website_sidebar; }
            set { data.website_sidebar = value; }
        }

        [Column("button_label")]
        public string? ButtonLabel
        {
            get { return data.button_label; }
            set { data.button_label = value; }
        }

        [Column("banner_image")]
        public string? BannerImage
        {
            get { return data.banner_image; }
            set { data.banner_image = value; }
        }

        [Column("breadcrumbs")]
        public string? Breadcrumbs
        {
            get { return data.breadcrumbs; }
            set { data.breadcrumbs = value; }
        }

        [Column("success_title")]
        public string? SuccessTitle
        {
            get { return data.success_title; }
            set { data.success_title = value; }
        }

        [Column("success_url")]
        public string? SuccessUrl
        {
            get { return data.success_url; }
            set { data.success_url = value; }
        }

        [Column("success_message")]
        public string? SuccessMessage
        {
            get { return data.success_message; }
            set { data.success_message = value; }
        }

        [Column("client_script")]
        public string? ClientScript
        {
            get { return data.client_script; }
            set { data.client_script = value; }
        }

        [Column("custom_css")]
        public string? CustomCss
        {
            get { return data.custom_css; }
            set { data.custom_css = value; }
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

        [Column("accept_payment")]
        public int AcceptPayment
        {
            get { return data.accept_payment; }
            set { data.accept_payment = value; }
        }

        [Column("payment_gateway")]
        public string? PaymentGateway
        {
            get { return data.payment_gateway; }
            set { data.payment_gateway = value; }
        }

        [Column("payment_button_label")]
        public string? PaymentButtonLabel
        {
            get { return data.payment_button_label; }
            set { data.payment_button_label = value; }
        }

        [Column("payment_button_help")]
        public string? PaymentButtonHelp
        {
            get { return data.payment_button_help; }
            set { data.payment_button_help = value; }
        }

        [Column("amount_based_on_field")]
        public int AmountBasedOnField
        {
            get { return data.amount_based_on_field; }
            set { data.amount_based_on_field = value; }
        }

        [Column("amount_field")]
        public string? AmountField
        {
            get { return data.amount_field; }
            set { data.amount_field = value; }
        }

        [Column("amount")]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }


    }
}

