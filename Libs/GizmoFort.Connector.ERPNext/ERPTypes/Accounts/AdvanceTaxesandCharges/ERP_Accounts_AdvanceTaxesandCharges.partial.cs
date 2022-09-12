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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.AdvanceTaxesandCharges
{
    public partial class ERP_Accounts_AdvanceTaxesandCharges : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Accounts_AdvanceTaxesandCharges() : this(new ERPObject(_DockType.Accounts_AdvanceTaxesandCharges)) { }
        public ERP_Accounts_AdvanceTaxesandCharges(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_AdvanceTaxesandCharges>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_AdvanceTaxesandCharges>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Accounts_AdvanceTaxesandCharges>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Accounts_AdvanceTaxesandCharges? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Accounts_AdvanceTaxesandCharges>(json: json);
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

        [Column("add_deduct_tax")]
        public string? AddDeductTax
        {
            get { return data.add_deduct_tax; }
            set { data.add_deduct_tax = value; }
        }

        [Column("charge_type")]
        public string? ChargeType
        {
            get { return data.charge_type; }
            set { data.charge_type = value; }
        }

        [Column("row_id")]
        public string? RowId
        {
            get { return data.row_id; }
            set { data.row_id = value; }
        }

        [Column("account_head")]
        public string? AccountHead
        {
            get { return data.account_head; }
            set { data.account_head = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("included_in_paid_amount")]
        public int IncludedInPaidAmount
        {
            get { return data.included_in_paid_amount; }
            set { data.included_in_paid_amount = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("rate")]
        public decimal Rate
        {
            get { return data.rate; }
            set { data.rate = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        [Column("tax_amount")]
        public decimal TaxAmount
        {
            get { return data.tax_amount; }
            set { data.tax_amount = value; }
        }

        [Column("total")]
        public decimal Total
        {
            get { return data.total; }
            set { data.total = value; }
        }

        [Column("allocated_amount")]
        public decimal AllocatedAmount
        {
            get { return data.allocated_amount; }
            set { data.allocated_amount = value; }
        }

        [Column("base_tax_amount")]
        public decimal BaseTaxAmount
        {
            get { return data.base_tax_amount; }
            set { data.base_tax_amount = value; }
        }

        [Column("base_total")]
        public decimal BaseTotal
        {
            get { return data.base_total; }
            set { data.base_total = value; }
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

