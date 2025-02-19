/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/14/2022 8:42:56 AM
********************************************************************/

using System;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.BOMOperation
{
    public partial class ERP_Manufacturing_BOMOperation : ERPNextObjectBase
    {
        public ERP_Manufacturing_BOMOperation() : this(new ERPObject(_DocType.Manufacturing_BOMOperation)) { }
        public ERP_Manufacturing_BOMOperation(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("sequence_id", "int(11)", isNullable: false)]
        public int SequenceId
        {
            get { return data.sequence_id; }
            set { data.sequence_id = value; }
        }

        [ColumnInfo("operation", "varchar(140)", isNullable: true)]
        public string? Operation
        {
            get { return data.operation; }
            set { data.operation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("workstation", "varchar(140)", isNullable: true)]
        public string? Workstation
        {
            get { return data.workstation; }
            set { data.workstation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("time_in_mins", "decimal(21,9)", isNullable: false)]
        public decimal TimeInMins
        {
            get { return data.time_in_mins; }
            set { data.time_in_mins = value; }
        }

        [ColumnInfo("fixed_time", "int(1)", isNullable: false)]
        public bool FixedTime
        {
            get { return ERPNextConverter.IntToBool((int)data.fixed_time); }
            set { data.fixed_time = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("hour_rate", "decimal(21,9)", isNullable: false)]
        public decimal HourRate
        {
            get { return data.hour_rate; }
            set { data.hour_rate = value; }
        }

        [ColumnInfo("base_hour_rate", "decimal(21,9)", isNullable: false)]
        public decimal BaseHourRate
        {
            get { return data.base_hour_rate; }
            set { data.base_hour_rate = value; }
        }

        [ColumnInfo("operating_cost", "decimal(21,9)", isNullable: false)]
        public decimal OperatingCost
        {
            get { return data.operating_cost; }
            set { data.operating_cost = value; }
        }

        [ColumnInfo("base_operating_cost", "decimal(21,9)", isNullable: false)]
        public decimal BaseOperatingCost
        {
            get { return data.base_operating_cost; }
            set { data.base_operating_cost = value; }
        }

        [ColumnInfo("batch_size", "int(11)", isNullable: false)]
        public int BatchSize
        {
            get { return data.batch_size; }
            set { data.batch_size = value; }
        }

        [ColumnInfo("set_cost_based_on_bom_qty", "int(1)", isNullable: false)]
        public bool SetCostBasedOnBomQty
        {
            get { return ERPNextConverter.IntToBool((int)data.set_cost_based_on_bom_qty); }
            set { data.set_cost_based_on_bom_qty = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("cost_per_unit", "decimal(21,9)", isNullable: false)]
        public decimal CostPerUnit
        {
            get { return data.cost_per_unit; }
            set { data.cost_per_unit = value; }
        }

        [ColumnInfo("base_cost_per_unit", "decimal(21,9)", isNullable: false)]
        public decimal BaseCostPerUnit
        {
            get { return data.base_cost_per_unit; }
            set { data.base_cost_per_unit = value; }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("parent", "varchar(140)", isNullable: true)]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parentfield", "varchar(140)", isNullable: true)]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parenttype", "varchar(140)", isNullable: true)]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = ERPNextConverter.TruncateString(value, 140); }
        }


    }
}

