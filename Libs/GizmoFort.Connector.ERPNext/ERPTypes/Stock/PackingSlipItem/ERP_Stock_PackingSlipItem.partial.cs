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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.PackingSlipItem
{
    public partial class ERP_Stock_PackingSlipItem : ERPNextObjectBase
    {
        public ERP_Stock_PackingSlipItem() : this(new ERPObject(_DocType.Stock_PackingSlipItem)) { }
        public ERP_Stock_PackingSlipItem(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("batch_no", "varchar(140)", isNullable: true)]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("qty", "decimal(21,9)", isNullable: false)]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [ColumnInfo("net_weight", "decimal(21,9)", isNullable: false)]
        public decimal NetWeight
        {
            get { return data.net_weight; }
            set { data.net_weight = value; }
        }

        [ColumnInfo("stock_uom", "varchar(140)", isNullable: true)]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("weight_uom", "varchar(140)", isNullable: true)]
        public string? WeightUom
        {
            get { return data.weight_uom; }
            set { data.weight_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("page_break", "int(1)", isNullable: false)]
        public bool PageBreak
        {
            get { return ERPNextConverter.IntToBool((int)data.page_break); }
            set { data.page_break = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("dn_detail", "varchar(140)", isNullable: true)]
        public string? DnDetail
        {
            get { return data.dn_detail; }
            set { data.dn_detail = ERPNextConverter.TruncateString(value, 140); }
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

