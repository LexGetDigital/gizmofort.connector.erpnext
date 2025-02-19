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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.OnboardingStep
{
    public partial class ERP_Desk_OnboardingStep : ERPNextObjectBase
    {
        public ERP_Desk_OnboardingStep() : this(new ERPObject(_DocType.Desk_OnboardingStep)) { }
        public ERP_Desk_OnboardingStep(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("is_complete", "int(1)", isNullable: false)]
        public bool IsComplete
        {
            get { return ERPNextConverter.IntToBool((int)data.is_complete); }
            set { data.is_complete = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_skipped", "int(1)", isNullable: false)]
        public bool IsSkipped
        {
            get { return ERPNextConverter.IntToBool((int)data.is_skipped); }
            set { data.is_skipped = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("intro_video_url", "varchar(140)", isNullable: true)]
        public string? IntroVideoUrl
        {
            get { return data.intro_video_url; }
            set { data.intro_video_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("action", "varchar(140)", isNullable: true)]
        public string? Action
        {
            get { return data.action; }
            set { data.action = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("action_label", "varchar(140)", isNullable: true)]
        public string? ActionLabel
        {
            get { return data.action_label; }
            set { data.action_label = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_document", "varchar(140)", isNullable: true)]
        public string? ReferenceDocument
        {
            get { return data.reference_document; }
            set { data.reference_document = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("show_full_form", "int(1)", isNullable: false)]
        public bool ShowFullForm
        {
            get { return ERPNextConverter.IntToBool((int)data.show_full_form); }
            set { data.show_full_form = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("show_form_tour", "int(1)", isNullable: false)]
        public bool ShowFormTour
        {
            get { return ERPNextConverter.IntToBool((int)data.show_form_tour); }
            set { data.show_form_tour = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("form_tour", "varchar(140)", isNullable: true)]
        public string? FormTour
        {
            get { return data.form_tour; }
            set { data.form_tour = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_single", "int(1)", isNullable: false)]
        public bool IsSingle
        {
            get { return ERPNextConverter.IntToBool((int)data.is_single); }
            set { data.is_single = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("reference_report", "varchar(140)", isNullable: true)]
        public string? ReferenceReport
        {
            get { return data.reference_report; }
            set { data.reference_report = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("report_reference_doctype", "varchar(140)", isNullable: true)]
        public string? ReportReferenceDoctype
        {
            get { return data.report_reference_doctype; }
            set { data.report_reference_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("report_type", "varchar(140)", isNullable: true)]
        public string? ReportType
        {
            get { return data.report_type; }
            set { data.report_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("report_description", "varchar(140)", isNullable: true)]
        public string? ReportDescription
        {
            get { return data.report_description; }
            set { data.report_description = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("path", "varchar(140)", isNullable: true)]
        public string? Path
        {
            get { return data.path; }
            set { data.path = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("callback_title", "varchar(140)", isNullable: true)]
        public string? CallbackTitle
        {
            get { return data.callback_title; }
            set { data.callback_title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("callback_message", "text", isNullable: true)]
        public string? CallbackMessage
        {
            get { return data.callback_message; }
            set { data.callback_message = value; }
        }

        [ColumnInfo("validate_action", "int(1)", isNullable: false)]
        public bool ValidateAction
        {
            get { return ERPNextConverter.IntToBool((int)data.validate_action); }
            set { data.validate_action = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("field", "varchar(140)", isNullable: true)]
        public string? Field
        {
            get { return data.field; }
            set { data.field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("value_to_validate", "varchar(140)", isNullable: true)]
        public string? ValueToValidate
        {
            get { return data.value_to_validate; }
            set { data.value_to_validate = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("video_url", "varchar(140)", isNullable: true)]
        public string? VideoUrl
        {
            get { return data.video_url; }
            set { data.video_url = ERPNextConverter.TruncateString(value, 140); }
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

