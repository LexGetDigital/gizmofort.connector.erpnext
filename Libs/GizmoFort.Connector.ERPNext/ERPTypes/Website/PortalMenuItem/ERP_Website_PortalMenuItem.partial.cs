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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.PortalMenuItem
{
    public partial class ERP_Website_PortalMenuItem : ERPNextObjectBase
    {
        public ERP_Website_PortalMenuItem() : this(new ERPObject(_DockType.Website_PortalMenuItem)) { }
        public ERP_Website_PortalMenuItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Website_PortalMenuItem>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Website_PortalMenuItem>(columnName);
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

        [Column("title")]
        public string? Title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        [Column("enabled")]
        public int Enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
        }

        [Column("route")]
        public string? Route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        [Column("reference_doctype")]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        [Column("role")]
        public string? Role
        {
            get { return data.role; }
            set { data.role = value; }
        }

        [Column("target")]
        public string? Target
        {
            get { return data.target; }
            set { data.target = value; }
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

