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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.SalesInvoiceAdvance
{
    public partial class ERP_Accounts_SalesInvoiceAdvance : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Accounts_SalesInvoiceAdvance() : this(new ERPObject(_DockType.Accounts_SalesInvoiceAdvance)) { }
        public ERP_Accounts_SalesInvoiceAdvance(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_SalesInvoiceAdvance>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_SalesInvoiceAdvance>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Accounts_SalesInvoiceAdvance>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Accounts_SalesInvoiceAdvance? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Accounts_SalesInvoiceAdvance>(json: json);
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

        [Column("reference_type")]
        public string? ReferenceType
        {
            get { return data.reference_type; }
            set { data.reference_type = value; }
        }

        [Column("reference_name")]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        [Column("remarks")]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        [Column("reference_row")]
        public string? ReferenceRow
        {
            get { return data.reference_row; }
            set { data.reference_row = value; }
        }

        [Column("advance_amount")]
        public decimal AdvanceAmount
        {
            get { return data.advance_amount; }
            set { data.advance_amount = value; }
        }

        [Column("allocated_amount")]
        public decimal AllocatedAmount
        {
            get { return data.allocated_amount; }
            set { data.allocated_amount = value; }
        }

        [Column("exchange_gain_loss")]
        public decimal ExchangeGainLoss
        {
            get { return data.exchange_gain_loss; }
            set { data.exchange_gain_loss = value; }
        }

        [Column("ref_exchange_rate")]
        public decimal RefExchangeRate
        {
            get { return data.ref_exchange_rate; }
            set { data.ref_exchange_rate = value; }
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

