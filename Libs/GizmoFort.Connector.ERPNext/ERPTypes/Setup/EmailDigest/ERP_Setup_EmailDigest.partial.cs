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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.EmailDigest
{
    public partial class ERP_Setup_EmailDigest : ERPNextObjectBase
    {
        public ERP_Setup_EmailDigest() : this(new ERPObject(_DockType.Setup_EmailDigest)) { }
        public ERP_Setup_EmailDigest(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Setup_EmailDigest>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Setup_EmailDigest>(columnName);
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

        [Column("enabled")]
        public int Enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("frequency")]
        public string? Frequency
        {
            get { return data.frequency; }
            set { data.frequency = value; }
        }

        [Column("next_send")]
        public string? NextSend
        {
            get { return data.next_send; }
            set { data.next_send = value; }
        }

        [Column("income")]
        public int Income
        {
            get { return data.income; }
            set { data.income = value; }
        }

        [Column("expenses_booked")]
        public int ExpensesBooked
        {
            get { return data.expenses_booked; }
            set { data.expenses_booked = value; }
        }

        [Column("income_year_to_date")]
        public int IncomeYearToDate
        {
            get { return data.income_year_to_date; }
            set { data.income_year_to_date = value; }
        }

        [Column("expense_year_to_date")]
        public int ExpenseYearToDate
        {
            get { return data.expense_year_to_date; }
            set { data.expense_year_to_date = value; }
        }

        [Column("bank_balance")]
        public int BankBalance
        {
            get { return data.bank_balance; }
            set { data.bank_balance = value; }
        }

        [Column("credit_balance")]
        public int CreditBalance
        {
            get { return data.credit_balance; }
            set { data.credit_balance = value; }
        }

        [Column("invoiced_amount")]
        public int InvoicedAmount
        {
            get { return data.invoiced_amount; }
            set { data.invoiced_amount = value; }
        }

        [Column("payables")]
        public int Payables
        {
            get { return data.payables; }
            set { data.payables = value; }
        }

        [Column("sales_orders_to_bill")]
        public int SalesOrdersToBill
        {
            get { return data.sales_orders_to_bill; }
            set { data.sales_orders_to_bill = value; }
        }

        [Column("purchase_orders_to_bill")]
        public int PurchaseOrdersToBill
        {
            get { return data.purchase_orders_to_bill; }
            set { data.purchase_orders_to_bill = value; }
        }

        [Column("sales_order")]
        public int SalesOrder
        {
            get { return data.sales_order; }
            set { data.sales_order = value; }
        }

        [Column("purchase_order")]
        public int PurchaseOrder
        {
            get { return data.purchase_order; }
            set { data.purchase_order = value; }
        }

        [Column("sales_orders_to_deliver")]
        public int SalesOrdersToDeliver
        {
            get { return data.sales_orders_to_deliver; }
            set { data.sales_orders_to_deliver = value; }
        }

        [Column("purchase_orders_to_receive")]
        public int PurchaseOrdersToReceive
        {
            get { return data.purchase_orders_to_receive; }
            set { data.purchase_orders_to_receive = value; }
        }

        [Column("sales_invoice")]
        public int SalesInvoice
        {
            get { return data.sales_invoice; }
            set { data.sales_invoice = value; }
        }

        [Column("purchase_invoice")]
        public int PurchaseInvoice
        {
            get { return data.purchase_invoice; }
            set { data.purchase_invoice = value; }
        }

        [Column("new_quotations")]
        public int NewQuotations
        {
            get { return data.new_quotations; }
            set { data.new_quotations = value; }
        }

        [Column("pending_quotations")]
        public int PendingQuotations
        {
            get { return data.pending_quotations; }
            set { data.pending_quotations = value; }
        }

        [Column("issue")]
        public int Issue
        {
            get { return data.issue; }
            set { data.issue = value; }
        }

        [Column("project")]
        public int Project
        {
            get { return data.project; }
            set { data.project = value; }
        }

        [Column("purchase_orders_items_overdue")]
        public int PurchaseOrdersItemsOverdue
        {
            get { return data.purchase_orders_items_overdue; }
            set { data.purchase_orders_items_overdue = value; }
        }

        [Column("calendar_events")]
        public int CalendarEvents
        {
            get { return data.calendar_events; }
            set { data.calendar_events = value; }
        }

        [Column("todo_list")]
        public int TodoList
        {
            get { return data.todo_list; }
            set { data.todo_list = value; }
        }

        [Column("notifications")]
        public int Notifications
        {
            get { return data.notifications; }
            set { data.notifications = value; }
        }

        [Column("add_quote")]
        public int AddQuote
        {
            get { return data.add_quote; }
            set { data.add_quote = value; }
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

