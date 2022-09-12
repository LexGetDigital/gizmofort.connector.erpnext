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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PromotionalSchemeProductDiscount
{
    public partial class ERP_Accounts_PromotionalSchemeProductDiscount : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Accounts_PromotionalSchemeProductDiscount() : this(new ERPObject(_DockType.Accounts_PromotionalSchemeProductDiscount)) { }
        public ERP_Accounts_PromotionalSchemeProductDiscount(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_PromotionalSchemeProductDiscount>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_PromotionalSchemeProductDiscount>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Accounts_PromotionalSchemeProductDiscount>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Accounts_PromotionalSchemeProductDiscount? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Accounts_PromotionalSchemeProductDiscount>(json: json);
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

        [Column("disable")]
        public int Disable
        {
            get { return data.disable; }
            set { data.disable = value; }
        }

        [Column("apply_multiple_pricing_rules")]
        public int ApplyMultiplePricingRules
        {
            get { return data.apply_multiple_pricing_rules; }
            set { data.apply_multiple_pricing_rules = value; }
        }

        [Column("rule_description")]
        public string? RuleDescription
        {
            get { return data.rule_description; }
            set { data.rule_description = value; }
        }

        [Column("min_qty")]
        public decimal MinQty
        {
            get { return data.min_qty; }
            set { data.min_qty = value; }
        }

        [Column("max_qty")]
        public decimal MaxQty
        {
            get { return data.max_qty; }
            set { data.max_qty = value; }
        }

        [Column("min_amount")]
        public decimal MinAmount
        {
            get { return data.min_amount; }
            set { data.min_amount = value; }
        }

        [Column("max_amount")]
        public decimal MaxAmount
        {
            get { return data.max_amount; }
            set { data.max_amount = value; }
        }

        [Column("same_item")]
        public int SameItem
        {
            get { return data.same_item; }
            set { data.same_item = value; }
        }

        [Column("free_item")]
        public string? FreeItem
        {
            get { return data.free_item; }
            set { data.free_item = value; }
        }

        [Column("free_qty")]
        public decimal FreeQty
        {
            get { return data.free_qty; }
            set { data.free_qty = value; }
        }

        [Column("free_item_uom")]
        public string? FreeItemUom
        {
            get { return data.free_item_uom; }
            set { data.free_item_uom = value; }
        }

        [Column("free_item_rate")]
        public decimal FreeItemRate
        {
            get { return data.free_item_rate; }
            set { data.free_item_rate = value; }
        }

        [Column("warehouse")]
        public string? Warehouse
        {
            get { return data.warehouse; }
            set { data.warehouse = value; }
        }

        [Column("threshold_percentage")]
        public decimal ThresholdPercentage
        {
            get { return data.threshold_percentage; }
            set { data.threshold_percentage = value; }
        }

        [Column("priority")]
        public string? Priority
        {
            get { return data.priority; }
            set { data.priority = value; }
        }

        [Column("is_recursive")]
        public int IsRecursive
        {
            get { return data.is_recursive; }
            set { data.is_recursive = value; }
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

