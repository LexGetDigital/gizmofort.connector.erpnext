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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DocType
{
    public partial class ERP_Core_DocType : ERPNextObjectBase
    {
        public ERP_Core_DocType() : this(new ERPObject(_DocType.Core_DocType)) { }
        public ERP_Core_DocType(ERPObject obj) : base(obj) { }

        [ColumnInfo("name", "varchar(255)", isNullable: false)]
        public string Name
        {
            get { return data.name; }
            set { data.name = ERPNextConverter.TruncateString(value, 255); }
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

        [ColumnInfo("modified_by", "varchar(255)", isNullable: true)]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("owner", "varchar(255)", isNullable: true)]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = ERPNextConverter.TruncateString(value, 255); }
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

        [ColumnInfo("search_fields", "varchar(140)", isNullable: true)]
        public string? SearchFields
        {
            get { return data.search_fields; }
            set { data.search_fields = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("issingle", "int(1)", isNullable: false)]
        public bool Issingle
        {
            get { return ERPNextConverter.IntToBool((int)data.issingle); }
            set { data.issingle = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_tree", "int(1)", isNullable: false)]
        public bool IsTree
        {
            get { return ERPNextConverter.IntToBool((int)data.is_tree); }
            set { data.is_tree = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("istable", "int(1)", isNullable: false)]
        public bool Istable
        {
            get { return ERPNextConverter.IntToBool((int)data.istable); }
            set { data.istable = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("editable_grid", "int(1)", isNullable: false)]
        public bool EditableGrid
        {
            get { return ERPNextConverter.IntToBool((int)data.editable_grid); }
            set { data.editable_grid = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("track_changes", "int(1)", isNullable: false)]
        public bool TrackChanges
        {
            get { return ERPNextConverter.IntToBool((int)data.track_changes); }
            set { data.track_changes = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("module", "varchar(140)", isNullable: true)]
        public string? Module
        {
            get { return data.module; }
            set { data.module = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("restrict_to_domain", "varchar(140)", isNullable: true)]
        public string? RestrictToDomain
        {
            get { return data.restrict_to_domain; }
            set { data.restrict_to_domain = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("app", "varchar(255)", isNullable: true)]
        public string? App
        {
            get { return data.app; }
            set { data.app = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("autoname", "varchar(140)", isNullable: true)]
        public string? Autoname
        {
            get { return data.autoname; }
            set { data.autoname = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("naming_rule", "varchar(40)", isNullable: true)]
        public string? NamingRule
        {
            get { return data.naming_rule; }
            set { data.naming_rule = ERPNextConverter.TruncateString(value, 40); }
        }

        [ColumnInfo("name_case", "varchar(140)", isNullable: true)]
        public string? NameCase
        {
            get { return data.name_case; }
            set { data.name_case = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("title_field", "varchar(140)", isNullable: true)]
        public string? TitleField
        {
            get { return data.title_field; }
            set { data.title_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("image_field", "varchar(140)", isNullable: true)]
        public string? ImageField
        {
            get { return data.image_field; }
            set { data.image_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("timeline_field", "varchar(140)", isNullable: true)]
        public string? TimelineField
        {
            get { return data.timeline_field; }
            set { data.timeline_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sort_field", "varchar(140)", isNullable: true)]
        public string? SortField
        {
            get { return data.sort_field; }
            set { data.sort_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sort_order", "varchar(140)", isNullable: true)]
        public string? SortOrder
        {
            get { return data.sort_order; }
            set { data.sort_order = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "text", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("colour", "varchar(255)", isNullable: true)]
        public string? Colour
        {
            get { return data.colour; }
            set { data.colour = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("read_only", "int(1)", isNullable: false)]
        public bool ReadOnly
        {
            get { return ERPNextConverter.IntToBool((int)data.read_only); }
            set { data.read_only = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("in_create", "int(1)", isNullable: false)]
        public bool InCreate
        {
            get { return ERPNextConverter.IntToBool((int)data.in_create); }
            set { data.in_create = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("menu_index", "int(11)", isNullable: true)]
        public int? MenuIndex
        {
            get { return data.menu_index; }
            set { data.menu_index = value; }
        }

        [ColumnInfo("parent_node", "varchar(255)", isNullable: true)]
        public string? ParentNode
        {
            get { return data.parent_node; }
            set { data.parent_node = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("smallicon", "varchar(255)", isNullable: true)]
        public string? Smallicon
        {
            get { return data.smallicon; }
            set { data.smallicon = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("allow_copy", "int(1)", isNullable: false)]
        public bool AllowCopy
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_copy); }
            set { data.allow_copy = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_rename", "int(1)", isNullable: false)]
        public bool AllowRename
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_rename); }
            set { data.allow_rename = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_import", "int(1)", isNullable: false)]
        public bool AllowImport
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_import); }
            set { data.allow_import = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("hide_toolbar", "int(1)", isNullable: false)]
        public bool HideToolbar
        {
            get { return ERPNextConverter.IntToBool((int)data.hide_toolbar); }
            set { data.hide_toolbar = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("track_seen", "int(1)", isNullable: false)]
        public bool TrackSeen
        {
            get { return ERPNextConverter.IntToBool((int)data.track_seen); }
            set { data.track_seen = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("max_attachments", "int(11)", isNullable: false)]
        public int MaxAttachments
        {
            get { return data.max_attachments; }
            set { data.max_attachments = value; }
        }

        [ColumnInfo("print_outline", "varchar(255)", isNullable: true)]
        public string? PrintOutline
        {
            get { return data.print_outline; }
            set { data.print_outline = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("document_type", "varchar(140)", isNullable: true)]
        public string? DocumentType
        {
            get { return data.document_type; }
            set { data.document_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("icon", "varchar(140)", isNullable: true)]
        public string? Icon
        {
            get { return data.icon; }
            set { data.icon = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("color", "varchar(140)", isNullable: true)]
        public string? Color
        {
            get { return data.color; }
            set { data.color = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("tag_fields", "varchar(255)", isNullable: true)]
        public string? TagFields
        {
            get { return data.tag_fields; }
            set { data.tag_fields = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("subject", "varchar(255)", isNullable: true)]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("_last_update", "varchar(32)", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LastUpdate
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._last_update; }
            set { data._last_update = ERPNextConverter.TruncateString(value, 32); }
        }

        [ColumnInfo("engine", "varchar(140)", isNullable: true)]
        public string? Engine
        {
            get { return data.engine; }
            set { data.engine = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("default_print_format", "varchar(140)", isNullable: true)]
        public string? DefaultPrintFormat
        {
            get { return data.default_print_format; }
            set { data.default_print_format = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_submittable", "int(1)", isNullable: false)]
        public bool IsSubmittable
        {
            get { return ERPNextConverter.IntToBool((int)data.is_submittable); }
            set { data.is_submittable = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("show_name_in_global_search", "int(1)", isNullable: false)]
        public bool ShowNameInGlobalSearch
        {
            get { return ERPNextConverter.IntToBool((int)data.show_name_in_global_search); }
            set { data.show_name_in_global_search = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("_user_tags", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [ColumnInfo("custom", "int(1)", isNullable: false)]
        public bool Custom
        {
            get { return ERPNextConverter.IntToBool((int)data.custom); }
            set { data.custom = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("beta", "int(1)", isNullable: false)]
        public bool Beta
        {
            get { return ERPNextConverter.IntToBool((int)data.beta); }
            set { data.beta = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("has_web_view", "int(1)", isNullable: false)]
        public bool HasWebView
        {
            get { return ERPNextConverter.IntToBool((int)data.has_web_view); }
            set { data.has_web_view = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_guest_to_view", "int(1)", isNullable: false)]
        public bool AllowGuestToView
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_guest_to_view); }
            set { data.allow_guest_to_view = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("route", "varchar(140)", isNullable: true)]
        public string? Route
        {
            get { return data.route; }
            set { data.route = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_published_field", "varchar(140)", isNullable: true)]
        public string? IsPublishedField
        {
            get { return data.is_published_field; }
            set { data.is_published_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("website_search_field", "varchar(140)", isNullable: true)]
        public string? WebsiteSearchField
        {
            get { return data.website_search_field; }
            set { data.website_search_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("email_append_to", "int(1)", isNullable: false)]
        public bool EmailAppendTo
        {
            get { return ERPNextConverter.IntToBool((int)data.email_append_to); }
            set { data.email_append_to = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("subject_field", "varchar(140)", isNullable: true)]
        public string? SubjectField
        {
            get { return data.subject_field; }
            set { data.subject_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sender_field", "varchar(140)", isNullable: true)]
        public string? SenderField
        {
            get { return data.sender_field; }
            set { data.sender_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("show_title_field_in_link", "int(1)", isNullable: false)]
        public bool ShowTitleFieldInLink
        {
            get { return ERPNextConverter.IntToBool((int)data.show_title_field_in_link); }
            set { data.show_title_field_in_link = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("migration_hash", "varchar(140)", isNullable: true)]
        public string? MigrationHash
        {
            get { return data.migration_hash; }
            set { data.migration_hash = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("translated_doctype", "int(1)", isNullable: false)]
        public bool TranslatedDoctype
        {
            get { return ERPNextConverter.IntToBool((int)data.translated_doctype); }
            set { data.translated_doctype = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("quick_entry", "int(1)", isNullable: false)]
        public bool QuickEntry
        {
            get { return ERPNextConverter.IntToBool((int)data.quick_entry); }
            set { data.quick_entry = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("track_views", "int(1)", isNullable: false)]
        public bool TrackViews
        {
            get { return ERPNextConverter.IntToBool((int)data.track_views); }
            set { data.track_views = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_virtual", "int(1)", isNullable: false)]
        public bool IsVirtual
        {
            get { return ERPNextConverter.IntToBool((int)data.is_virtual); }
            set { data.is_virtual = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("documentation", "varchar(140)", isNullable: true)]
        public string? Documentation
        {
            get { return data.documentation; }
            set { data.documentation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("nsm_parent_field", "varchar(140)", isNullable: true)]
        public string? NsmParentField
        {
            get { return data.nsm_parent_field; }
            set { data.nsm_parent_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("allow_events_in_timeline", "int(1)", isNullable: false)]
        public bool AllowEventsInTimeline
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_events_in_timeline); }
            set { data.allow_events_in_timeline = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_auto_repeat", "int(1)", isNullable: false)]
        public bool AllowAutoRepeat
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_auto_repeat); }
            set { data.allow_auto_repeat = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("make_attachments_public", "int(1)", isNullable: false)]
        public bool MakeAttachmentsPublic
        {
            get { return ERPNextConverter.IntToBool((int)data.make_attachments_public); }
            set { data.make_attachments_public = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("show_preview_popup", "int(1)", isNullable: false)]
        public bool ShowPreviewPopup
        {
            get { return ERPNextConverter.IntToBool((int)data.show_preview_popup); }
            set { data.show_preview_popup = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("default_email_template", "varchar(140)", isNullable: true)]
        public string? DefaultEmailTemplate
        {
            get { return data.default_email_template; }
            set { data.default_email_template = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("index_web_pages_for_search", "int(1)", isNullable: false)]
        public bool IndexWebPagesForSearch
        {
            get { return ERPNextConverter.IntToBool((int)data.index_web_pages_for_search); }
            set { data.index_web_pages_for_search = ERPNextConverter.BoolToInt(value); }
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

