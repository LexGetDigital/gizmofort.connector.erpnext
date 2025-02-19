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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DataImport
{
    public partial class ERP_Core_DataImport : ERPNextObjectBase
    {
        public ERP_Core_DataImport() : this(new ERPObject(_DocType.Core_DataImport)) { }
        public ERP_Core_DataImport(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("reference_doctype", "varchar(140)", isNullable: true)]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("import_type", "varchar(140)", isNullable: true)]
        public string? ImportType
        {
            get { return data.import_type; }
            set { data.import_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("import_file", "text", isNullable: true)]
        public string? ImportFile
        {
            get { return data.import_file; }
            set { data.import_file = value; }
        }

        [ColumnInfo("payload_count", "int(11)", isNullable: false)]
        public int PayloadCount
        {
            get { return data.payload_count; }
            set { data.payload_count = value; }
        }

        [ColumnInfo("google_sheets_url", "varchar(140)", isNullable: true)]
        public string? GoogleSheetsUrl
        {
            get { return data.google_sheets_url; }
            set { data.google_sheets_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("submit_after_import", "int(1)", isNullable: false)]
        public bool SubmitAfterImport
        {
            get { return ERPNextConverter.IntToBool((int)data.submit_after_import); }
            set { data.submit_after_import = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("mute_emails", "int(1)", isNullable: false)]
        public bool MuteEmails
        {
            get { return ERPNextConverter.IntToBool((int)data.mute_emails); }
            set { data.mute_emails = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("template_options", "longtext", isNullable: true)]
        public string? TemplateOptions
        {
            get { return data.template_options; }
            set { data.template_options = value; }
        }

        [ColumnInfo("template_warnings", "longtext", isNullable: true)]
        public string? TemplateWarnings
        {
            get { return data.template_warnings; }
            set { data.template_warnings = value; }
        }

        [ColumnInfo("show_failed_logs", "int(1)", isNullable: false)]
        public bool ShowFailedLogs
        {
            get { return ERPNextConverter.IntToBool((int)data.show_failed_logs); }
            set { data.show_failed_logs = ERPNextConverter.BoolToInt(value); }
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

