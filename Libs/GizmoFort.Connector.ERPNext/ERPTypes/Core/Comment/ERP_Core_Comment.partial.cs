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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.Comment
{
    public partial class ERP_Core_Comment : ERPNextObjectBase
    {
        public ERP_Core_Comment() : this(new ERPObject(_DocType.Core_Comment)) { }
        public ERP_Core_Comment(ERPObject obj) : base(obj) { }

        [ColumnInfo("comment_type", "varchar(140)", isNullable: true)]
        public string? CommentType
        {
            get { return data.comment_type; }
            set { data.comment_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("comment_email", "varchar(140)", isNullable: true)]
        public string? CommentEmail
        {
            get { return data.comment_email; }
            set { data.comment_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("subject", "text", isNullable: true)]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        [ColumnInfo("comment_by", "varchar(140)", isNullable: true)]
        public string? CommentBy
        {
            get { return data.comment_by; }
            set { data.comment_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("published", "int(1)", isNullable: false)]
        public bool Published
        {
            get { return ERPNextConverter.IntToBool((int)data.published); }
            set { data.published = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("seen", "int(1)", isNullable: false)]
        public bool Seen
        {
            get { return ERPNextConverter.IntToBool((int)data.seen); }
            set { data.seen = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("reference_doctype", "varchar(140)", isNullable: true)]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_name", "varchar(140)", isNullable: true)]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("link_doctype", "varchar(140)", isNullable: true)]
        public string? LinkDoctype
        {
            get { return data.link_doctype; }
            set { data.link_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("link_name", "varchar(140)", isNullable: true)]
        public string? LinkName
        {
            get { return data.link_name; }
            set { data.link_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_owner", "varchar(140)", isNullable: true)]
        public string? ReferenceOwner
        {
            get { return data.reference_owner; }
            set { data.reference_owner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("content", "longtext", isNullable: true)]
        public string? Content
        {
            get { return data.content; }
            set { data.content = value; }
        }

        [ColumnInfo("ip_address", "varchar(140)", isNullable: true)]
        public string? IpAddress
        {
            get { return data.ip_address; }
            set { data.ip_address = ERPNextConverter.TruncateString(value, 140); }
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


    }
}

