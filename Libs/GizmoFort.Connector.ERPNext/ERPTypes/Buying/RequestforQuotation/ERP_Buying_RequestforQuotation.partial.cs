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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.RequestforQuotation
{
    public partial class ERP_Buying_RequestforQuotation : ERPNextObjectBase
    {
        public ERP_Buying_RequestforQuotation() : this(new ERPObject(_DocType.Buying_RequestforQuotation)) { }
        public ERP_Buying_RequestforQuotation(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Buying_RequestforQuotation>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Buying_RequestforQuotation>(columnName);
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

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("vendor", "varchar(140)", isNullable: true)]
        public string? Vendor
        {
            get { return data.vendor; }
            set { data.vendor = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("transaction_date", "date", isNullable: true)]
        public DateOnly? TransactionDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.transaction_date); }
            set { data.transaction_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("schedule_date", "date", isNullable: true)]
        public DateOnly? ScheduleDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.schedule_date); }
            set { data.schedule_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("salutation", "varchar(140)", isNullable: true)]
        public string? Salutation
        {
            get { return data.salutation; }
            set { data.salutation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("subject", "varchar(140)", isNullable: true)]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("email_template", "varchar(140)", isNullable: true)]
        public string? EmailTemplate
        {
            get { return data.email_template; }
            set { data.email_template = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("message_for_supplier", "longtext", isNullable: true)]
        public string? MessageForSupplier
        {
            get { return data.message_for_supplier; }
            set { data.message_for_supplier = value; }
        }

        [ColumnInfo("tc_name", "varchar(140)", isNullable: true)]
        public string? TcName
        {
            get { return data.tc_name; }
            set { data.tc_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("terms", "longtext", isNullable: true)]
        public string? Terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        [ColumnInfo("select_print_heading", "varchar(140)", isNullable: true)]
        public string? SelectPrintHeading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("letter_head", "varchar(140)", isNullable: true)]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("opportunity", "varchar(140)", isNullable: true)]
        public string? Opportunity
        {
            get { return data.opportunity; }
            set { data.opportunity = ERPNextConverter.TruncateString(value, 140); }
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

