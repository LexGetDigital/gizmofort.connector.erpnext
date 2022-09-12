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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentSchedule
{
    public partial class ERP_Accounts_PaymentSchedule : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Accounts_PaymentSchedule() : this(new ERPObject(_DockType.Accounts_PaymentSchedule)) { }
        public ERP_Accounts_PaymentSchedule(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_PaymentSchedule>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_PaymentSchedule>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Accounts_PaymentSchedule>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Accounts_PaymentSchedule? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Accounts_PaymentSchedule>(json: json);
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

        [Column("payment_term")]
        public string? PaymentTerm
        {
            get { return data.payment_term; }
            set { data.payment_term = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("due_date")]
        public DateOnly? DueDate
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        [Column("mode_of_payment")]
        public string? ModeOfPayment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        [Column("invoice_portion")]
        public decimal InvoicePortion
        {
            get { return data.invoice_portion; }
            set { data.invoice_portion = value; }
        }

        [Column("discount_type")]
        public string? DiscountType
        {
            get { return data.discount_type; }
            set { data.discount_type = value; }
        }

        [Column("discount_date")]
        public DateOnly? DiscountDate
        {
            get { return data.discount_date; }
            set { data.discount_date = value; }
        }

        [Column("discount")]
        public decimal Discount
        {
            get { return data.discount; }
            set { data.discount = value; }
        }

        [Column("payment_amount")]
        public decimal PaymentAmount
        {
            get { return data.payment_amount; }
            set { data.payment_amount = value; }
        }

        [Column("outstanding")]
        public decimal Outstanding
        {
            get { return data.outstanding; }
            set { data.outstanding = value; }
        }

        [Column("paid_amount")]
        public decimal PaidAmount
        {
            get { return data.paid_amount; }
            set { data.paid_amount = value; }
        }

        [Column("discounted_amount")]
        public decimal DiscountedAmount
        {
            get { return data.discounted_amount; }
            set { data.discounted_amount = value; }
        }

        [Column("base_payment_amount")]
        public decimal BasePaymentAmount
        {
            get { return data.base_payment_amount; }
            set { data.base_payment_amount = value; }
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

