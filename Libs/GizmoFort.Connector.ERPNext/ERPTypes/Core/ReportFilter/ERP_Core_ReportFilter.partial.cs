/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/12/2022 2:29:08 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.ReportFilter
{
    public partial class ERP_Core_ReportFilter : ERPNextObjectBase
    {
        public ERP_Core_ReportFilter() : this(new ERPObject(_DockType.Core_ReportFilter)) { }
        public ERP_Core_ReportFilter(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Core_ReportFilter>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Core_ReportFilter>(columnName);
        }


        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTimeOffset? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTimeOffset? Modified
        {
            get { return data.modified; }
            set { data.modified = value; }
        }

        [Column("modified_by")]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = value; }
        }

        [Column("owner")]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = value; }
        }

        [Column("docstatus")]
        public int Docstatus
        {
            get { return data.docstatus; }
            set { data.docstatus = value; }
        }

        [Column("idx")]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [Column("fieldname")]
        public string? Fieldname
        {
            get { return data.fieldname; }
            set { data.fieldname = value; }
        }

        [Column("label")]
        public string? Label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        [Column("fieldtype")]
        public string? Fieldtype
        {
            get { return data.fieldtype; }
            set { data.fieldtype = value; }
        }

        [Column("mandatory")]
        public int Mandatory
        {
            get { return data.mandatory; }
            set { data.mandatory = value; }
        }

        [Column("options")]
        public string? Options
        {
            get { return data.options; }
            set { data.options = value; }
        }

        [Column("wildcard_filter")]
        public int WildcardFilter
        {
            get { return data.wildcard_filter; }
            set { data.wildcard_filter = value; }
        }

        [Column("parent")]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = value; }
        }

        [Column("parentfield")]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = value; }
        }

        [Column("parenttype")]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = value; }
        }


    }
}

