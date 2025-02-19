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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.PurchaseReceiptItem
{
    public partial class ERP_Stock_PurchaseReceiptItem : ERPNextObjectBase
    {
        public ERP_Stock_PurchaseReceiptItem() : this(new ERPObject(_DocType.Stock_PurchaseReceiptItem)) { }
        public ERP_Stock_PurchaseReceiptItem(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("product_bundle", "varchar(140)", isNullable: true)]
        public string? ProductBundle
        {
            get { return data.product_bundle; }
            set { data.product_bundle = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("brand", "varchar(140)", isNullable: true)]
        public string? Brand
        {
            get { return data.brand; }
            set { data.brand = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_group", "varchar(140)", isNullable: true)]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("received_qty", "decimal(21,9)", isNullable: false)]
        public decimal ReceivedQty
        {
            get { return data.received_qty; }
            set { data.received_qty = value; }
        }

        [ColumnInfo("qty", "decimal(21,9)", isNullable: false)]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [ColumnInfo("rejected_qty", "decimal(21,9)", isNullable: false)]
        public decimal RejectedQty
        {
            get { return data.rejected_qty; }
            set { data.rejected_qty = value; }
        }

        [ColumnInfo("uom", "varchar(140)", isNullable: true)]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("stock_uom", "varchar(140)", isNullable: true)]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("conversion_factor", "decimal(21,9)", isNullable: false)]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        [ColumnInfo("retain_sample", "int(1)", isNullable: false)]
        public bool RetainSample
        {
            get { return ERPNextConverter.IntToBool((int)data.retain_sample); }
            set { data.retain_sample = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("sample_quantity", "int(11)", isNullable: false)]
        public int SampleQuantity
        {
            get { return data.sample_quantity; }
            set { data.sample_quantity = value; }
        }

        [ColumnInfo("received_stock_qty", "decimal(21,9)", isNullable: false)]
        public decimal ReceivedStockQty
        {
            get { return data.received_stock_qty; }
            set { data.received_stock_qty = value; }
        }

        [ColumnInfo("stock_qty", "decimal(21,9)", isNullable: false)]
        public decimal StockQty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
        }

        [ColumnInfo("returned_qty", "decimal(21,9)", isNullable: false)]
        public decimal ReturnedQty
        {
            get { return data.returned_qty; }
            set { data.returned_qty = value; }
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

        [ColumnInfo("stock_uom_rate", "decimal(21,9)", isNullable: false)]
        public decimal StockUomRate
        {
            get { return data.stock_uom_rate; }
            set { data.stock_uom_rate = value; }
        }

        [ColumnInfo("is_free_item", "int(1)", isNullable: false)]
        public bool IsFreeItem
        {
            get { return ERPNextConverter.IntToBool((int)data.is_free_item); }
            set { data.is_free_item = ERPNextConverter.BoolToInt(value); }
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

        [ColumnInfo("item_tax_template", "varchar(140)", isNullable: true)]
        public string? ItemTaxTemplate
        {
            get { return data.item_tax_template; }
            set { data.item_tax_template = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("valuation_rate", "decimal(21,9)", isNullable: false)]
        public decimal ValuationRate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        [ColumnInfo("item_tax_amount", "decimal(21,9)", isNullable: false)]
        public decimal ItemTaxAmount
        {
            get { return data.item_tax_amount; }
            set { data.item_tax_amount = value; }
        }

        [ColumnInfo("rm_supp_cost", "decimal(21,9)", isNullable: false)]
        public decimal RmSuppCost
        {
            get { return data.rm_supp_cost; }
            set { data.rm_supp_cost = value; }
        }

        [ColumnInfo("landed_cost_voucher_amount", "decimal(21,9)", isNullable: false)]
        public decimal LandedCostVoucherAmount
        {
            get { return data.landed_cost_voucher_amount; }
            set { data.landed_cost_voucher_amount = value; }
        }

        [ColumnInfo("billed_amt", "decimal(21,9)", isNullable: false)]
        public decimal BilledAmt
        {
            get { return data.billed_amt; }
            set { data.billed_amt = value; }
        }

        [ColumnInfo("warehouse", "varchar(140)", isNullable: true)]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("rejected_warehouse", "varchar(140)", isNullable: true)]
        public string? RejectedWarehouse
        {
            get { return data.rejected_warehouse; }
            set { data.rejected_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("from_warehouse", "varchar(140)", isNullable: true)]
        public string? FromWarehouse
        {
            get { return data.from_warehouse; }
            set { data.from_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("material_request", "varchar(140)", isNullable: true)]
        public string? MaterialRequest
        {
            get { return data.material_request; }
            set { data.material_request = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("purchase_order", "varchar(140)", isNullable: true)]
        public string? PurchaseOrder
        {
            get { return data.purchase_order; }
            set { data.purchase_order = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("purchase_invoice", "varchar(140)", isNullable: true)]
        public string? PurchaseInvoice
        {
            get { return data.purchase_invoice; }
            set { data.purchase_invoice = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_fixed_asset", "int(1)", isNullable: false)]
        public bool IsFixedAsset
        {
            get { return ERPNextConverter.IntToBool((int)data.is_fixed_asset); }
            set { data.is_fixed_asset = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("asset_location", "varchar(140)", isNullable: true)]
        public string? AssetLocation
        {
            get { return data.asset_location; }
            set { data.asset_location = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("asset_category", "varchar(140)", isNullable: true)]
        public string? AssetCategory
        {
            get { return data.asset_category; }
            set { data.asset_category = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("schedule_date", "date", isNullable: true)]
        public DateOnly? ScheduleDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.schedule_date); }
            set { data.schedule_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("quality_inspection", "varchar(140)", isNullable: true)]
        public string? QualityInspection
        {
            get { return data.quality_inspection; }
            set { data.quality_inspection = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("material_request_item", "varchar(140)", isNullable: true)]
        public string? MaterialRequestItem
        {
            get { return data.material_request_item; }
            set { data.material_request_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("purchase_order_item", "varchar(140)", isNullable: true)]
        public string? PurchaseOrderItem
        {
            get { return data.purchase_order_item; }
            set { data.purchase_order_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("purchase_invoice_item", "varchar(140)", isNullable: true)]
        public string? PurchaseInvoiceItem
        {
            get { return data.purchase_invoice_item; }
            set { data.purchase_invoice_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("purchase_receipt_item", "varchar(140)", isNullable: true)]
        public string? PurchaseReceiptItem
        {
            get { return data.purchase_receipt_item; }
            set { data.purchase_receipt_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("delivery_note_item", "varchar(140)", isNullable: true)]
        public string? DeliveryNoteItem
        {
            get { return data.delivery_note_item; }
            set { data.delivery_note_item = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("putaway_rule", "varchar(140)", isNullable: true)]
        public string? PutawayRule
        {
            get { return data.putaway_rule; }
            set { data.putaway_rule = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("allow_zero_valuation_rate", "int(1)", isNullable: false)]
        public bool AllowZeroValuationRate
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_zero_valuation_rate); }
            set { data.allow_zero_valuation_rate = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("bom", "varchar(140)", isNullable: true)]
        public string? Bom
        {
            get { return data.bom; }
            set { data.bom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("serial_no", "text", isNullable: true)]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [ColumnInfo("include_exploded_items", "int(1)", isNullable: false)]
        public bool IncludeExplodedItems
        {
            get { return ERPNextConverter.IntToBool((int)data.include_exploded_items); }
            set { data.include_exploded_items = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("batch_no", "varchar(140)", isNullable: true)]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("rejected_serial_no", "text", isNullable: true)]
        public string? RejectedSerialNo
        {
            get { return data.rejected_serial_no; }
            set { data.rejected_serial_no = value; }
        }

        [ColumnInfo("item_tax_rate", "longtext", isNullable: true)]
        public string? ItemTaxRate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
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

        [ColumnInfo("expense_account", "varchar(140)", isNullable: true)]
        public string? ExpenseAccount
        {
            get { return data.expense_account; }
            set { data.expense_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("provisional_expense_account", "varchar(140)", isNullable: true)]
        public string? ProvisionalExpenseAccount
        {
            get { return data.provisional_expense_account; }
            set { data.provisional_expense_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("project", "varchar(140)", isNullable: true)]
        public string? Project
        {
            get { return data.project; }
            set { data.project = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
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

