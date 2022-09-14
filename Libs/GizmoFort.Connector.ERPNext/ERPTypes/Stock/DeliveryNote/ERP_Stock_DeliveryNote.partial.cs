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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.DeliveryNote
{
    public partial class ERP_Stock_DeliveryNote : ERPNextObjectBase
    {
        public ERP_Stock_DeliveryNote() : this(new ERPObject(_DocType.Stock_DeliveryNote)) { }
        public ERP_Stock_DeliveryNote(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Stock_DeliveryNote>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Stock_DeliveryNote>(columnName);
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

        [ColumnInfo("title", "varchar(140)", isNullable: true)]
        public string? Title
        {
            get { return data.title; }
            set { data.title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_name", "varchar(140)", isNullable: true)]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("posting_date", "date", isNullable: true)]
        public DateOnly? PostingDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.posting_date); }
            set { data.posting_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("posting_time", "time(6)", isNullable: true)]
        public TimeSpan? PostingTime
        {
            get { return ERPNextConverter.StringToTimeSpan(data.posting_time); }
            set { data.posting_time = ERPNextConverter.TimeSpanToString(value, 6); }
        }

        [ColumnInfo("set_posting_time", "int(1)", isNullable: false)]
        public bool SetPostingTime
        {
            get { return ERPNextConverter.IntToBool((int)data.set_posting_time); }
            set { data.set_posting_time = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_return", "int(1)", isNullable: false)]
        public bool IsReturn
        {
            get { return ERPNextConverter.IntToBool((int)data.is_return); }
            set { data.is_return = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("issue_credit_note", "int(1)", isNullable: false)]
        public bool IssueCreditNote
        {
            get { return ERPNextConverter.IntToBool((int)data.issue_credit_note); }
            set { data.issue_credit_note = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("return_against", "varchar(140)", isNullable: true)]
        public string? ReturnAgainst
        {
            get { return data.return_against; }
            set { data.return_against = ERPNextConverter.TruncateString(value, 140); }
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

        [ColumnInfo("po_no", "text", isNullable: true)]
        public string? PoNo
        {
            get { return data.po_no; }
            set { data.po_no = value; }
        }

        [ColumnInfo("po_date", "date", isNullable: true)]
        public DateOnly? PoDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.po_date); }
            set { data.po_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("pick_list", "varchar(140)", isNullable: true)]
        public string? PickList
        {
            get { return data.pick_list; }
            set { data.pick_list = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("shipping_address_name", "varchar(140)", isNullable: true)]
        public string? ShippingAddressName
        {
            get { return data.shipping_address_name; }
            set { data.shipping_address_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("shipping_address", "text", isNullable: true)]
        public string? ShippingAddress
        {
            get { return data.shipping_address; }
            set { data.shipping_address = value; }
        }

        [ColumnInfo("dispatch_address_name", "varchar(140)", isNullable: true)]
        public string? DispatchAddressName
        {
            get { return data.dispatch_address_name; }
            set { data.dispatch_address_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("dispatch_address", "text", isNullable: true)]
        public string? DispatchAddress
        {
            get { return data.dispatch_address; }
            set { data.dispatch_address = value; }
        }

        [ColumnInfo("contact_person", "varchar(140)", isNullable: true)]
        public string? ContactPerson
        {
            get { return data.contact_person; }
            set { data.contact_person = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("contact_display", "text", isNullable: true)]
        public string? ContactDisplay
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        [ColumnInfo("contact_mobile", "text", isNullable: true)]
        public string? ContactMobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        [ColumnInfo("contact_email", "varchar(140)", isNullable: true)]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_address", "varchar(140)", isNullable: true)]
        public string? CustomerAddress
        {
            get { return data.customer_address; }
            set { data.customer_address = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("tax_id", "varchar(140)", isNullable: true)]
        public string? TaxId
        {
            get { return data.tax_id; }
            set { data.tax_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("address_display", "text", isNullable: true)]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [ColumnInfo("company_address", "varchar(140)", isNullable: true)]
        public string? CompanyAddress
        {
            get { return data.company_address; }
            set { data.company_address = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company_address_display", "text", isNullable: true)]
        public string? CompanyAddressDisplay
        {
            get { return data.company_address_display; }
            set { data.company_address_display = value; }
        }

        [ColumnInfo("currency", "varchar(140)", isNullable: true)]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("conversion_rate", "decimal(21,9)", isNullable: false)]
        public decimal ConversionRate
        {
            get { return data.conversion_rate; }
            set { data.conversion_rate = value; }
        }

        [ColumnInfo("selling_price_list", "varchar(140)", isNullable: true)]
        public string? SellingPriceList
        {
            get { return data.selling_price_list; }
            set { data.selling_price_list = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("price_list_currency", "varchar(140)", isNullable: true)]
        public string? PriceListCurrency
        {
            get { return data.price_list_currency; }
            set { data.price_list_currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("plc_conversion_rate", "decimal(21,9)", isNullable: false)]
        public decimal PlcConversionRate
        {
            get { return data.plc_conversion_rate; }
            set { data.plc_conversion_rate = value; }
        }

        [ColumnInfo("ignore_pricing_rule", "int(1)", isNullable: false)]
        public bool IgnorePricingRule
        {
            get { return ERPNextConverter.IntToBool((int)data.ignore_pricing_rule); }
            set { data.ignore_pricing_rule = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("set_warehouse", "varchar(140)", isNullable: true)]
        public string? SetWarehouse
        {
            get { return data.set_warehouse; }
            set { data.set_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("set_target_warehouse", "varchar(140)", isNullable: true)]
        public string? SetTargetWarehouse
        {
            get { return data.set_target_warehouse; }
            set { data.set_target_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("scan_barcode", "varchar(140)", isNullable: true)]
        public string? ScanBarcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("total_qty", "decimal(21,9)", isNullable: false)]
        public decimal TotalQty
        {
            get { return data.total_qty; }
            set { data.total_qty = value; }
        }

        [ColumnInfo("base_total", "decimal(21,9)", isNullable: false)]
        public decimal BaseTotal
        {
            get { return data.base_total; }
            set { data.base_total = value; }
        }

        [ColumnInfo("base_net_total", "decimal(21,9)", isNullable: false)]
        public decimal BaseNetTotal
        {
            get { return data.base_net_total; }
            set { data.base_net_total = value; }
        }

        [ColumnInfo("total_net_weight", "decimal(21,9)", isNullable: false)]
        public decimal TotalNetWeight
        {
            get { return data.total_net_weight; }
            set { data.total_net_weight = value; }
        }

        [ColumnInfo("total", "decimal(21,9)", isNullable: false)]
        public decimal Total
        {
            get { return data.total; }
            set { data.total = value; }
        }

        [ColumnInfo("net_total", "decimal(21,9)", isNullable: false)]
        public decimal NetTotal
        {
            get { return data.net_total; }
            set { data.net_total = value; }
        }

        [ColumnInfo("tax_category", "varchar(140)", isNullable: true)]
        public string? TaxCategory
        {
            get { return data.tax_category; }
            set { data.tax_category = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("shipping_rule", "varchar(140)", isNullable: true)]
        public string? ShippingRule
        {
            get { return data.shipping_rule; }
            set { data.shipping_rule = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("taxes_and_charges", "varchar(140)", isNullable: true)]
        public string? TaxesAndCharges
        {
            get { return data.taxes_and_charges; }
            set { data.taxes_and_charges = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("other_charges_calculation", "longtext", isNullable: true)]
        public string? OtherChargesCalculation
        {
            get { return data.other_charges_calculation; }
            set { data.other_charges_calculation = value; }
        }

        [ColumnInfo("base_total_taxes_and_charges", "decimal(21,9)", isNullable: false)]
        public decimal BaseTotalTaxesAndCharges
        {
            get { return data.base_total_taxes_and_charges; }
            set { data.base_total_taxes_and_charges = value; }
        }

        [ColumnInfo("total_taxes_and_charges", "decimal(21,9)", isNullable: false)]
        public decimal TotalTaxesAndCharges
        {
            get { return data.total_taxes_and_charges; }
            set { data.total_taxes_and_charges = value; }
        }

        [ColumnInfo("apply_discount_on", "varchar(140)", isNullable: true)]
        public string? ApplyDiscountOn
        {
            get { return data.apply_discount_on; }
            set { data.apply_discount_on = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("base_discount_amount", "decimal(21,9)", isNullable: false)]
        public decimal BaseDiscountAmount
        {
            get { return data.base_discount_amount; }
            set { data.base_discount_amount = value; }
        }

        [ColumnInfo("additional_discount_percentage", "decimal(21,9)", isNullable: false)]
        public decimal AdditionalDiscountPercentage
        {
            get { return data.additional_discount_percentage; }
            set { data.additional_discount_percentage = value; }
        }

        [ColumnInfo("discount_amount", "decimal(21,9)", isNullable: false)]
        public decimal DiscountAmount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        [ColumnInfo("base_grand_total", "decimal(21,9)", isNullable: false)]
        public decimal BaseGrandTotal
        {
            get { return data.base_grand_total; }
            set { data.base_grand_total = value; }
        }

        [ColumnInfo("base_rounding_adjustment", "decimal(21,9)", isNullable: false)]
        public decimal BaseRoundingAdjustment
        {
            get { return data.base_rounding_adjustment; }
            set { data.base_rounding_adjustment = value; }
        }

        [ColumnInfo("base_rounded_total", "decimal(21,9)", isNullable: false)]
        public decimal BaseRoundedTotal
        {
            get { return data.base_rounded_total; }
            set { data.base_rounded_total = value; }
        }

        [ColumnInfo("base_in_words", "varchar(240)", isNullable: true)]
        public string? BaseInWords
        {
            get { return data.base_in_words; }
            set { data.base_in_words = ERPNextConverter.TruncateString(value, 240); }
        }

        [ColumnInfo("grand_total", "decimal(21,9)", isNullable: false)]
        public decimal GrandTotal
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }

        [ColumnInfo("rounding_adjustment", "decimal(21,9)", isNullable: false)]
        public decimal RoundingAdjustment
        {
            get { return data.rounding_adjustment; }
            set { data.rounding_adjustment = value; }
        }

        [ColumnInfo("rounded_total", "decimal(21,9)", isNullable: false)]
        public decimal RoundedTotal
        {
            get { return data.rounded_total; }
            set { data.rounded_total = value; }
        }

        [ColumnInfo("in_words", "varchar(240)", isNullable: true)]
        public string? InWords
        {
            get { return data.in_words; }
            set { data.in_words = ERPNextConverter.TruncateString(value, 240); }
        }

        [ColumnInfo("disable_rounded_total", "int(1)", isNullable: false)]
        public bool DisableRoundedTotal
        {
            get { return ERPNextConverter.IntToBool((int)data.disable_rounded_total); }
            set { data.disable_rounded_total = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("tc_name", "varchar(140)", isNullable: true)]
        public string? TcName
        {
            get { return data.tc_name; }
            set { data.tc_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("terms", "longtext", isNullable: true)]
        public string? Terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        [ColumnInfo("transporter", "varchar(140)", isNullable: true)]
        public string? Transporter
        {
            get { return data.transporter; }
            set { data.transporter = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("driver", "varchar(140)", isNullable: true)]
        public string? Driver
        {
            get { return data.driver; }
            set { data.driver = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lr_no", "varchar(140)", isNullable: true)]
        public string? LrNo
        {
            get { return data.lr_no; }
            set { data.lr_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("vehicle_no", "varchar(140)", isNullable: true)]
        public string? VehicleNo
        {
            get { return data.vehicle_no; }
            set { data.vehicle_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("transporter_name", "varchar(140)", isNullable: true)]
        public string? TransporterName
        {
            get { return data.transporter_name; }
            set { data.transporter_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("driver_name", "varchar(140)", isNullable: true)]
        public string? DriverName
        {
            get { return data.driver_name; }
            set { data.driver_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lr_date", "date", isNullable: true)]
        public DateOnly? LrDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.lr_date); }
            set { data.lr_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("campaign", "varchar(140)", isNullable: true)]
        public string? Campaign
        {
            get { return data.campaign; }
            set { data.campaign = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("source", "varchar(140)", isNullable: true)]
        public string? Source
        {
            get { return data.source; }
            set { data.source = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_internal_customer", "int(1)", isNullable: false)]
        public bool IsInternalCustomer
        {
            get { return ERPNextConverter.IntToBool((int)data.is_internal_customer); }
            set { data.is_internal_customer = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("represents_company", "varchar(140)", isNullable: true)]
        public string? RepresentsCompany
        {
            get { return data.represents_company; }
            set { data.represents_company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("inter_company_reference", "varchar(140)", isNullable: true)]
        public string? InterCompanyReference
        {
            get { return data.inter_company_reference; }
            set { data.inter_company_reference = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("per_billed", "decimal(21,9)", isNullable: false)]
        public decimal PerBilled
        {
            get { return data.per_billed; }
            set { data.per_billed = value; }
        }

        [ColumnInfo("customer_group", "varchar(140)", isNullable: true)]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("territory", "varchar(140)", isNullable: true)]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("letter_head", "varchar(140)", isNullable: true)]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("select_print_heading", "varchar(140)", isNullable: true)]
        public string? SelectPrintHeading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("language", "varchar(140)", isNullable: true)]
        public string? Language
        {
            get { return data.language; }
            set { data.language = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("print_without_amount", "int(1)", isNullable: false)]
        public bool PrintWithoutAmount
        {
            get { return ERPNextConverter.IntToBool((int)data.print_without_amount); }
            set { data.print_without_amount = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("group_same_items", "int(1)", isNullable: false)]
        public bool GroupSameItems
        {
            get { return ERPNextConverter.IntToBool((int)data.group_same_items); }
            set { data.group_same_items = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("per_installed", "decimal(21,9)", isNullable: false)]
        public decimal PerInstalled
        {
            get { return data.per_installed; }
            set { data.per_installed = value; }
        }

        [ColumnInfo("installation_status", "varchar(140)", isNullable: true)]
        public string? InstallationStatus
        {
            get { return data.installation_status; }
            set { data.installation_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("per_returned", "decimal(21,9)", isNullable: false)]
        public decimal PerReturned
        {
            get { return data.per_returned; }
            set { data.per_returned = value; }
        }

        [ColumnInfo("excise_page", "varchar(140)", isNullable: true)]
        public string? ExcisePage
        {
            get { return data.excise_page; }
            set { data.excise_page = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("instructions", "text", isNullable: true)]
        public string? Instructions
        {
            get { return data.instructions; }
            set { data.instructions = value; }
        }

        [ColumnInfo("auto_repeat", "varchar(140)", isNullable: true)]
        public string? AutoRepeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sales_partner", "varchar(140)", isNullable: true)]
        public string? SalesPartner
        {
            get { return data.sales_partner; }
            set { data.sales_partner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amount_eligible_for_commission", "decimal(21,9)", isNullable: false)]
        public decimal AmountEligibleForCommission
        {
            get { return data.amount_eligible_for_commission; }
            set { data.amount_eligible_for_commission = value; }
        }

        [ColumnInfo("commission_rate", "decimal(21,9)", isNullable: false)]
        public decimal CommissionRate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = value; }
        }

        [ColumnInfo("total_commission", "decimal(21,9)", isNullable: false)]
        public decimal TotalCommission
        {
            get { return data.total_commission; }
            set { data.total_commission = value; }
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

        [ColumnInfo("_seen", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}

