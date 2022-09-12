/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/11/2022 7:52:10 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.SalesInvoice
{
    public partial class ERP_Accounts_SalesInvoice : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Accounts_SalesInvoice() : this(new ERPObject(_DockType.Accounts_SalesInvoice)) { }
        public ERP_Accounts_SalesInvoice(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_SalesInvoice>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_SalesInvoice>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Accounts_SalesInvoice>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Accounts_SalesInvoice? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Accounts_SalesInvoice>(json: json);
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

        [Column("title")]
        public string? Title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("customer_name")]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        [Column("tax_id")]
        public string? TaxId
        {
            get { return data.tax_id; }
            set { data.tax_id = value; }
        }

        [Column("pos_profile")]
        public string? PosProfile
        {
            get { return data.pos_profile; }
            set { data.pos_profile = value; }
        }

        [Column("is_pos")]
        public int IsPos
        {
            get { return data.is_pos; }
            set { data.is_pos = value; }
        }

        [Column("is_consolidated")]
        public int IsConsolidated
        {
            get { return data.is_consolidated; }
            set { data.is_consolidated = value; }
        }

        [Column("is_return")]
        public int IsReturn
        {
            get { return data.is_return; }
            set { data.is_return = value; }
        }

        [Column("is_debit_note")]
        public int IsDebitNote
        {
            get { return data.is_debit_note; }
            set { data.is_debit_note = value; }
        }

        [Column("update_billed_amount_in_sales_order")]
        public int UpdateBilledAmountInSalesOrder
        {
            get { return data.update_billed_amount_in_sales_order; }
            set { data.update_billed_amount_in_sales_order = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("company_tax_id")]
        public string? CompanyTaxId
        {
            get { return data.company_tax_id; }
            set { data.company_tax_id = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("posting_time")]
        public TimeSpan? PostingTime
        {
            get { return data.posting_time; }
            set { data.posting_time = value; }
        }

        [Column("set_posting_time")]
        public int SetPostingTime
        {
            get { return data.set_posting_time; }
            set { data.set_posting_time = value; }
        }

        [Column("due_date")]
        public DateOnly? DueDate
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        [Column("return_against")]
        public string? ReturnAgainst
        {
            get { return data.return_against; }
            set { data.return_against = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("po_no")]
        public string? PoNo
        {
            get { return data.po_no; }
            set { data.po_no = value; }
        }

        [Column("po_date")]
        public DateOnly? PoDate
        {
            get { return data.po_date; }
            set { data.po_date = value; }
        }

        [Column("customer_address")]
        public string? CustomerAddress
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        [Column("address_display")]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [Column("contact_person")]
        public string? ContactPerson
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        [Column("contact_display")]
        public string? ContactDisplay
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        [Column("contact_mobile")]
        public string? ContactMobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        [Column("contact_email")]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        [Column("territory")]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        [Column("shipping_address_name")]
        public string? ShippingAddressName
        {
            get { return data.shipping_address_name; }
            set { data.shipping_address_name = value; }
        }

        [Column("shipping_address")]
        public string? ShippingAddress
        {
            get { return data.shipping_address; }
            set { data.shipping_address = value; }
        }

        [Column("company_address")]
        public string? CompanyAddress
        {
            get { return data.company_address; }
            set { data.company_address = value; }
        }

        [Column("company_address_display")]
        public string? CompanyAddressDisplay
        {
            get { return data.company_address_display; }
            set { data.company_address_display = value; }
        }

        [Column("dispatch_address_name")]
        public string? DispatchAddressName
        {
            get { return data.dispatch_address_name; }
            set { data.dispatch_address_name = value; }
        }

        [Column("dispatch_address")]
        public string? DispatchAddress
        {
            get { return data.dispatch_address; }
            set { data.dispatch_address = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        [Column("conversion_rate")]
        public decimal ConversionRate
        {
            get { return data.conversion_rate; }
            set { data.conversion_rate = value; }
        }

        [Column("selling_price_list")]
        public string? SellingPriceList
        {
            get { return data.selling_price_list; }
            set { data.selling_price_list = value; }
        }

        [Column("price_list_currency")]
        public string? PriceListCurrency
        {
            get { return data.price_list_currency; }
            set { data.price_list_currency = value; }
        }

        [Column("plc_conversion_rate")]
        public decimal PlcConversionRate
        {
            get { return data.plc_conversion_rate; }
            set { data.plc_conversion_rate = value; }
        }

        [Column("ignore_pricing_rule")]
        public int IgnorePricingRule
        {
            get { return data.ignore_pricing_rule; }
            set { data.ignore_pricing_rule = value; }
        }

        [Column("set_warehouse")]
        public string? SetWarehouse
        {
            get { return data.set_warehouse; }
            set { data.set_warehouse = value; }
        }

        [Column("set_target_warehouse")]
        public string? SetTargetWarehouse
        {
            get { return data.set_target_warehouse; }
            set { data.set_target_warehouse = value; }
        }

        [Column("update_stock")]
        public int UpdateStock
        {
            get { return data.update_stock; }
            set { data.update_stock = value; }
        }

        [Column("scan_barcode")]
        public string? ScanBarcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = value; }
        }

        [Column("total_billing_amount")]
        public decimal TotalBillingAmount
        {
            get { return data.total_billing_amount; }
            set { data.total_billing_amount = value; }
        }

        [Column("total_billing_hours")]
        public decimal TotalBillingHours
        {
            get { return data.total_billing_hours; }
            set { data.total_billing_hours = value; }
        }

        [Column("total_qty")]
        public decimal TotalQty
        {
            get { return data.total_qty; }
            set { data.total_qty = value; }
        }

        [Column("base_total")]
        public decimal BaseTotal
        {
            get { return data.base_total; }
            set { data.base_total = value; }
        }

        [Column("base_net_total")]
        public decimal BaseNetTotal
        {
            get { return data.base_net_total; }
            set { data.base_net_total = value; }
        }

        [Column("total_net_weight")]
        public decimal TotalNetWeight
        {
            get { return data.total_net_weight; }
            set { data.total_net_weight = value; }
        }

        [Column("total")]
        public decimal Total
        {
            get { return data.total; }
            set { data.total = value; }
        }

        [Column("net_total")]
        public decimal NetTotal
        {
            get { return data.net_total; }
            set { data.net_total = value; }
        }

        [Column("taxes_and_charges")]
        public string? TaxesAndCharges
        {
            get { return data.taxes_and_charges; }
            set { data.taxes_and_charges = value; }
        }

        [Column("shipping_rule")]
        public string? ShippingRule
        {
            get { return data.shipping_rule; }
            set { data.shipping_rule = value; }
        }

        [Column("tax_category")]
        public string? TaxCategory
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        [Column("other_charges_calculation")]
        public string? OtherChargesCalculation
        {
            get { return data.other_charges_calculation; }
            set { data.other_charges_calculation = value; }
        }

        [Column("base_total_taxes_and_charges")]
        public decimal BaseTotalTaxesAndCharges
        {
            get { return data.base_total_taxes_and_charges; }
            set { data.base_total_taxes_and_charges = value; }
        }

        [Column("total_taxes_and_charges")]
        public decimal TotalTaxesAndCharges
        {
            get { return data.total_taxes_and_charges; }
            set { data.total_taxes_and_charges = value; }
        }

        [Column("loyalty_points")]
        public int LoyaltyPoints
        {
            get { return data.loyalty_points; }
            set { data.loyalty_points = value; }
        }

        [Column("loyalty_amount")]
        public decimal LoyaltyAmount
        {
            get { return data.loyalty_amount; }
            set { data.loyalty_amount = value; }
        }

        [Column("redeem_loyalty_points")]
        public int RedeemLoyaltyPoints
        {
            get { return data.redeem_loyalty_points; }
            set { data.redeem_loyalty_points = value; }
        }

        [Column("loyalty_program")]
        public string? LoyaltyProgram
        {
            get { return data.loyalty_program; }
            set { data.loyalty_program = value; }
        }

        [Column("loyalty_redemption_account")]
        public string? LoyaltyRedemptionAccount
        {
            get { return data.loyalty_redemption_account; }
            set { data.loyalty_redemption_account = value; }
        }

        [Column("loyalty_redemption_cost_center")]
        public string? LoyaltyRedemptionCostCenter
        {
            get { return data.loyalty_redemption_cost_center; }
            set { data.loyalty_redemption_cost_center = value; }
        }

        [Column("apply_discount_on")]
        public string? ApplyDiscountOn
        {
            get { return data.apply_discount_on; }
            set { data.apply_discount_on = value; }
        }

        [Column("is_cash_or_non_trade_discount")]
        public int IsCashOrNonTradeDiscount
        {
            get { return data.is_cash_or_non_trade_discount; }
            set { data.is_cash_or_non_trade_discount = value; }
        }

        [Column("base_discount_amount")]
        public decimal BaseDiscountAmount
        {
            get { return data.base_discount_amount; }
            set { data.base_discount_amount = value; }
        }

        [Column("additional_discount_account")]
        public string? AdditionalDiscountAccount
        {
            get { return data.additional_discount_account; }
            set { data.additional_discount_account = value; }
        }

        [Column("additional_discount_percentage")]
        public decimal AdditionalDiscountPercentage
        {
            get { return data.additional_discount_percentage; }
            set { data.additional_discount_percentage = value; }
        }

        [Column("discount_amount")]
        public decimal DiscountAmount
        {
            get { return data.discount_amount; }
            set { data.discount_amount = value; }
        }

        [Column("base_grand_total")]
        public decimal BaseGrandTotal
        {
            get { return data.base_grand_total; }
            set { data.base_grand_total = value; }
        }

        [Column("base_rounding_adjustment")]
        public decimal BaseRoundingAdjustment
        {
            get { return data.base_rounding_adjustment; }
            set { data.base_rounding_adjustment = value; }
        }

        [Column("base_rounded_total")]
        public decimal BaseRoundedTotal
        {
            get { return data.base_rounded_total; }
            set { data.base_rounded_total = value; }
        }

        [Column("base_in_words")]
        public string? BaseInWords
        {
            get { return data.base_in_words; }
            set { data.base_in_words = value; }
        }

        [Column("grand_total")]
        public decimal GrandTotal
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
        }

        [Column("rounding_adjustment")]
        public decimal RoundingAdjustment
        {
            get { return data.rounding_adjustment; }
            set { data.rounding_adjustment = value; }
        }

        [Column("rounded_total")]
        public decimal RoundedTotal
        {
            get { return data.rounded_total; }
            set { data.rounded_total = value; }
        }

        [Column("in_words")]
        public string? InWords
        {
            get { return data.in_words; }
            set { data.in_words = value; }
        }

        [Column("total_advance")]
        public decimal TotalAdvance
        {
            get { return data.total_advance; }
            set { data.total_advance = value; }
        }

        [Column("outstanding_amount")]
        public decimal OutstandingAmount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        [Column("disable_rounded_total")]
        public int DisableRoundedTotal
        {
            get { return data.disable_rounded_total; }
            set { data.disable_rounded_total = value; }
        }

        [Column("write_off_amount")]
        public decimal WriteOffAmount
        {
            get { return data.write_off_amount; }
            set { data.write_off_amount = value; }
        }

        [Column("base_write_off_amount")]
        public decimal BaseWriteOffAmount
        {
            get { return data.base_write_off_amount; }
            set { data.base_write_off_amount = value; }
        }

        [Column("write_off_outstanding_amount_automatically")]
        public int WriteOffOutstandingAmountAutomatically
        {
            get { return data.write_off_outstanding_amount_automatically; }
            set { data.write_off_outstanding_amount_automatically = value; }
        }

        [Column("write_off_account")]
        public string? WriteOffAccount
        {
            get { return data.write_off_account; }
            set { data.write_off_account = value; }
        }

        [Column("write_off_cost_center")]
        public string? WriteOffCostCenter
        {
            get { return data.write_off_cost_center; }
            set { data.write_off_cost_center = value; }
        }

        [Column("allocate_advances_automatically")]
        public int AllocateAdvancesAutomatically
        {
            get { return data.allocate_advances_automatically; }
            set { data.allocate_advances_automatically = value; }
        }

        [Column("ignore_default_payment_terms_template")]
        public int IgnoreDefaultPaymentTermsTemplate
        {
            get { return data.ignore_default_payment_terms_template; }
            set { data.ignore_default_payment_terms_template = value; }
        }

        [Column("payment_terms_template")]
        public string? PaymentTermsTemplate
        {
            get { return data.payment_terms_template; }
            set { data.payment_terms_template = value; }
        }

        [Column("cash_bank_account")]
        public string? CashBankAccount
        {
            get { return data.cash_bank_account; }
            set { data.cash_bank_account = value; }
        }

        [Column("base_paid_amount")]
        public decimal BasePaidAmount
        {
            get { return data.base_paid_amount; }
            set { data.base_paid_amount = value; }
        }

        [Column("paid_amount")]
        public decimal PaidAmount
        {
            get { return data.paid_amount; }
            set { data.paid_amount = value; }
        }

        [Column("base_change_amount")]
        public decimal BaseChangeAmount
        {
            get { return data.base_change_amount; }
            set { data.base_change_amount = value; }
        }

        [Column("change_amount")]
        public decimal ChangeAmount
        {
            get { return data.change_amount; }
            set { data.change_amount = value; }
        }

        [Column("account_for_change_amount")]
        public string? AccountForChangeAmount
        {
            get { return data.account_for_change_amount; }
            set { data.account_for_change_amount = value; }
        }

        [Column("tc_name")]
        public string? TcName
        {
            get { return data.tc_name; }
            set { data.tc_name = value; }
        }

        [Column("terms")]
        public string? Terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        [Column("letter_head")]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = value; }
        }

        [Column("group_same_items")]
        public int GroupSameItems
        {
            get { return data.group_same_items; }
            set { data.group_same_items = value; }
        }

        [Column("select_print_heading")]
        public string? SelectPrintHeading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = value; }
        }

        [Column("language")]
        public string? Language
        {
            get { return data.language; }
            set { data.language = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("inter_company_invoice_reference")]
        public string? InterCompanyInvoiceReference
        {
            get { return data.inter_company_invoice_reference; }
            set { data.inter_company_invoice_reference = value; }
        }

        [Column("represents_company")]
        public string? RepresentsCompany
        {
            get { return data.represents_company; }
            set { data.represents_company = value; }
        }

        [Column("customer_group")]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        [Column("campaign")]
        public string? Campaign
        {
            get { return data.campaign; }
            set { data.campaign = value; }
        }

        [Column("is_internal_customer")]
        public int IsInternalCustomer
        {
            get { return data.is_internal_customer; }
            set { data.is_internal_customer = value; }
        }

        [Column("is_discounted")]
        public int IsDiscounted
        {
            get { return data.is_discounted; }
            set { data.is_discounted = value; }
        }

        [Column("source")]
        public string? Source
        {
            get { return data.source; }
            set { data.source = value; }
        }

        [Column("debit_to")]
        public string? DebitTo
        {
            get { return data.debit_to; }
            set { data.debit_to = value; }
        }

        [Column("party_account_currency")]
        public string? PartyAccountCurrency
        {
            get { return data.party_account_currency; }
            set { data.party_account_currency = value; }
        }

        [Column("is_opening")]
        public string? IsOpening
        {
            get { return data.is_opening; }
            set { data.is_opening = value; }
        }

        [Column("unrealized_profit_loss_account")]
        public string? UnrealizedProfitLossAccount
        {
            get { return data.unrealized_profit_loss_account; }
            set { data.unrealized_profit_loss_account = value; }
        }

        [Column("remarks")]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        [Column("sales_partner")]
        public string? SalesPartner
        {
            get { return data.sales_partner; }
            set { data.sales_partner = value; }
        }

        [Column("amount_eligible_for_commission")]
        public decimal AmountEligibleForCommission
        {
            get { return data.amount_eligible_for_commission; }
            set { data.amount_eligible_for_commission = value; }
        }

        [Column("commission_rate")]
        public decimal CommissionRate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = value; }
        }

        [Column("total_commission")]
        public decimal TotalCommission
        {
            get { return data.total_commission; }
            set { data.total_commission = value; }
        }

        [Column("from_date")]
        public DateOnly? FromDate
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        [Column("to_date")]
        public DateOnly? ToDate
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        [Column("auto_repeat")]
        public string? AutoRepeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = value; }
        }

        [Column("against_income_account")]
        public string? AgainstIncomeAccount
        {
            get { return data.against_income_account; }
            set { data.against_income_account = value; }
        }

        [Column("_user_tags")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [Column("_comments")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [Column("_assign")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [Column("_liked_by")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }

        [Column("_seen")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }

        [Column("exempt_from_sales_tax")]
        public int ExemptFromSalesTax
        {
            get { return data.exempt_from_sales_tax; }
            set { data.exempt_from_sales_tax = value; }
        }


    }
}

