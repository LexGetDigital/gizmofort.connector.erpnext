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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Social.EnergyPointLog
{
    public partial class ERP_Social_EnergyPointLog : ERPNextObjectBase
    {
        public ERP_Social_EnergyPointLog() : this(new ERPObject(_DocType.Social_EnergyPointLog)) { }
        public ERP_Social_EnergyPointLog(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("type", "varchar(140)", isNullable: true)]
        public string? Type
        {
            get { return data.type; }
            set { data.type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("points", "int(11)", isNullable: false)]
        public int Points
        {
            get { return data.points; }
            set { data.points = value; }
        }

        [ColumnInfo("rule", "varchar(140)", isNullable: true)]
        public string? Rule
        {
            get { return data.rule; }
            set { data.rule = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("reverted", "int(1)", isNullable: false)]
        public bool Reverted
        {
            get { return ERPNextConverter.IntToBool((int)data.reverted); }
            set { data.reverted = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("revert_of", "varchar(140)", isNullable: true)]
        public string? RevertOf
        {
            get { return data.revert_of; }
            set { data.revert_of = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reason", "text", isNullable: true)]
        public string? Reason
        {
            get { return data.reason; }
            set { data.reason = value; }
        }

        [ColumnInfo("seen", "int(1)", isNullable: false)]
        public bool Seen
        {
            get { return ERPNextConverter.IntToBool((int)data.seen); }
            set { data.seen = ERPNextConverter.BoolToInt(value); }
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

