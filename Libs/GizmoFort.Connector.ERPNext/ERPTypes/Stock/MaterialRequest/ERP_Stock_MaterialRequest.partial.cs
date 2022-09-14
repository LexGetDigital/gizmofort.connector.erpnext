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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.MaterialRequest
{
    public partial class ERP_Stock_MaterialRequest : ERPNextObjectBase
    {
        public ERP_Stock_MaterialRequest() : this(new ERPObject(_DocType.Stock_MaterialRequest)) { }
        public ERP_Stock_MaterialRequest(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("title", "varchar(140)", isNullable: true)]
        public string? Title
        {
            get { return data.title; }
            set { data.title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("material_request_type", "varchar(140)", isNullable: true)]
        public string? MaterialRequestType
        {
            get { return data.material_request_type; }
            set { data.material_request_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("transfer_status", "varchar(140)", isNullable: true)]
        public string? TransferStatus
        {
            get { return data.transfer_status; }
            set { data.transfer_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("transaction_date", "date", isNullable: true)]
        public DateOnly? TransactionDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.transaction_date); }
            set { data.transaction_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("schedule_date", "date", isNullable: true)]
        public DateOnly? ScheduleDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.schedule_date); }
            set { data.schedule_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("set_from_warehouse", "varchar(140)", isNullable: true)]
        public string? SetFromWarehouse
        {
            get { return data.set_from_warehouse; }
            set { data.set_from_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("set_warehouse", "varchar(140)", isNullable: true)]
        public string? SetWarehouse
        {
            get { return data.set_warehouse; }
            set { data.set_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("scan_barcode", "varchar(140)", isNullable: true)]
        public string? ScanBarcode
        {
            get { return data.scan_barcode; }
            set { data.scan_barcode = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("per_ordered", "decimal(21,9)", isNullable: false)]
        public decimal PerOrdered
        {
            get { return data.per_ordered; }
            set { data.per_ordered = value; }
        }

        [ColumnInfo("per_received", "decimal(21,9)", isNullable: false)]
        public decimal PerReceived
        {
            get { return data.per_received; }
            set { data.per_received = value; }
        }

        [ColumnInfo("letter_head", "varchar(140)", isNullable: true)]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("select_print_heading", "varchar(140)", isNullable: true)]
        public string? SelectPrintHeading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("tc_name", "varchar(140)", isNullable: true)]
        public string? TcName
        {
            get { return data.tc_name; }
            set { data.tc_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("terms", "longtext", isNullable: true)]
        public string? Terms
        {
            get { return data.terms; }
            set { data.terms = value; }
        }

        [ColumnInfo("job_card", "varchar(140)", isNullable: true)]
        public string? JobCard
        {
            get { return data.job_card; }
            set { data.job_card = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("work_order", "varchar(140)", isNullable: true)]
        public string? WorkOrder
        {
            get { return data.work_order; }
            set { data.work_order = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("_user_tags", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [ColumnInfo("_comments", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [ColumnInfo("_assign", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [ColumnInfo("_liked_by", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

