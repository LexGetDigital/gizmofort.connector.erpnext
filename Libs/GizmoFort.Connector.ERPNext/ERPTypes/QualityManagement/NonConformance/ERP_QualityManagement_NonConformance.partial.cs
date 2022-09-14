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

namespace GizmoFort.Connector.ERPNext.ERPTypes.QualityManagement.NonConformance
{
    public partial class ERP_QualityManagement_NonConformance : ERPNextObjectBase
    {
        public ERP_QualityManagement_NonConformance() : this(new ERPObject(_DocType.QualityManagement_NonConformance)) { }
        public ERP_QualityManagement_NonConformance(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("subject", "varchar(140)", isNullable: true)]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("procedure", "varchar(140)", isNullable: true)]
        public string? Procedure
        {
            get { return data.procedure; }
            set { data.procedure = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("process_owner", "varchar(140)", isNullable: true)]
        public string? ProcessOwner
        {
            get { return data.process_owner; }
            set { data.process_owner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("full_name", "varchar(140)", isNullable: true)]
        public string? FullName
        {
            get { return data.full_name; }
            set { data.full_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("details", "longtext", isNullable: true)]
        public string? Details
        {
            get { return data.details; }
            set { data.details = value; }
        }

        [ColumnInfo("corrective_action", "longtext", isNullable: true)]
        public string? CorrectiveAction
        {
            get { return data.corrective_action; }
            set { data.corrective_action = value; }
        }

        [ColumnInfo("preventive_action", "longtext", isNullable: true)]
        public string? PreventiveAction
        {
            get { return data.preventive_action; }
            set { data.preventive_action = value; }
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

