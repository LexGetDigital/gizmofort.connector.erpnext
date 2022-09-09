/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Email.AutoEmailReport
{
    public partial class ERP_Email_AutoEmailReport : ERPNextObjectBase
    {
        public ERP_Email_AutoEmailReport() : this(new ERPObject(_DockType.Email_AutoEmailReport)) { }
        public ERP_Email_AutoEmailReport(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Email_AutoEmailReport>(propertyName);
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

        [Column("report")]
        public string? Report
        {
            get { return data.report; }
            set { data.report = value; }
        }

        [Column("user")]
        public string? User
        {
            get { return data.user; }
            set { data.user = value; }
        }

        [Column("enabled")]
        public int Enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
        }

        [Column("report_type")]
        public string? ReportType
        {
            get { return data.report_type; }
            set { data.report_type = value; }
        }

        [Column("reference_report")]
        public string? ReferenceReport
        {
            get { return data.reference_report; }
            set { data.reference_report = value; }
        }

        [Column("send_if_data")]
        public int SendIfData
        {
            get { return data.send_if_data; }
            set { data.send_if_data = value; }
        }

        [Column("data_modified_till")]
        public int DataModifiedTill
        {
            get { return data.data_modified_till; }
            set { data.data_modified_till = value; }
        }

        [Column("no_of_rows")]
        public int NoOfRows
        {
            get { return data.no_of_rows; }
            set { data.no_of_rows = value; }
        }

        [Column("filters")]
        public string? Filters
        {
            get { return data.filters; }
            set { data.filters = value; }
        }

        [Column("filter_meta")]
        public string? FilterMeta
        {
            get { return data.filter_meta; }
            set { data.filter_meta = value; }
        }

        [Column("from_date_field")]
        public string? FromDateField
        {
            get { return data.from_date_field; }
            set { data.from_date_field = value; }
        }

        [Column("to_date_field")]
        public string? ToDateField
        {
            get { return data.to_date_field; }
            set { data.to_date_field = value; }
        }

        [Column("dynamic_date_period")]
        public string? DynamicDatePeriod
        {
            get { return data.dynamic_date_period; }
            set { data.dynamic_date_period = value; }
        }

        [Column("email_to")]
        public string? EmailTo
        {
            get { return data.email_to; }
            set { data.email_to = value; }
        }

        [Column("day_of_week")]
        public string? DayOfWeek
        {
            get { return data.day_of_week; }
            set { data.day_of_week = value; }
        }

        [Column("frequency")]
        public string? Frequency
        {
            get { return data.frequency; }
            set { data.frequency = value; }
        }

        [Column("format")]
        public string? Format
        {
            get { return data.format; }
            set { data.format = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
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

