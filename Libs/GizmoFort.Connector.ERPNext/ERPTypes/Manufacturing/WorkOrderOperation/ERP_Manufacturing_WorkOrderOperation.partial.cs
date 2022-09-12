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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.WorkOrderOperation
{
    public partial class ERP_Manufacturing_WorkOrderOperation : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Manufacturing_WorkOrderOperation() : this(new ERPObject(_DockType.Manufacturing_WorkOrderOperation)) { }
        public ERP_Manufacturing_WorkOrderOperation(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Manufacturing_WorkOrderOperation>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Manufacturing_WorkOrderOperation>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Manufacturing_WorkOrderOperation>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Manufacturing_WorkOrderOperation? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Manufacturing_WorkOrderOperation>(json: json);
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

        [Column("operation")]
        public string? Operation
        {
            get { return data.operation; }
            set { data.operation = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("completed_qty")]
        public decimal CompletedQty
        {
            get { return data.completed_qty; }
            set { data.completed_qty = value; }
        }

        [Column("bom")]
        public string? Bom
        {
            get { return data.bom; }
            set { data.bom = value; }
        }

        [Column("workstation")]
        public string? Workstation
        {
            get { return data.workstation; }
            set { data.workstation = value; }
        }

        [Column("sequence_id")]
        public int SequenceId
        {
            get { return data.sequence_id; }
            set { data.sequence_id = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("planned_start_time")]
        public DateTime? PlannedStartTime
        {
            get { return data.planned_start_time; }
            set { data.planned_start_time = value; }
        }

        [Column("hour_rate")]
        public decimal HourRate
        {
            get { return data.hour_rate; }
            set { data.hour_rate = value; }
        }

        [Column("time_in_mins")]
        public decimal TimeInMins
        {
            get { return data.time_in_mins; }
            set { data.time_in_mins = value; }
        }

        [Column("planned_end_time")]
        public DateTime? PlannedEndTime
        {
            get { return data.planned_end_time; }
            set { data.planned_end_time = value; }
        }

        [Column("batch_size")]
        public decimal BatchSize
        {
            get { return data.batch_size; }
            set { data.batch_size = value; }
        }

        [Column("planned_operating_cost")]
        public decimal PlannedOperatingCost
        {
            get { return data.planned_operating_cost; }
            set { data.planned_operating_cost = value; }
        }

        [Column("actual_start_time")]
        public DateTime? ActualStartTime
        {
            get { return data.actual_start_time; }
            set { data.actual_start_time = value; }
        }

        [Column("actual_operation_time")]
        public decimal ActualOperationTime
        {
            get { return data.actual_operation_time; }
            set { data.actual_operation_time = value; }
        }

        [Column("actual_end_time")]
        public DateTime? ActualEndTime
        {
            get { return data.actual_end_time; }
            set { data.actual_end_time = value; }
        }

        [Column("actual_operating_cost")]
        public decimal ActualOperatingCost
        {
            get { return data.actual_operating_cost; }
            set { data.actual_operating_cost = value; }
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

