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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.GoogleCalendar
{
    public partial class ERP_Integrations_GoogleCalendar : ERPNextObjectBase
    {
        public ERP_Integrations_GoogleCalendar() : this(new ERPObject(_DocType.Integrations_GoogleCalendar)) { }
        public ERP_Integrations_GoogleCalendar(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("enable", "int(1)", isNullable: false)]
        public bool Enable
        {
            get { return ERPNextConverter.IntToBool((int)data.enable); }
            set { data.enable = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("calendar_name", "varchar(140)", isNullable: true)]
        public string? CalendarName
        {
            get { return data.calendar_name; }
            set { data.calendar_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("user", "varchar(140)", isNullable: true)]
        public string? User
        {
            get { return data.user; }
            set { data.user = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("pull_from_google_calendar", "int(1)", isNullable: false)]
        public bool PullFromGoogleCalendar
        {
            get { return ERPNextConverter.IntToBool((int)data.pull_from_google_calendar); }
            set { data.pull_from_google_calendar = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("push_to_google_calendar", "int(1)", isNullable: false)]
        public bool PushToGoogleCalendar
        {
            get { return ERPNextConverter.IntToBool((int)data.push_to_google_calendar); }
            set { data.push_to_google_calendar = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("google_calendar_id", "varchar(140)", isNullable: true)]
        public string? GoogleCalendarId
        {
            get { return data.google_calendar_id; }
            set { data.google_calendar_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("refresh_token", "text", isNullable: true)]
        public string? RefreshToken
        {
            get { return data.refresh_token; }
            set { data.refresh_token = value; }
        }

        [ColumnInfo("authorization_code", "text", isNullable: true)]
        public string? AuthorizationCode
        {
            get { return data.authorization_code; }
            set { data.authorization_code = value; }
        }

        [ColumnInfo("next_sync_token", "text", isNullable: true)]
        public string? NextSyncToken
        {
            get { return data.next_sync_token; }
            set { data.next_sync_token = value; }
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

