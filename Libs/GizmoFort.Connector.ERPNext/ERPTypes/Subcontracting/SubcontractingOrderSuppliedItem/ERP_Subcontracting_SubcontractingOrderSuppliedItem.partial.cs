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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subcontracting.SubcontractingOrderSuppliedItem
{
    public partial class ERP_Subcontracting_SubcontractingOrderSuppliedItem : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Subcontracting_SubcontractingOrderSuppliedItem() : this(new ERPObject(_DockType.Subcontracting_SubcontractingOrderSuppliedItem)) { }
        public ERP_Subcontracting_SubcontractingOrderSuppliedItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Subcontracting_SubcontractingOrderSuppliedItem>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Subcontracting_SubcontractingOrderSuppliedItem>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Subcontracting_SubcontractingOrderSuppliedItem>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Subcontracting_SubcontractingOrderSuppliedItem? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Subcontracting_SubcontractingOrderSuppliedItem>(json: json);
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

        [Column("main_item_code")]
        public string? MainItemCode
        {
            get { return data.main_item_code; }
            set { data.main_item_code = value; }
        }

        [Column("rm_item_code")]
        public string? RmItemCode
        {
            get { return data.rm_item_code; }
            set { data.rm_item_code = value; }
        }

        [Column("stock_uom")]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        [Column("conversion_factor")]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        [Column("reserve_warehouse")]
        public string? ReserveWarehouse
        {
            get { return data.reserve_warehouse; }
            set { data.reserve_warehouse = value; }
        }

        [Column("bom_detail_no")]
        public string? BomDetailNo
        {
            get { return data.bom_detail_no; }
            set { data.bom_detail_no = value; }
        }

        [Column("reference_name")]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
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

        [Column("required_qty")]
        public decimal RequiredQty
        {
            get { return data.required_qty; }
            set { data.required_qty = value; }
        }

        [Column("supplied_qty")]
        public decimal SuppliedQty
        {
            get { return data.supplied_qty; }
            set { data.supplied_qty = value; }
        }

        [Column("consumed_qty")]
        public decimal ConsumedQty
        {
            get { return data.consumed_qty; }
            set { data.consumed_qty = value; }
        }

        [Column("returned_qty")]
        public decimal ReturnedQty
        {
            get { return data.returned_qty; }
            set { data.returned_qty = value; }
        }

        [Column("total_supplied_qty")]
        public decimal TotalSuppliedQty
        {
            get { return data.total_supplied_qty; }
            set { data.total_supplied_qty = value; }
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

