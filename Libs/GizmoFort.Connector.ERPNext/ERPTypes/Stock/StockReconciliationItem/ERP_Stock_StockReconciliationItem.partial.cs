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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.StockReconciliationItem
{
    public partial class ERP_Stock_StockReconciliationItem : ERPNextObjectBase
    {
        public ERP_Stock_StockReconciliationItem() : this(new ERPObject(_DocType.Stock_StockReconciliationItem)) { }
        public ERP_Stock_StockReconciliationItem(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("barcode", "varchar(140)", isNullable: true)]
        public string? Barcode
        {
            get { return data.barcode; }
            set { data.barcode = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("qty", "decimal(21,9)", isNullable: false)]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [ColumnInfo("valuation_rate", "decimal(21,9)", isNullable: false)]
        public decimal ValuationRate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        [ColumnInfo("amount", "decimal(21,9)", isNullable: false)]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [ColumnInfo("allow_zero_valuation_rate", "int(1)", isNullable: false)]
        public bool AllowZeroValuationRate
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_zero_valuation_rate); }
            set { data.allow_zero_valuation_rate = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("batch_no", "varchar(140)", isNullable: true)]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("serial_no", "text", isNullable: true)]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [ColumnInfo("current_qty", "decimal(21,9)", isNullable: false)]
        public decimal CurrentQty
        {
            get { return data.current_qty; }
            set { data.current_qty = value; }
        }

        [ColumnInfo("current_amount", "decimal(21,9)", isNullable: false)]
        public decimal CurrentAmount
        {
            get { return data.current_amount; }
            set { data.current_amount = value; }
        }

        [ColumnInfo("current_valuation_rate", "decimal(21,9)", isNullable: false)]
        public decimal CurrentValuationRate
        {
            get { return data.current_valuation_rate; }
            set { data.current_valuation_rate = value; }
        }

        [ColumnInfo("current_serial_no", "text", isNullable: true)]
        public string? CurrentSerialNo
        {
            get { return data.current_serial_no; }
            set { data.current_serial_no = value; }
        }

        [ColumnInfo("quantity_difference", "varchar(140)", isNullable: true)]
        public string? QuantityDifference
        {
            get { return data.quantity_difference; }
            set { data.quantity_difference = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amount_difference", "decimal(21,9)", isNullable: false)]
        public decimal AmountDifference
        {
            get { return data.amount_difference; }
            set { data.amount_difference = value; }
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

