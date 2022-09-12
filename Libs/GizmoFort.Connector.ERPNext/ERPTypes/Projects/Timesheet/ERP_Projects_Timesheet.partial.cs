/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/12/2022 11:57:48 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Projects.Timesheet
{
    public partial class ERP_Projects_Timesheet : ERPNextObjectBase
    {
        public ERP_Projects_Timesheet() : this(new ERPObject(_DockType.Projects_Timesheet)) { }
        public ERP_Projects_Timesheet(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Projects_Timesheet>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Projects_Timesheet>(columnName);
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

        [Column("title")]
        public string? Title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
        }

        [Column("exchange_rate")]
        public decimal ExchangeRate
        {
            get { return data.exchange_rate; }
            set { data.exchange_rate = value; }
        }

        [Column("sales_invoice")]
        public string? SalesInvoice
        {
            get { return data.sales_invoice; }
            set { data.sales_invoice = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("parent_project")]
        public string? ParentProject
        {
            get { return data.parent_project; }
            set { data.parent_project = value; }
        }

        [Column("employee")]
        public string? Employee
        {
            get { return data.employee; }
            set { data.employee = value; }
        }

        [Column("employee_name")]
        public string? EmployeeName
        {
            get { return data.employee_name; }
            set { data.employee_name = value; }
        }

        [Column("department")]
        public string? Department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        [Column("user")]
        public string? User
        {
            get { return data.user; }
            set { data.user = value; }
        }

        [Column("start_date")]
        public DateOnly? StartDate
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        [Column("end_date")]
        public DateOnly? EndDate
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        [Column("total_hours")]
        public decimal TotalHours
        {
            get { return data.total_hours; }
            set { data.total_hours = value; }
        }

        [Column("total_billable_hours")]
        public decimal TotalBillableHours
        {
            get { return data.total_billable_hours; }
            set { data.total_billable_hours = value; }
        }

        [Column("base_total_billable_amount")]
        public decimal BaseTotalBillableAmount
        {
            get { return data.base_total_billable_amount; }
            set { data.base_total_billable_amount = value; }
        }

        [Column("base_total_billed_amount")]
        public decimal BaseTotalBilledAmount
        {
            get { return data.base_total_billed_amount; }
            set { data.base_total_billed_amount = value; }
        }

        [Column("base_total_costing_amount")]
        public decimal BaseTotalCostingAmount
        {
            get { return data.base_total_costing_amount; }
            set { data.base_total_costing_amount = value; }
        }

        [Column("total_billed_hours")]
        public decimal TotalBilledHours
        {
            get { return data.total_billed_hours; }
            set { data.total_billed_hours = value; }
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

        [Column("total_costing_amount")]
        public decimal TotalCostingAmount
        {
            get { return data.total_costing_amount; }
            set { data.total_costing_amount = value; }
        }

        [Column("per_billed")]
        public decimal PerBilled
        {
            get { return data.per_billed; }
            set { data.per_billed = value; }
        }

        [Column("note")]
        public string? Note
        {
            get { return data.note; }
            set { data.note = value; }
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

