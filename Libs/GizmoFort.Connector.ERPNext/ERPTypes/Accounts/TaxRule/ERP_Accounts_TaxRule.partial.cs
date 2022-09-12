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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.TaxRule
{
    public partial class ERP_Accounts_TaxRule : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Accounts_TaxRule() : this(new ERPObject(_DockType.Accounts_TaxRule)) { }
        public ERP_Accounts_TaxRule(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_TaxRule>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_TaxRule>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Accounts_TaxRule>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Accounts_TaxRule? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Accounts_TaxRule>(json: json);
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

        [Column("tax_type")]
        public string? TaxType
        {
            get { return data.tax_type; }
            set { data.tax_type = value; }
        }

        [Column("use_for_shopping_cart")]
        public int UseForShoppingCart
        {
            get { return data.use_for_shopping_cart; }
            set { data.use_for_shopping_cart = value; }
        }

        [Column("sales_tax_template")]
        public string? SalesTaxTemplate
        {
            get { return data.sales_tax_template; }
            set { data.sales_tax_template = value; }
        }

        [Column("purchase_tax_template")]
        public string? PurchaseTaxTemplate
        {
            get { return data.purchase_tax_template; }
            set { data.purchase_tax_template = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("supplier")]
        public string? Supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        [Column("item")]
        public string? Item
        {
            get { return data.item; }
            set { data.item = value; }
        }

        [Column("billing_city")]
        public string? BillingCity
        {
            get { return data.billing_city; }
            set { data.billing_city = value; }
        }

        [Column("billing_county")]
        public string? BillingCounty
        {
            get { return data.billing_county; }
            set { data.billing_county = value; }
        }

        [Column("billing_state")]
        public string? BillingState
        {
            get { return data.billing_state; }
            set { data.billing_state = value; }
        }

        [Column("billing_zipcode")]
        public string? BillingZipcode
        {
            get { return data.billing_zipcode; }
            set { data.billing_zipcode = value; }
        }

        [Column("billing_country")]
        public string? BillingCountry
        {
            get { return data.billing_country; }
            set { data.billing_country = value; }
        }

        [Column("tax_category")]
        public string? TaxCategory
        {
            get { return data.tax_category; }
            set { data.tax_category = value; }
        }

        [Column("customer_group")]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
        }

        [Column("supplier_group")]
        public string? SupplierGroup
        {
            get { return data.supplier_group; }
            set { data.supplier_group = value; }
        }

        [Column("item_group")]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        [Column("shipping_city")]
        public string? ShippingCity
        {
            get { return data.shipping_city; }
            set { data.shipping_city = value; }
        }

        [Column("shipping_county")]
        public string? ShippingCounty
        {
            get { return data.shipping_county; }
            set { data.shipping_county = value; }
        }

        [Column("shipping_state")]
        public string? ShippingState
        {
            get { return data.shipping_state; }
            set { data.shipping_state = value; }
        }

        [Column("shipping_zipcode")]
        public string? ShippingZipcode
        {
            get { return data.shipping_zipcode; }
            set { data.shipping_zipcode = value; }
        }

        [Column("shipping_country")]
        public string? ShippingCountry
        {
            get { return data.shipping_country; }
            set { data.shipping_country = value; }
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

        [Column("priority")]
        public int Priority
        {
            get { return data.priority; }
            set { data.priority = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
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


    }
}

