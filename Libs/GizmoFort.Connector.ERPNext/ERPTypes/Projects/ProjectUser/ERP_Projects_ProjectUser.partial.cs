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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Projects.ProjectUser
{
    public partial class ERP_Projects_ProjectUser : ERPNextObjectBase
    {
        public ERP_Projects_ProjectUser() : this(new ERPObject(_DocType.Projects_ProjectUser)) { }
        public ERP_Projects_ProjectUser(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("user", "varchar(140)", isNullable: true)]
        public string? User
        {
            get { return data.user; }
            set { data.user = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("email", "varchar(140)", isNullable: true)]
        public string? Email
        {
            get { return data.email; }
            set { data.email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("image", "varchar(140)", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("full_name", "varchar(140)", isNullable: true)]
        public string? FullName
        {
            get { return data.full_name; }
            set { data.full_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("welcome_email_sent", "int(1)", isNullable: false)]
        public bool WelcomeEmailSent
        {
            get { return ERPNextConverter.IntToBool((int)data.welcome_email_sent); }
            set { data.welcome_email_sent = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("view_attachments", "int(1)", isNullable: false)]
        public bool ViewAttachments
        {
            get { return ERPNextConverter.IntToBool((int)data.view_attachments); }
            set { data.view_attachments = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("project_status", "text", isNullable: true)]
        public string? ProjectStatus
        {
            get { return data.project_status; }
            set { data.project_status = value; }
        }

        [ColumnInfo("parent", "varchar(140)", isNullable: true)]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parentfield", "varchar(140)", isNullable: true)]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parenttype", "varchar(140)", isNullable: true)]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = ERPNextConverter.TruncateString(value, 140); }
        }


    }
}

