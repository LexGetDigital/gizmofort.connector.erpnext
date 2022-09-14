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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.POSInvoiceItem
{
    public partial class ERP_Accounts_POSInvoiceItem : ERPNextObjectBase
    {
        public ERP_Accounts_POSInvoiceItem() : this(new ERPObject(_DocType.Accounts_POSInvoiceItem)) { }
        public ERP_Accounts_POSInvoiceItem(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("customer_item_code", "varchar(140)", isNullable: true)]
        public string? CustomerItemCode
        {
            get { return data.customer_item_code; }
            set { data.customer_item_code = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("base_price_list_rate", "decimal(21,9)", isNullable: false)]
        public decimal BasePriceListRate
        {
            get { return data.base_price_list_rate; }
            set { data.base_price_list_rate = value; }
        }

        [ColumnInfo("margin_type", "varchar(140)", isNullable: true)]
        public string? MarginType
        {
            get { return data.margin_type; }
            set { data.margin_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("margin_rate_or_amount", "decimal(21,9)", isNullable: false)]
        public decimal MarginRateOrAmount
        {
            get { return data.margin_rate_or_amount; }
            set { data.margin_rate_or_amount = value; }
        }

        [ColumnInfo("rate_with_margin", "decimal(21,9)", isNullable: false)]
        public decimal RateWithMargin
        {
            get { return data.rate_with_margin; }
            set { data.rate_with_margin = value; }
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

        [ColumnInfo("base_rate_with_margin", "decimal(21,9)", isNullable: false)]
        public decimal BaseRateWithMargin
        {
            get { return data.base_rate_with_margin; }
            set { data.base_rate_with_margin = value; }
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

        [ColumnInfo("is_free_item", "int(1)", isNullable: false)]
        public bool IsFreeItem
        {
            get { return ERPNextConverter.IntToBool((int)data.is_free_item); }
            set { data.is_free_item = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("grant_commission", "int(1)", isNullable: false)]
        public bool GrantCommission
        {
            get { return ERPNextConverter.IntToBool((int)data.grant_commission); }
            set { data.grant_commission = ERPNextConverter.BoolToInt(value); }
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

        [ColumnInfo("delivered_by_supplier", "int(1)", isNullable: false)]
        public bool DeliveredBySupplier
        {
            get { return ERPNextConverter.IntToBool((int)data.delivered_by_supplier); }
            set { data.delivered_by_supplier = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("income_account", "varchar(140)", isNullable: true)]
        public string? IncomeAccount
        {
            get { return data.income_account; }
            set { data.income_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_fixed_asset", "int(1)", isNullable: false)]
        public bool IsFixedAsset
        {
            get { return ERPNextConverter.IntToBool((int)data.is_fixed_asset); }
            set { data.is_fixed_asset = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("asset", "varchar(140)", isNullable: true)]
        public string? Asset
        {
            get { return data.asset; }
            set { data.asset = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("finance_book", "varchar(140)", isNullable: true)]
        public string? FinanceBook
        {
            get { return data.finance_book; }
            set { data.finance_book = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("expense_account", "varchar(140)", isNullable: true)]
        public string? ExpenseAccount
        {
            get { return data.expense_account; }
            set { data.expense_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("deferred_revenue_account", "varchar(140)", isNullable: true)]
        public string? DeferredRevenueAccount
        {
            get { return data.deferred_revenue_account; }
            set { data.deferred_revenue_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("service_stop_date", "date", isNullable: true)]
        public DateOnly? ServiceStopDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.service_stop_date); }
            set { data.service_stop_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("enable_deferred_revenue", "int(1)", isNullable: false)]
        public bool EnableDeferredRevenue
        {
            get { return ERPNextConverter.IntToBool((int)data.enable_deferred_revenue); }
            set { data.enable_deferred_revenue = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("service_start_date", "date", isNullable: true)]
        public DateOnly? ServiceStartDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.service_start_date); }
            set { data.service_start_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("service_end_date", "date", isNullable: true)]
        public DateOnly? ServiceEndDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.service_end_date); }
            set { data.service_end_date = ERPNextConverter.DateOnlyToString(value); }
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

        [ColumnInfo("target_warehouse", "varchar(140)", isNullable: true)]
        public string? TargetWarehouse
        {
            get { return data.target_warehouse; }
            set { data.target_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("quality_inspection", "varchar(140)", isNullable: true)]
        public string? QualityInspection
        {
            get { return data.quality_inspection; }
            set { data.quality_inspection = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("batch_no", "varchar(140)", isNullable: true)]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("allow_zero_valuation_rate", "int(1)", isNullable: false)]
        public bool AllowZeroValuationRate
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_zero_valuation_rate); }
            set { data.allow_zero_valuation_rate = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("serial_no", "text", isNullable: true)]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [ColumnInfo("item_tax_rate", "text", isNullable: true)]
        public string? ItemTaxRate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
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

        [ColumnInfo("sales_order", "varchar(140)", isNullable: true)]
        public string? SalesOrder
        {
            get { return data.sales_order; }
            set { data.sales_order = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("so_detail", "varchar(140)", isNullable: true)]
        public string? SoDetail
        {
            get { return data.so_detail; }
            set { data.so_detail = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("pos_invoice_item", "varchar(140)", isNullable: true)]
        public string? PosInvoiceItem
        {
            get { return data.pos_invoice_item; }
            set { data.pos_invoice_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("delivery_note", "varchar(140)", isNullable: true)]
        public string? DeliveryNote
        {
            get { return data.delivery_note; }
            set { data.delivery_note = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("dn_detail", "varchar(140)", isNullable: true)]
        public string? DnDetail
        {
            get { return data.dn_detail; }
            set { data.dn_detail = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("delivered_qty", "decimal(21,9)", isNullable: false)]
        public decimal DeliveredQty
        {
            get { return data.delivered_qty; }
            set { data.delivered_qty = value; }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
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

