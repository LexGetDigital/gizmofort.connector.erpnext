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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.WebFormField
{
    public partial class ERP_Website_WebFormField : ERPNextObjectBase
    {
        public ERP_Website_WebFormField() : this(new ERPObject(_DocType.Website_WebFormField)) { }
        public ERP_Website_WebFormField(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("fieldname", "varchar(140)", isNullable: true)]
        public string? Fieldname
        {
            get { return data.fieldname; }
            set { data.fieldname = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("fieldtype", "varchar(140)", isNullable: true)]
        public string? Fieldtype
        {
            get { return data.fieldtype; }
            set { data.fieldtype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("label", "varchar(140)", isNullable: true)]
        public string? Label
        {
            get { return data.label; }
            set { data.label = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("allow_read_on_all_link_options", "int(1)", isNullable: false)]
        public bool AllowReadOnAllLinkOptions
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_read_on_all_link_options); }
            set { data.allow_read_on_all_link_options = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("reqd", "int(1)", isNullable: false)]
        public bool Reqd
        {
            get { return ERPNextConverter.IntToBool((int)data.reqd); }
            set { data.reqd = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("read_only", "int(1)", isNullable: false)]
        public bool ReadOnly
        {
            get { return ERPNextConverter.IntToBool((int)data.read_only); }
            set { data.read_only = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("show_in_filter", "int(1)", isNullable: false)]
        public bool ShowInFilter
        {
            get { return ERPNextConverter.IntToBool((int)data.show_in_filter); }
            set { data.show_in_filter = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("hidden", "int(1)", isNullable: false)]
        public bool Hidden
        {
            get { return ERPNextConverter.IntToBool((int)data.hidden); }
            set { data.hidden = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("options", "text", isNullable: true)]
        public string? Options
        {
            get { return data.options; }
            set { data.options = value; }
        }

        [ColumnInfo("max_length", "int(11)", isNullable: false)]
        public int MaxLength
        {
            get { return data.max_length; }
            set { data.max_length = value; }
        }

        [ColumnInfo("max_value", "int(11)", isNullable: false)]
        public int MaxValue
        {
            get { return data.max_value; }
            set { data.max_value = value; }
        }

        [ColumnInfo("depends_on", "longtext", isNullable: true)]
        public string? DependsOn
        {
            get { return data.depends_on; }
            set { data.depends_on = value; }
        }

        [ColumnInfo("mandatory_depends_on", "longtext", isNullable: true)]
        public string? MandatoryDependsOn
        {
            get { return data.mandatory_depends_on; }
            set { data.mandatory_depends_on = value; }
        }

        [ColumnInfo("read_only_depends_on", "longtext", isNullable: true)]
        public string? ReadOnlyDependsOn
        {
            get { return data.read_only_depends_on; }
            set { data.read_only_depends_on = value; }
        }

        [ColumnInfo("description", "text", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("@default", "varchar(140)", isNullable: true)]
        public string? Default
        {
            get { return data.@default; }
            set { data.@default = ERPNextConverter.TruncateString(value, 140); }
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

