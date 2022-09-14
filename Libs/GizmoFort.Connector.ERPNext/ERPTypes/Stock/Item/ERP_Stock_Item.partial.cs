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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.Item
{
    public partial class ERP_Stock_Item : ERPNextObjectBase
    {
        public ERP_Stock_Item() : this(new ERPObject(_DocType.Stock_Item)) { }
        public ERP_Stock_Item(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Stock_Item>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Stock_Item>(columnName);
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

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("item_group", "varchar(140)", isNullable: true)]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("stock_uom", "varchar(140)", isNullable: true)]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("disabled", "int(1)", isNullable: false)]
        public bool Disabled
        {
            get { return ERPNextConverter.IntToBool((int)data.disabled); }
            set { data.disabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("allow_alternative_item", "int(1)", isNullable: false)]
        public bool AllowAlternativeItem
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_alternative_item); }
            set { data.allow_alternative_item = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_stock_item", "int(1)", isNullable: false)]
        public bool IsStockItem
        {
            get { return ERPNextConverter.IntToBool((int)data.is_stock_item); }
            set { data.is_stock_item = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("has_variants", "int(1)", isNullable: false)]
        public bool HasVariants
        {
            get { return ERPNextConverter.IntToBool((int)data.has_variants); }
            set { data.has_variants = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("include_item_in_manufacturing", "int(1)", isNullable: false)]
        public bool IncludeItemInManufacturing
        {
            get { return ERPNextConverter.IntToBool((int)data.include_item_in_manufacturing); }
            set { data.include_item_in_manufacturing = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("opening_stock", "decimal(21,9)", isNullable: false)]
        public decimal OpeningStock
        {
            get { return data.opening_stock; }
            set { data.opening_stock = value; }
        }

        [ColumnInfo("valuation_rate", "decimal(21,9)", isNullable: false)]
        public decimal ValuationRate
        {
            get { return data.valuation_rate; }
            set { data.valuation_rate = value; }
        }

        [ColumnInfo("standard_rate", "decimal(21,9)", isNullable: false)]
        public decimal StandardRate
        {
            get { return data.standard_rate; }
            set { data.standard_rate = value; }
        }

        [ColumnInfo("is_fixed_asset", "int(1)", isNullable: false)]
        public bool IsFixedAsset
        {
            get { return ERPNextConverter.IntToBool((int)data.is_fixed_asset); }
            set { data.is_fixed_asset = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("auto_create_assets", "int(1)", isNullable: false)]
        public bool AutoCreateAssets
        {
            get { return ERPNextConverter.IntToBool((int)data.auto_create_assets); }
            set { data.auto_create_assets = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_grouped_asset", "int(1)", isNullable: false)]
        public bool IsGroupedAsset
        {
            get { return ERPNextConverter.IntToBool((int)data.is_grouped_asset); }
            set { data.is_grouped_asset = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("asset_category", "varchar(140)", isNullable: true)]
        public string? AssetCategory
        {
            get { return data.asset_category; }
            set { data.asset_category = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("asset_naming_series", "varchar(140)", isNullable: true)]
        public string? AssetNamingSeries
        {
            get { return data.asset_naming_series; }
            set { data.asset_naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("over_delivery_receipt_allowance", "decimal(21,9)", isNullable: false)]
        public decimal OverDeliveryReceiptAllowance
        {
            get { return data.over_delivery_receipt_allowance; }
            set { data.over_delivery_receipt_allowance = value; }
        }

        [ColumnInfo("over_billing_allowance", "decimal(21,9)", isNullable: false)]
        public decimal OverBillingAllowance
        {
            get { return data.over_billing_allowance; }
            set { data.over_billing_allowance = value; }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
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

        [ColumnInfo("shelf_life_in_days", "int(11)", isNullable: false)]
        public int ShelfLifeInDays
        {
            get { return data.shelf_life_in_days; }
            set { data.shelf_life_in_days = value; }
        }

        [ColumnInfo("end_of_life", "date", isNullable: true)]
        public DateOnly? EndOfLife
        {
            get { return ERPNextConverter.StringToDateOnly(data.end_of_life); }
            set { data.end_of_life = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("default_material_request_type", "varchar(140)", isNullable: true)]
        public string? DefaultMaterialRequestType
        {
            get { return data.default_material_request_type; }
            set { data.default_material_request_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("valuation_method", "varchar(140)", isNullable: true)]
        public string? ValuationMethod
        {
            get { return data.valuation_method; }
            set { data.valuation_method = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("warranty_period", "varchar(140)", isNullable: true)]
        public string? WarrantyPeriod
        {
            get { return data.warranty_period; }
            set { data.warranty_period = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("weight_per_unit", "decimal(21,9)", isNullable: false)]
        public decimal WeightPerUnit
        {
            get { return data.weight_per_unit; }
            set { data.weight_per_unit = value; }
        }

        [ColumnInfo("weight_uom", "varchar(140)", isNullable: true)]
        public string? WeightUom
        {
            get { return data.weight_uom; }
            set { data.weight_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("allow_negative_stock", "int(1)", isNullable: false)]
        public bool AllowNegativeStock
        {
            get { return ERPNextConverter.IntToBool((int)data.allow_negative_stock); }
            set { data.allow_negative_stock = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("has_batch_no", "int(1)", isNullable: false)]
        public bool HasBatchNo
        {
            get { return ERPNextConverter.IntToBool((int)data.has_batch_no); }
            set { data.has_batch_no = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("create_new_batch", "int(1)", isNullable: false)]
        public bool CreateNewBatch
        {
            get { return ERPNextConverter.IntToBool((int)data.create_new_batch); }
            set { data.create_new_batch = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("batch_number_series", "varchar(140)", isNullable: true)]
        public string? BatchNumberSeries
        {
            get { return data.batch_number_series; }
            set { data.batch_number_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("has_expiry_date", "int(1)", isNullable: false)]
        public bool HasExpiryDate
        {
            get { return ERPNextConverter.IntToBool((int)data.has_expiry_date); }
            set { data.has_expiry_date = ERPNextConverter.BoolToInt(value); }
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

        [ColumnInfo("has_serial_no", "int(1)", isNullable: false)]
        public bool HasSerialNo
        {
            get { return ERPNextConverter.IntToBool((int)data.has_serial_no); }
            set { data.has_serial_no = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("serial_no_series", "varchar(140)", isNullable: true)]
        public string? SerialNoSeries
        {
            get { return data.serial_no_series; }
            set { data.serial_no_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("variant_of", "varchar(140)", isNullable: true)]
        public string? VariantOf
        {
            get { return data.variant_of; }
            set { data.variant_of = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("variant_based_on", "varchar(140)", isNullable: true)]
        public string? VariantBasedOn
        {
            get { return data.variant_based_on; }
            set { data.variant_based_on = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("purchase_uom", "varchar(140)", isNullable: true)]
        public string? PurchaseUom
        {
            get { return data.purchase_uom; }
            set { data.purchase_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("min_order_qty", "decimal(21,9)", isNullable: false)]
        public decimal MinOrderQty
        {
            get { return data.min_order_qty; }
            set { data.min_order_qty = value; }
        }

        [ColumnInfo("safety_stock", "decimal(21,9)", isNullable: false)]
        public decimal SafetyStock
        {
            get { return data.safety_stock; }
            set { data.safety_stock = value; }
        }

        [ColumnInfo("is_purchase_item", "int(1)", isNullable: false)]
        public bool IsPurchaseItem
        {
            get { return ERPNextConverter.IntToBool((int)data.is_purchase_item); }
            set { data.is_purchase_item = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("lead_time_days", "int(11)", isNullable: false)]
        public int LeadTimeDays
        {
            get { return data.lead_time_days; }
            set { data.lead_time_days = value; }
        }

        [ColumnInfo("last_purchase_rate", "decimal(21,9)", isNullable: false)]
        public decimal LastPurchaseRate
        {
            get { return data.last_purchase_rate; }
            set { data.last_purchase_rate = value; }
        }

        [ColumnInfo("is_customer_provided_item", "int(1)", isNullable: false)]
        public bool IsCustomerProvidedItem
        {
            get { return ERPNextConverter.IntToBool((int)data.is_customer_provided_item); }
            set { data.is_customer_provided_item = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("delivered_by_supplier", "int(1)", isNullable: false)]
        public bool DeliveredBySupplier
        {
            get { return ERPNextConverter.IntToBool((int)data.delivered_by_supplier); }
            set { data.delivered_by_supplier = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("enable_deferred_expense", "int(1)", isNullable: false)]
        public bool EnableDeferredExpense
        {
            get { return ERPNextConverter.IntToBool((int)data.enable_deferred_expense); }
            set { data.enable_deferred_expense = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("deferred_expense_account", "varchar(140)", isNullable: true)]
        public string? DeferredExpenseAccount
        {
            get { return data.deferred_expense_account; }
            set { data.deferred_expense_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("no_of_months_exp", "int(11)", isNullable: false)]
        public int NoOfMonthsExp
        {
            get { return data.no_of_months_exp; }
            set { data.no_of_months_exp = value; }
        }

        [ColumnInfo("country_of_origin", "varchar(140)", isNullable: true)]
        public string? CountryOfOrigin
        {
            get { return data.country_of_origin; }
            set { data.country_of_origin = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customs_tariff_number", "varchar(140)", isNullable: true)]
        public string? CustomsTariffNumber
        {
            get { return data.customs_tariff_number; }
            set { data.customs_tariff_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sales_uom", "varchar(140)", isNullable: true)]
        public string? SalesUom
        {
            get { return data.sales_uom; }
            set { data.sales_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("grant_commission", "int(1)", isNullable: false)]
        public bool GrantCommission
        {
            get { return ERPNextConverter.IntToBool((int)data.grant_commission); }
            set { data.grant_commission = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_sales_item", "int(1)", isNullable: false)]
        public bool IsSalesItem
        {
            get { return ERPNextConverter.IntToBool((int)data.is_sales_item); }
            set { data.is_sales_item = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("max_discount", "decimal(21,9)", isNullable: false)]
        public decimal MaxDiscount
        {
            get { return data.max_discount; }
            set { data.max_discount = value; }
        }

        [ColumnInfo("enable_deferred_revenue", "int(1)", isNullable: false)]
        public bool EnableDeferredRevenue
        {
            get { return ERPNextConverter.IntToBool((int)data.enable_deferred_revenue); }
            set { data.enable_deferred_revenue = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("deferred_revenue_account", "varchar(140)", isNullable: true)]
        public string? DeferredRevenueAccount
        {
            get { return data.deferred_revenue_account; }
            set { data.deferred_revenue_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("no_of_months", "int(11)", isNullable: false)]
        public int NoOfMonths
        {
            get { return data.no_of_months; }
            set { data.no_of_months = value; }
        }

        [ColumnInfo("inspection_required_before_purchase", "int(1)", isNullable: false)]
        public bool InspectionRequiredBeforePurchase
        {
            get { return ERPNextConverter.IntToBool((int)data.inspection_required_before_purchase); }
            set { data.inspection_required_before_purchase = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("quality_inspection_template", "varchar(140)", isNullable: true)]
        public string? QualityInspectionTemplate
        {
            get { return data.quality_inspection_template; }
            set { data.quality_inspection_template = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("inspection_required_before_delivery", "int(1)", isNullable: false)]
        public bool InspectionRequiredBeforeDelivery
        {
            get { return ERPNextConverter.IntToBool((int)data.inspection_required_before_delivery); }
            set { data.inspection_required_before_delivery = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_sub_contracted_item", "int(1)", isNullable: false)]
        public bool IsSubContractedItem
        {
            get { return ERPNextConverter.IntToBool((int)data.is_sub_contracted_item); }
            set { data.is_sub_contracted_item = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("default_bom", "varchar(140)", isNullable: true)]
        public string? DefaultBom
        {
            get { return data.default_bom; }
            set { data.default_bom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_code", "varchar(140)", isNullable: true)]
        public string? CustomerCode
        {
            get { return data.customer_code; }
            set { data.customer_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("default_item_manufacturer", "varchar(140)", isNullable: true)]
        public string? DefaultItemManufacturer
        {
            get { return data.default_item_manufacturer; }
            set { data.default_item_manufacturer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("default_manufacturer_part_no", "varchar(140)", isNullable: true)]
        public string? DefaultManufacturerPartNo
        {
            get { return data.default_manufacturer_part_no; }
            set { data.default_manufacturer_part_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("published_in_website", "int(1)", isNullable: false)]
        public bool PublishedInWebsite
        {
            get { return ERPNextConverter.IntToBool((int)data.published_in_website); }
            set { data.published_in_website = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("total_projected_qty", "decimal(21,9)", isNullable: false)]
        public decimal TotalProjectedQty
        {
            get { return data.total_projected_qty; }
            set { data.total_projected_qty = value; }
        }

        [ColumnInfo("_user_tags", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [ColumnInfo("_comments", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [ColumnInfo("_assign", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [ColumnInfo("_liked_by", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

