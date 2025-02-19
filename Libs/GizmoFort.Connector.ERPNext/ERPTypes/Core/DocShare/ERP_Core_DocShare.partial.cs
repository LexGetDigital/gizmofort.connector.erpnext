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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DocShare
{
    public partial class ERP_Core_DocShare : ERPNextObjectBase
    {
        public ERP_Core_DocShare() : this(new ERPObject(_DocType.Core_DocShare)) { }
        public ERP_Core_DocShare(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("user", "varchar(140)", isNullable: true)]
        public string? User
        {
            get { return data.user; }
            set { data.user = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("share_doctype", "varchar(140)", isNullable: true)]
        public string? ShareDoctype
        {
            get { return data.share_doctype; }
            set { data.share_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("share_name", "varchar(140)", isNullable: true)]
        public string? ShareName
        {
            get { return data.share_name; }
            set { data.share_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("read", "int(1)", isNullable: false)]
        public bool Read
        {
            get { return ERPNextConverter.IntToBool((int)data.read); }
            set { data.read = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("write", "int(1)", isNullable: false)]
        public bool Write
        {
            get { return ERPNextConverter.IntToBool((int)data.write); }
            set { data.write = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("share", "int(1)", isNullable: false)]
        public bool Share
        {
            get { return ERPNextConverter.IntToBool((int)data.share); }
            set { data.share = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("submit", "int(1)", isNullable: false)]
        public bool Submit
        {
            get { return ERPNextConverter.IntToBool((int)data.submit); }
            set { data.submit = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("everyone", "int(1)", isNullable: false)]
        public bool Everyone
        {
            get { return ERPNextConverter.IntToBool((int)data.everyone); }
            set { data.everyone = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("notify_by_email", "int(1)", isNullable: false)]
        public bool NotifyByEmail
        {
            get { return ERPNextConverter.IntToBool((int)data.notify_by_email); }
            set { data.notify_by_email = ERPNextConverter.BoolToInt(value); }
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

