/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/13/2022 7:48:39 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.SupplierQuotationItem
{
    public partial class ERP_Buying_SupplierQuotationItem : ERPNextObjectBase
    {
        public ERP_Buying_SupplierQuotationItem() : this(new ERPObject(_DocType.Buying_SupplierQuotationItem)) { }
        public ERP_Buying_SupplierQuotationItem(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Buying_SupplierQuotationItem>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Buying_SupplierQuotationItem>(columnName);
        //}

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

        [ColumnInfo("supplier_part_no", "varchar(140)", isNullable: true)]
        public string? SupplierPartNo
        {
            get { return data.supplier_part_no; }
            set { data.supplier_part_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_name", "varchar(140)", isNullable: true)]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lead_time_days", "int(11)", isNullable: false)]
        public int LeadTimeDays
        {
            get { return data.lead_time_days; }
            set { data.lead_time_days = value; }
        }

        [ColumnInfo("expected_delivery_date", "date", isNullable: true)]
        public DateOnly? ExpectedDeliveryDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.expected_delivery_date); }
            set { data.expected_delivery_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("is_free_item", "int(1)", isNullable: false)]
        public bool IsFreeItem
        {
            get { return ERPNextConverter.IntToBool((int)data.is_free_item); }
            set { data.is_free_item = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("item_group", "varchar(140)", isNullable: true)]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("brand", "varchar(140)", isNullable: true)]
        public string? Brand
        {
            get { return data.brand; }
            set { data.brand = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("qty", "decimal(21,9)", isNullable: false)]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [ColumnInfo("stock_uom", "varchar(140)", isNullable: true)]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("uom", "varchar(140)", isNullable: true)]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("conversion_factor", "decimal(21,9)", isNullable: false)]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        [ColumnInfo("stock_qty", "decimal(21,9)", isNullable: false)]
        public decimal StockQty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
        }

        [ColumnInfo("price_list_rate", "decimal(21,9)", isNullable: false)]
        public decimal PriceListRate
        {
            get { return data.price_list_rate; }
            set { data.price_list_rate = value; }
        }

        [ColumnInfo("discount_percentage", "decimal(21,9)", isNullable: false)]
        public decimal DiscountPercentage
        {
            get { return data.discount_percentage; }
            set { data.discount_percentage = value; }
        }

        [ColumnInfo("discount_amount", "decimal(21,9)", isNullable: false)]
        public decimal DiscountAmount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        [ColumnInfo("base_price_list_rate", "decimal(21,9)", isNullable: false)]
        public decimal BasePriceListRate
        {
            get { return data.base_price_list_rate; }
            set { data.base_price_list_rate = value; }
        }

        [ColumnInfo("rate", "decimal(21,9)", isNullable: false)]
        public decimal Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [ColumnInfo("amount", "decimal(21,9)", isNullable: false)]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [ColumnInfo("item_tax_template", "varchar(140)", isNullable: true)]
        public string? ItemTaxTemplate
        {
            get { return data.item_tax_template; }
            set { data.item_tax_template = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("base_rate", "decimal(21,9)", isNullable: false)]
        public decimal BaseRate
        {
            get { return data.base_rate; }
            set { data.base_rate = value; }
        }

        [ColumnInfo("base_amount", "decimal(21,9)", isNullable: false)]
        public decimal BaseAmount
        {
            get { return data.base_amount; }
            set { data.base_amount = value; }
        }

        [ColumnInfo("pricing_rules", "text", isNullable: true)]
        public string? PricingRules
        {
            get { return data.pricing_rules; }
            set { data.pricing_rules = value; }
        }

        [ColumnInfo("net_rate", "decimal(21,9)", isNullable: false)]
        public decimal NetRate
        {
            get { return data.net_rate; }
            set { data.net_rate = value; }
        }

        [ColumnInfo("net_amount", "decimal(21,9)", isNullable: false)]
        public decimal NetAmount
        {
            get { return data.net_amount; }
            set { data.net_amount = value; }
        }

        [ColumnInfo("base_net_rate", "decimal(21,9)", isNullable: false)]
        public decimal BaseNetRate
        {
            get { return data.base_net_rate; }
            set { data.base_net_rate = value; }
        }

        [ColumnInfo("base_net_amount", "decimal(21,9)", isNullable: false)]
        public decimal BaseNetAmount
        {
            get { return data.base_net_amount; }
            set { data.base_net_amount = value; }
        }

        [ColumnInfo("weight_per_unit", "decimal(21,9)", isNullable: false)]
        public decimal WeightPerUnit
        {
            get { return data.weight_per_unit; }
            set { data.weight_per_unit = value; }
        }

        [ColumnInfo("total_weight", "decimal(21,9)", isNullable: false)]
        public decimal TotalWeight
        {
            get { return data.total_weight; }
            set { data.total_weight = value; }
        }

        [ColumnInfo("weight_uom", "varchar(140)", isNullable: true)]
        public string? WeightUom
        {
            get { return data.weight_uom; }
            set { data.weight_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("prevdoc_doctype", "varchar(140)", isNullable: true)]
        public string? PrevdocDoctype
        {
            get { return data.prevdoc_doctype; }
            set { data.prevdoc_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("material_request", "varchar(140)", isNullable: true)]
        public string? MaterialRequest
        {
            get { return data.material_request; }
            set { data.material_request = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sales_order", "varchar(140)", isNullable: true)]
        public string? SalesOrder
        {
            get { return data.sales_order; }
            set { data.sales_order = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("request_for_quotation", "varchar(140)", isNullable: true)]
        public string? RequestForQuotation
        {
            get { return data.request_for_quotation; }
            set { data.request_for_quotation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("material_request_item", "varchar(140)", isNullable: true)]
        public string? MaterialRequestItem
        {
            get { return data.material_request_item; }
            set { data.material_request_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("request_for_quotation_item", "varchar(140)", isNullable: true)]
        public string? RequestForQuotationItem
        {
            get { return data.request_for_quotation_item; }
            set { data.request_for_quotation_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_tax_rate", "longtext", isNullable: true)]
        public string? ItemTaxRate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        [ColumnInfo("manufacturer", "varchar(140)", isNullable: true)]
        public string? Manufacturer
        {
            get { return data.manufacturer; }
            set { data.manufacturer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("manufacturer_part_no", "varchar(140)", isNullable: true)]
        public string? ManufacturerPartNo
        {
            get { return data.manufacturer_part_no; }
            set { data.manufacturer_part_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("project", "varchar(140)", isNullable: true)]
        public string? Project
        {
            get { return data.project; }
            set { data.project = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("page_break", "int(1)", isNullable: false)]
        public bool PageBreak
        {
            get { return ERPNextConverter.IntToBool((int)data.page_break); }
            set { data.page_break = ERPNextConverter.BoolToInt(value); }
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

