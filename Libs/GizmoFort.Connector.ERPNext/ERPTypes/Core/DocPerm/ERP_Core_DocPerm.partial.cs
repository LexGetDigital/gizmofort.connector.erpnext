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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DocPerm
{
    public partial class ERP_Core_DocPerm : ERPNextObjectBase
    {
        public ERP_Core_DocPerm() : this(new ERPObject(_DocType.Core_DocPerm)) { }
        public ERP_Core_DocPerm(ERPObject obj) : base(obj) { }

        [ColumnInfo("name", "varchar(255)", isNullable: false)]
        public string Name
        {
            get { return data.name; }
            set { data.name = ERPNextConverter.TruncateString(value, 255); }
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

        [ColumnInfo("modified_by", "varchar(255)", isNullable: true)]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("owner", "varchar(255)", isNullable: true)]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("docstatus", "int(1)", isNullable: false)]
        public Docstatus Docstatus
        {
            get { return (Docstatus)data.docstatus; }
            set { data.docstatus = (int)value; }
        }

        [ColumnInfo("parent", "varchar(255)", isNullable: true)]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("parentfield", "varchar(255)", isNullable: true)]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("parenttype", "varchar(255)", isNullable: true)]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("idx", "int(8)", isNullable: false)]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [ColumnInfo("permlevel", "int(11)", isNullable: true)]
        public int? Permlevel
        {
            get { return data.permlevel; }
            set { data.permlevel = value; }
        }

        [ColumnInfo("role", "varchar(140)", isNullable: true)]
        public string? Role
        {
            get { return data.role; }
            set { data.role = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("match", "varchar(255)", isNullable: true)]
        public string? Match
        {
            get { return data.match; }
            set { data.match = ERPNextConverter.TruncateString(value, 255); }
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

        [ColumnInfo("create", "int(1)", isNullable: false)]
        public bool Create
        {
            get { return ERPNextConverter.IntToBool((int)data.create); }
            set { data.create = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("submit", "int(1)", isNullable: false)]
        public bool Submit
        {
            get { return ERPNextConverter.IntToBool((int)data.submit); }
            set { data.submit = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("cancel", "int(1)", isNullable: false)]
        public bool Cancel
        {
            get { return ERPNextConverter.IntToBool((int)data.cancel); }
            set { data.cancel = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("delete", "int(1)", isNullable: false)]
        public bool Delete
        {
            get { return ERPNextConverter.IntToBool((int)data.delete); }
            set { data.delete = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("amend", "int(1)", isNullable: false)]
        public bool Amend
        {
            get { return ERPNextConverter.IntToBool((int)data.amend); }
            set { data.amend = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("report", "int(1)", isNullable: false)]
        public bool Report
        {
            get { return ERPNextConverter.IntToBool((int)data.report); }
            set { data.report = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("export", "int(1)", isNullable: false)]
        public bool Export
        {
            get { return ERPNextConverter.IntToBool((int)data.export); }
            set { data.export = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("import", "int(1)", isNullable: false)]
        public bool Import
        {
            get { return ERPNextConverter.IntToBool((int)data.import); }
            set { data.import = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("share", "int(1)", isNullable: false)]
        public bool Share
        {
            get { return ERPNextConverter.IntToBool((int)data.share); }
            set { data.share = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("print", "int(1)", isNullable: false)]
        public bool Print
        {
            get { return ERPNextConverter.IntToBool((int)data.print); }
            set { data.print = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("email", "int(1)", isNullable: false)]
        public bool Email
        {
            get { return ERPNextConverter.IntToBool((int)data.email); }
            set { data.email = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("if_owner", "int(1)", isNullable: false)]
        public bool IfOwner
        {
            get { return ERPNextConverter.IntToBool((int)data.if_owner); }
            set { data.if_owner = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("@select", "int(1)", isNullable: false)]
        public bool Select
        {
            get { return ERPNextConverter.IntToBool((int)data.@select); }
            set { data.@select = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("set_user_permissions", "int(1)", isNullable: false)]
        public bool SetUserPermissions
        {
            get { return ERPNextConverter.IntToBool((int)data.set_user_permissions); }
            set { data.set_user_permissions = ERPNextConverter.BoolToInt(value); }
        }


    }
}

