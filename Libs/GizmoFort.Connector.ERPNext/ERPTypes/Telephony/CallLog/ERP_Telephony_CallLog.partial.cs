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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Telephony.CallLog
{
    public partial class ERP_Telephony_CallLog : ERPNextObjectBase
    {
        public ERP_Telephony_CallLog() : this(new ERPObject(_DocType.Telephony_CallLog)) { }
        public ERP_Telephony_CallLog(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Telephony_CallLog>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Telephony_CallLog>(columnName);
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

        [ColumnInfo("id", "varchar(140)", isNullable: true)]
        public string? Id
        {
            get { return data.id; }
            set { data.id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("@from", "varchar(140)", isNullable: true)]
        public string? From
        {
            get { return data.@from; }
            set { data.@from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("to", "varchar(140)", isNullable: true)]
        public string? To
        {
            get { return data.to; }
            set { data.to = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("call_received_by", "varchar(140)", isNullable: true)]
        public string? CallReceivedBy
        {
            get { return data.call_received_by; }
            set { data.call_received_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("employee_user_id", "varchar(140)", isNullable: true)]
        public string? EmployeeUserId
        {
            get { return data.employee_user_id; }
            set { data.employee_user_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("medium", "varchar(140)", isNullable: true)]
        public string? Medium
        {
            get { return data.medium; }
            set { data.medium = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("start_time", "datetime(6)", isNullable: true)]
        public DateTimeOffset? StartTime
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.start_time); }
            set { data.start_time = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("end_time", "datetime(6)", isNullable: true)]
        public DateTimeOffset? EndTime
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.end_time); }
            set { data.end_time = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("type", "varchar(140)", isNullable: true)]
        public string? Type
        {
            get { return data.type; }
            set { data.type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("duration", "decimal(21,9)", isNullable: true)]
        public decimal? Duration
        {
            get { return data.duration; }
            set { data.duration = value; }
        }

        [ColumnInfo("recording_url", "varchar(140)", isNullable: true)]
        public string? RecordingUrl
        {
            get { return data.recording_url; }
            set { data.recording_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("type_of_call", "varchar(140)", isNullable: true)]
        public string? TypeOfCall
        {
            get { return data.type_of_call; }
            set { data.type_of_call = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("summary", "text", isNullable: true)]
        public string? Summary
        {
            get { return data.summary; }
            set { data.summary = value; }
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

