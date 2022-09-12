/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/12/2022 2:29:08 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Projects.Project
{
    public partial class ERP_Projects_Project : ERPNextObjectBase
    {
        public ERP_Projects_Project() : this(new ERPObject(_DockType.Projects_Project)) { }
        public ERP_Projects_Project(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Projects_Project>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Projects_Project>(columnName);
        }


        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTimeOffset? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTimeOffset? Modified
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

        [Column("project_name")]
        public string? ProjectName
        {
            get { return data.project_name; }
            set { data.project_name = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("project_type")]
        public string? ProjectType
        {
            get { return data.project_type; }
            set { data.project_type = value; }
        }

        [Column("is_active")]
        public string? IsActive
        {
            get { return data.is_active; }
            set { data.is_active = value; }
        }

        [Column("percent_complete_method")]
        public string? PercentCompleteMethod
        {
            get { return data.percent_complete_method; }
            set { data.percent_complete_method = value; }
        }

        [Column("percent_complete")]
        public decimal PercentComplete
        {
            get { return data.percent_complete; }
            set { data.percent_complete = value; }
        }

        [Column("project_template")]
        public string? ProjectTemplate
        {
            get { return data.project_template; }
            set { data.project_template = value; }
        }

        [Column("expected_start_date")]
        public DateOnly? ExpectedStartDate
        {
            get { return data.expected_start_date; }
            set { data.expected_start_date = value; }
        }

        [Column("expected_end_date")]
        public DateOnly? ExpectedEndDate
        {
            get { return data.expected_end_date; }
            set { data.expected_end_date = value; }
        }

        [Column("priority")]
        public string? Priority
        {
            get { return data.priority; }
            set { data.priority = value; }
        }

        [Column("department")]
        public string? Department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("sales_order")]
        public string? SalesOrder
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        [Column("copied_from")]
        public string? CopiedFrom
        {
            get { return data.copied_from; }
            set { data.copied_from = value; }
        }

        [Column("notes")]
        public string? Notes
        {
            get { return data.notes; }
            set { data.notes = value; }
        }

        [Column("actual_start_date")]
        public DateOnly? ActualStartDate
        {
            get { return data.actual_start_date; }
            set { data.actual_start_date = value; }
        }

        [Column("actual_time")]
        public decimal ActualTime
        {
            get { return data.actual_time; }
            set { data.actual_time = value; }
        }

        [Column("actual_end_date")]
        public DateOnly? ActualEndDate
        {
            get { return data.actual_end_date; }
            set { data.actual_end_date = value; }
        }

        [Column("estimated_costing")]
        public decimal EstimatedCosting
        {
            get { return data.estimated_costing; }
            set { data.estimated_costing = value; }
        }

        [Column("total_costing_amount")]
        public decimal TotalCostingAmount
        {
            get { return data.total_costing_amount; }
            set { data.total_costing_amount = value; }
        }

        [Column("total_purchase_cost")]
        public decimal TotalPurchaseCost
        {
            get { return data.total_purchase_cost; }
            set { data.total_purchase_cost = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("total_sales_amount")]
        public decimal TotalSalesAmount
        {
            get { return data.total_sales_amount; }
            set { data.total_sales_amount = value; }
        }

        [Column("total_billable_amount")]
        public decimal TotalBillableAmount
        {
            get { return data.total_billable_amount; }
            set { data.total_billable_amount = value; }
        }

        [Column("total_billed_amount")]
        public decimal TotalBilledAmount
        {
            get { return data.total_billed_amount; }
            set { data.total_billed_amount = value; }
        }

        [Column("total_consumed_material_cost")]
        public decimal TotalConsumedMaterialCost
        {
            get { return data.total_consumed_material_cost; }
            set { data.total_consumed_material_cost = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("gross_margin")]
        public decimal GrossMargin
        {
            get { return data.gross_margin; }
            set { data.gross_margin = value; }
        }

        [Column("per_gross_margin")]
        public decimal PerGrossMargin
        {
            get { return data.per_gross_margin; }
            set { data.per_gross_margin = value; }
        }

        [Column("collect_progress")]
        public int CollectProgress
        {
            get { return data.collect_progress; }
            set { data.collect_progress = value; }
        }

        [Column("holiday_list")]
        public string? HolidayList
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        [Column("frequency")]
        public string? Frequency
        {
            get { return data.frequency; }
            set { data.frequency = value; }
        }

        [Column("from_time")]
        public TimeSpan? FromTime
        {
            get { return data.from_time; }
            set { data.from_time = value; }
        }

        [Column("to_time")]
        public TimeSpan? ToTime
        {
            get { return data.to_time; }
            set { data.to_time = value; }
        }

        [Column("first_email")]
        public TimeSpan? FirstEmail
        {
            get { return data.first_email; }
            set { data.first_email = value; }
        }

        [Column("second_email")]
        public TimeSpan? SecondEmail
        {
            get { return data.second_email; }
            set { data.second_email = value; }
        }

        [Column("daily_time_to_send")]
        public TimeSpan? DailyTimeToSend
        {
            get { return data.daily_time_to_send; }
            set { data.daily_time_to_send = value; }
        }

        [Column("day_to_send")]
        public string? DayToSend
        {
            get { return data.day_to_send; }
            set { data.day_to_send = value; }
        }

        [Column("weekly_time_to_send")]
        public TimeSpan? WeeklyTimeToSend
        {
            get { return data.weekly_time_to_send; }
            set { data.weekly_time_to_send = value; }
        }

        [Column("message")]
        public string? Message
        {
            get { return data.message; }
            set { data.message = value; }
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

        [Column("_seen")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}

