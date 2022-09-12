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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.ItemVariantAttribute
{
    public partial class ERP_Stock_ItemVariantAttribute : ERPNextObjectBase
    {
        public ERP_Stock_ItemVariantAttribute() : this(new ERPObject(_DockType.Stock_ItemVariantAttribute)) { }
        public ERP_Stock_ItemVariantAttribute(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Stock_ItemVariantAttribute>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Stock_ItemVariantAttribute>(columnName);
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

        [Column("variant_of")]
        public string? VariantOf
        {
            get { return data.variant_of; }
            set { data.variant_of = value; }
        }

        [Column("attribute")]
        public string? Attribute
        {
            get { return data.attribute; }
            set { data.attribute = value; }
        }

        [Column("attribute_value")]
        public string? AttributeValue
        {
            get { return data.attribute_value; }
            set { data.attribute_value = value; }
        }

        [Column("numeric_values")]
        public int NumericValues
        {
            get { return data.numeric_values; }
            set { data.numeric_values = value; }
        }

        [Column("from_range")]
        public decimal FromRange
        {
            get { return data.from_range; }
            set { data.from_range = value; }
        }

        [Column("increment")]
        public decimal Increment
        {
            get { return data.increment; }
            set { data.increment = value; }
        }

        [Column("to_range")]
        public decimal ToRange
        {
            get { return data.to_range; }
            set { data.to_range = value; }
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

