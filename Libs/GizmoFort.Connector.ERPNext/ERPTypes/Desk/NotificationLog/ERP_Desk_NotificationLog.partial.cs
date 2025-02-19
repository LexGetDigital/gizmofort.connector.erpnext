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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.NotificationLog
{
    public partial class ERP_Desk_NotificationLog : ERPNextObjectBase
    {
        public ERP_Desk_NotificationLog() : this(new ERPObject(_DocType.Desk_NotificationLog)) { }
        public ERP_Desk_NotificationLog(ERPObject obj) : base(obj) { }

        [ColumnInfo("name", "bigint(20)", isNullable: false)]
        public long Name
        {
            get { return data.name; }
            set { data.name = value; }
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

        [ColumnInfo("subject", "text", isNullable: true)]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        [ColumnInfo("for_user", "varchar(140)", isNullable: true)]
        public string? ForUser
        {
            get { return data.for_user; }
            set { data.for_user = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("type", "varchar(140)", isNullable: true)]
        public string? Type
        {
            get { return data.type; }
            set { data.type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("email_content", "longtext", isNullable: true)]
        public string? EmailContent
        {
            get { return data.email_content; }
            set { data.email_content = value; }
        }

        [ColumnInfo("document_type", "varchar(140)", isNullable: true)]
        public string? DocumentType
        {
            get { return data.document_type; }
            set { data.document_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("read", "int(1)", isNullable: false)]
        public bool Read
        {
            get { return ERPNextConverter.IntToBool((int)data.read); }
            set { data.read = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("document_name", "varchar(140)", isNullable: true)]
        public string? DocumentName
        {
            get { return data.document_name; }
            set { data.document_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("attached_file", "longtext", isNullable: true)]
        public string? AttachedFile
        {
            get { return data.attached_file; }
            set { data.attached_file = value; }
        }

        [ColumnInfo("from_user", "varchar(140)", isNullable: true)]
        public string? FromUser
        {
            get { return data.from_user; }
            set { data.from_user = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("_seen", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}

