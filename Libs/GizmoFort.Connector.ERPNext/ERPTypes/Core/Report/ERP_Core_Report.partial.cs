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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.Report
{
    public partial class ERP_Core_Report : ERPNextObjectBase
    {
        public ERP_Core_Report() : this(new ERPObject(_DockType.Core_Report)) { }
        public ERP_Core_Report(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Core_Report>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Core_Report>(columnName);
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

        [Column("report_name")]
        public string? ReportName
        {
            get { return data.report_name; }
            set { data.report_name = value; }
        }

        [Column("ref_doctype")]
        public string? RefDoctype
        {
            get { return data.ref_doctype; }
            set { data.ref_doctype = value; }
        }

        [Column("reference_report")]
        public string? ReferenceReport
        {
            get { return data.reference_report; }
            set { data.reference_report = value; }
        }

        [Column("is_standard")]
        public string? IsStandard
        {
            get { return data.is_standard; }
            set { data.is_standard = value; }
        }

        [Column("module")]
        public string? Module
        {
            get { return data.module; }
            set { data.module = value; }
        }

        [Column("report_type")]
        public string? ReportType
        {
            get { return data.report_type; }
            set { data.report_type = value; }
        }

        [Column("letter_head")]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        [Column("add_total_row")]
        public int AddTotalRow
        {
            get { return data.add_total_row; }
            set { data.add_total_row = value; }
        }

        [Column("disabled")]
        public int Disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        [Column("disable_prepared_report")]
        public int DisablePreparedReport
        {
            get { return data.disable_prepared_report; }
            set { data.disable_prepared_report = value; }
        }

        [Column("prepared_report")]
        public int PreparedReport
        {
            get { return data.prepared_report; }
            set { data.prepared_report = value; }
        }

        [Column("query")]
        public string? Query
        {
            get { return data.query; }
            set { data.query = value; }
        }

        [Column("report_script")]
        public string? ReportScript
        {
            get { return data.report_script; }
            set { data.report_script = value; }
        }

        [Column("javascript")]
        public string? Javascript
        {
            get { return data.javascript; }
            set { data.javascript = value; }
        }

        [Column("json")]
        public string? Json
        {
            get { return data.json; }
            set { data.json = value; }
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

