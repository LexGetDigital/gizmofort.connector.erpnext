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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.ItemVariantAttribute
{
    public partial class ERP_Stock_ItemVariantAttribute : ERPNextObjectBase
    {
        public ERP_Stock_ItemVariantAttribute() : this(new ERPObject(_DocType.Stock_ItemVariantAttribute)) { }
        public ERP_Stock_ItemVariantAttribute(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("variant_of", "varchar(140)", isNullable: true)]
        public string? VariantOf
        {
            get { return data.variant_of; }
            set { data.variant_of = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("attribute", "varchar(140)", isNullable: true)]
        public string? Attribute
        {
            get { return data.attribute; }
            set { data.attribute = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("attribute_value", "varchar(140)", isNullable: true)]
        public string? AttributeValue
        {
            get { return data.attribute_value; }
            set { data.attribute_value = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("numeric_values", "int(1)", isNullable: false)]
        public bool NumericValues
        {
            get { return ERPNextConverter.IntToBool((int)data.numeric_values); }
            set { data.numeric_values = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("from_range", "decimal(21,9)", isNullable: false)]
        public decimal FromRange
        {
            get { return data.from_range; }
            set { data.from_range = value; }
        }

        [ColumnInfo("increment", "decimal(21,9)", isNullable: false)]
        public decimal Increment
        {
            get { return data.increment; }
            set { data.increment = value; }
        }

        [ColumnInfo("to_range", "decimal(21,9)", isNullable: false)]
        public decimal ToRange
        {
            get { return data.to_range; }
            set { data.to_range = value; }
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

