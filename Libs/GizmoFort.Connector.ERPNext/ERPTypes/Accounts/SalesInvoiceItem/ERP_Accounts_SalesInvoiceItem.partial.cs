/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.SalesInvoiceItem
{
    public partial class ERP_Accounts_SalesInvoiceItem : ERPNextObjectBase
    {
        public ERP_Accounts_SalesInvoiceItem() : this(new ERPObject(_DockType.Accounts_SalesInvoiceItem)) { }
        public ERP_Accounts_SalesInvoiceItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_SalesInvoiceItem>(propertyName);
        }

        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTime? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTime? Modified
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

        [Column("barcode")]
        public string? Barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
        }

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("customer_item_code")]
        public string? CustomerItemCode
        {
            get { return data.customer_item_code; }
            set { data.customer_item_code = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("item_group")]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        [Column("brand")]
        public string? Brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        [Column("image")]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [Column("qty")]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [Column("stock_uom")]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        [Column("uom")]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        [Column("conversion_factor")]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        [Column("stock_qty")]
        public decimal StockQty
        {
            get { return data.stock_qty; }
            set { data.stock_qty = value; }
        }

        [Column("price_list_rate")]
        public decimal PriceListRate
        {
            get { return data.price_list_rate; }
            set { data.price_list_rate = value; }
        }

        [Column("base_price_list_rate")]
        public decimal BasePriceListRate
        {
            get { return data.base_price_list_rate; }
            set { data.base_price_list_rate = value; }
        }

        [Column("margin_type")]
        public string? MarginType
        {
            get { return data.margin_type; }
            set { data.margin_type = value; }
        }

        [Column("margin_rate_or_amount")]
        public decimal MarginRateOrAmount
        {
            get { return data.margin_rate_or_amount; }
            set { data.margin_rate_or_amount = value; }
        }

        [Column("rate_with_margin")]
        public decimal RateWithMargin
        {
            get { return data.rate_with_margin; }
            set { data.rate_with_margin = value; }
        }

        [Column("discount_percentage")]
        public decimal DiscountPercentage
        {
            get { return data.discount_percentage; }
            set { data.discount_percentage = value; }
        }

        [Column("discount_amount")]
        public decimal DiscountAmount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        [Column("base_rate_with_margin")]
        public decimal BaseRateWithMargin
        {
            get { return data.base_rate_with_margin; }
            set { data.base_rate_with_margin = value; }
        }

        [Column("rate")]
        public decimal Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [Column("amount")]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [Column("item_tax_template")]
        public string? ItemTaxTemplate
        {
            get { return data.item_tax_template; }
            set { data.item_tax_template = value; }
        }

        [Column("base_rate")]
        public decimal BaseRate
        {
            get { return data.base_rate; }
            set { data.base_rate = value; }
        }

        [Column("base_amount")]
        public decimal BaseAmount
        {
            get { return data.base_amount; }
            set { data.base_amount = value; }
        }

        [Column("pricing_rules")]
        public string? PricingRules
        {
            get { return data.pricing_rules; }
            set { data.pricing_rules = value; }
        }

        [Column("stock_uom_rate")]
        public decimal StockUomRate
        {
            get { return data.stock_uom_rate; }
            set { data.stock_uom_rate = value; }
        }

        [Column("is_free_item")]
        public int IsFreeItem
        {
            get { return data.is_free_item; }
            set { data.is_free_item = value; }
        }

        [Column("grant_commission")]
        public int GrantCommission
        {
            get { return data.grant_commission; }
            set { data.grant_commission = value; }
        }

        [Column("net_rate")]
        public decimal NetRate
        {
            get { return data.net_rate; }
            set { data.net_rate = value; }
        }

        [Column("net_amount")]
        public decimal NetAmount
        {
            get { return data.net_amount; }
            set { data.net_amount = value; }
        }

        [Column("base_net_rate")]
        public decimal BaseNetRate
        {
            get { return data.base_net_rate; }
            set { data.base_net_rate = value; }
        }

        [Column("base_net_amount")]
        public decimal BaseNetAmount
        {
            get { return data.base_net_amount; }
            set { data.base_net_amount = value; }
        }

        [Column("delivered_by_supplier")]
        public int DeliveredBySupplier
        {
            get { return data.delivered_by_supplier; }
            set { data.delivered_by_supplier = value; }
        }

        [Column("income_account")]
        public string? IncomeAccount
        {
            get { return data.income_account; }
            set { data.income_account = value; }
        }

        [Column("is_fixed_asset")]
        public int IsFixedAsset
        {
            get { return data.is_fixed_asset; }
            set { data.is_fixed_asset = value; }
        }

        [Column("asset")]
        public string? Asset
        {
            get { return data.asset; }
            set { data.asset = value; }
        }

        [Column("finance_book")]
        public string? FinanceBook
        {
            get { return data.finance_book; }
            set { data.finance_book = value; }
        }

        [Column("expense_account")]
        public string? ExpenseAccount
        {
            get { return data.expense_account; }
            set { data.expense_account = value; }
        }

        [Column("discount_account")]
        public string? DiscountAccount
        {
            get { return data.discount_account; }
            set { data.discount_account = value; }
        }

        [Column("deferred_revenue_account")]
        public string? DeferredRevenueAccount
        {
            get { return data.deferred_revenue_account; }
            set { data.deferred_revenue_account = value; }
        }

        [Column("service_stop_date")]
        public DateOnly? ServiceStopDate
        {
            get { return data.service_stop_date; }
            set { data.service_stop_date = value; }
        }

        [Column("enable_deferred_revenue")]
        public int EnableDeferredRevenue
        {
            get { return data.enable_deferred_revenue; }
            set { data.enable_deferred_revenue = value; }
        }

        [Column("service_start_date")]
        public DateOnly? ServiceStartDate
        {
            get { return data.service_start_date; }
            set { data.service_start_date = value; }
        }

        [Column("service_end_date")]
        public DateOnly? ServiceEndDate
        {
            get { return data.service_end_date; }
            set { data.service_end_date = value; }
        }

        [Column("weight_per_unit")]
        public decimal WeightPerUnit
        {
            get { return data.weight_per_unit; }
            set { data.weight_per_unit = value; }
        }

        [Column("total_weight")]
        public decimal TotalWeight
        {
            get { return data.total_weight; }
            set { data.total_weight = value; }
        }

        [Column("weight_uom")]
        public string? WeightUom
        {
            get { return data.weight_uom; }
            set { data.weight_uom = value; }
        }

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("target_warehouse")]
        public string? TargetWarehouse
        {
            get { return data.target_warehouse; }
            set { data.target_warehouse = value; }
        }

        [Column("quality_inspection")]
        public string? QualityInspection
        {
            get { return data.quality_inspection; }
            set { data.quality_inspection = value; }
        }

        [Column("batch_no")]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        [Column("incoming_rate")]
        public decimal IncomingRate
        {
            get { return data.incoming_rate; }
            set { data.incoming_rate = value; }
        }

        [Column("allow_zero_valuation_rate")]
        public int AllowZeroValuationRate
        {
            get { return data.allow_zero_valuation_rate; }
            set { data.allow_zero_valuation_rate = value; }
        }

        [Column("serial_no")]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [Column("item_tax_rate")]
        public string? ItemTaxRate
        {
            get { return data.item_tax_rate; }
            set { data.item_tax_rate = value; }
        }

        [Column("actual_batch_qty")]
        public decimal ActualBatchQty
        {
            get { return data.actual_batch_qty; }
            set { data.actual_batch_qty = value; }
        }

        [Column("actual_qty")]
        public decimal ActualQty
        {
            get { return data.actual_qty; }
            set { data.actual_qty = value; }
        }

        [Column("sales_order")]
        public string? SalesOrder
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        [Column("so_detail")]
        public string? SoDetail
        {
            get { return data.so_detail; }
            set { data.so_detail = value; }
        }

        [Column("sales_invoice_item")]
        public string? SalesInvoiceItem
        {
            get { return data.sales_invoice_item; }
            set { data.sales_invoice_item = value; }
        }

        [Column("delivery_note")]
        public string? DeliveryNote
        {
            get { return data.delivery_note; }
            set { data.delivery_note = value; }
        }

        [Column("dn_detail")]
        public string? DnDetail
        {
            get { return data.dn_detail; }
            set { data.dn_detail = value; }
        }

        [Column("delivered_qty")]
        public decimal DeliveredQty
        {
            get { return data.delivered_qty; }
            set { data.delivered_qty = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("page_break")]
        public int PageBreak
        {
            get { return data.page_break; }
            set { data.page_break = value; }
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

