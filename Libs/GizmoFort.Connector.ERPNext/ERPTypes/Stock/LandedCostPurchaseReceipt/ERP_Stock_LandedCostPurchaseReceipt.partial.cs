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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.LandedCostPurchaseReceipt
{
    public partial class ERP_Stock_LandedCostPurchaseReceipt : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Stock_LandedCostPurchaseReceipt() : this(new ERPObject(_DockType.Stock_LandedCostPurchaseReceipt)) { }
        public ERP_Stock_LandedCostPurchaseReceipt(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Stock_LandedCostPurchaseReceipt>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Stock_LandedCostPurchaseReceipt>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Stock_LandedCostPurchaseReceipt>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Stock_LandedCostPurchaseReceipt? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Stock_LandedCostPurchaseReceipt>(json: json);
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

        [Column("receipt_document_type")]
        public string? ReceiptDocumentType
        {
            get { return data.receipt_document_type; }
            set { data.receipt_document_type = value; }
        }

        [Column("receipt_document")]
        public string? ReceiptDocument
        {
            get { return data.receipt_document; }
            set { data.receipt_document = value; }
        }

        [Column("supplier")]
        public string? Supplier
        {
            get { return data.supplier; }
            set { data.supplier = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("grand_total")]
        public decimal GrandTotal
        {
            get { return data.grand_total; }
            set { data.grand_total = value; }
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

