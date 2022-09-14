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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.PackedItem
{
    public partial class ERP_Stock_PackedItem : ERPNextObjectBase
    {
        public ERP_Stock_PackedItem() : this(new ERPObject(_DocType.Stock_PackedItem)) { }
        public ERP_Stock_PackedItem(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("parent_item", "varchar(140)", isNullable: true)]
        public string? ParentItem
        {
            get { return data.parent_item; }
            set { data.parent_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_code", "varchar(140)", isNullable: true)]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_name", "varchar(140)", isNullable: true)]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("target_warehouse", "varchar(140)", isNullable: true)]
        public string? TargetWarehouse
        {
            get { return data.target_warehouse; }
            set { data.target_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("conversion_factor", "decimal(21,9)", isNullable: false)]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        [ColumnInfo("qty", "decimal(21,9)", isNullable: false)]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [ColumnInfo("rate", "decimal(21,9)", isNullable: false)]
        public decimal Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [ColumnInfo("uom", "varchar(140)", isNullable: true)]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("serial_no", "text", isNullable: true)]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [ColumnInfo("batch_no", "varchar(140)", isNullable: true)]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("actual_batch_qty", "decimal(21,9)", isNullable: false)]
        public decimal ActualBatchQty
        {
            get { return data.actual_batch_qty; }
            set { data.actual_batch_qty = value; }
        }

        [ColumnInfo("actual_qty", "decimal(21,9)", isNullable: false)]
        public decimal ActualQty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        [ColumnInfo("projected_qty", "decimal(21,9)", isNullable: false)]
        public decimal ProjectedQty
        {
            get { return data.projected_qty; }
            set { data.projected_qty = value; }
        }

        [ColumnInfo("ordered_qty", "decimal(21,9)", isNullable: false)]
        public decimal OrderedQty
        {
            get { return data.ordered_qty; }
            set { data.ordered_qty = value; }
        }

        [ColumnInfo("incoming_rate", "decimal(21,9)", isNullable: false)]
        public decimal IncomingRate
        {
            get { return data.incoming_rate; }
            set { data.incoming_rate = value; }
        }

        [ColumnInfo("picked_qty", "decimal(21,9)", isNullable: false)]
        public decimal PickedQty
        {
            get { return data.picked_qty; }
            set { data.picked_qty = value; }
        }

        [ColumnInfo("page_break", "int(1)", isNullable: false)]
        public bool PageBreak
        {
            get { return ERPNextConverter.IntToBool((int)data.page_break); }
            set { data.page_break = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("prevdoc_doctype", "varchar(140)", isNullable: true)]
        public string? PrevdocDoctype
        {
            get { return data.prevdoc_doctype; }
            set { data.prevdoc_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parent_detail_docname", "varchar(140)", isNullable: true)]
        public string? ParentDetailDocname
        {
            get { return data.parent_detail_docname; }
            set { data.parent_detail_docname = ERPNextConverter.TruncateString(value, 140); }
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

