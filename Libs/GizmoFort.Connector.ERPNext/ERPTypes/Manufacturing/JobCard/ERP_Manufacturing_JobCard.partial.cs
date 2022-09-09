/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.JobCard
{
    public partial class ERP_Manufacturing_JobCard : ERPNextObjectBase
    {
        public ERP_Manufacturing_JobCard() : this(new ERPObject(_DockType.Manufacturing_JobCard)) { }
        public ERP_Manufacturing_JobCard(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Manufacturing_JobCard>(propertyName);
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

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("work_order")]
        public string? WorkOrder
        {
            get { return data.work_order; }
            set { data.work_order = value; }
        }

        [Column("bom_no")]
        public string? BomNo
        {
            get { return data.bom_no; }
            set { data.bom_no = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("production_item")]
        public string? ProductionItem
        {
            get { return data.production_item; }
            set { data.production_item = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("for_quantity")]
        public decimal ForQuantity
        {
            get { return data.for_quantity; }
            set { data.for_quantity = value; }
        }

        [Column("serial_no")]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = value; }
        }

        [Column("wip_warehouse")]
        public string? WipWarehouse
        {
            get { return data.wip_warehouse; }
            set { data.wip_warehouse = value; }
        }

        [Column("quality_inspection_template")]
        public string? QualityInspectionTemplate
        {
            get { return data.quality_inspection_template; }
            set { data.quality_inspection_template = value; }
        }

        [Column("quality_inspection")]
        public string? QualityInspection
        {
            get { return data.quality_inspection; }
            set { data.quality_inspection = value; }
        }

        [Column("project")]
        public string? Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("batch_no")]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = value; }
        }

        [Column("operation")]
        public string? Operation
        {
            get { return data.operation; }
            set { data.operation = value; }
        }

        [Column("operation_row_number")]
        public string? OperationRowNumber
        {
            get { return data.operation_row_number; }
            set { data.operation_row_number = value; }
        }

        [Column("workstation")]
        public string? Workstation
        {
            get { return data.workstation; }
            set { data.workstation = value; }
        }

        [Column("total_completed_qty")]
        public decimal TotalCompletedQty
        {
            get { return data.total_completed_qty; }
            set { data.total_completed_qty = value; }
        }

        [Column("total_time_in_mins")]
        public decimal TotalTimeInMins
        {
            get { return data.total_time_in_mins; }
            set { data.total_time_in_mins = value; }
        }

        [Column("for_job_card")]
        public string? ForJobCard
        {
            get { return data.for_job_card; }
            set { data.for_job_card = value; }
        }

        [Column("is_corrective_job_card")]
        public int IsCorrectiveJobCard
        {
            get { return data.is_corrective_job_card; }
            set { data.is_corrective_job_card = value; }
        }

        [Column("hour_rate")]
        public decimal HourRate
        {
            get { return data.hour_rate; }
            set { data.hour_rate = value; }
        }

        [Column("for_operation")]
        public string? ForOperation
        {
            get { return data.for_operation; }
            set { data.for_operation = value; }
        }

        [Column("operation_id")]
        public string? OperationId
        {
            get { return data.operation_id; }
            set { data.operation_id = value; }
        }

        [Column("sequence_id")]
        public int SequenceId
        {
            get { return data.sequence_id; }
            set { data.sequence_id = value; }
        }

        [Column("transferred_qty")]
        public decimal TransferredQty
        {
            get { return data.transferred_qty; }
            set { data.transferred_qty = value; }
        }

        [Column("requested_qty")]
        public decimal RequestedQty
        {
            get { return data.requested_qty; }
            set { data.requested_qty = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("remarks")]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        [Column("barcode")]
        public string? Barcode
        {
            get { return data.barcode; }
            set { data.barcode = value; }
        }

        [Column("job_started")]
        public int JobStarted
        {
            get { return data.job_started; }
            set { data.job_started = value; }
        }

        [Column("started_time")]
        public DateTime? StartedTime
        {
            get { return data.started_time; }
            set { data.started_time = value; }
        }

        [Column("current_time")]
        public int CurrentTime
        {
            get { return data.current_time; }
            set { data.current_time = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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

