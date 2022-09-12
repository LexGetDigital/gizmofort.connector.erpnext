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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentReconciliationInvoice
{
    public partial class ERP_Accounts_PaymentReconciliationInvoice : ERPNextObjectBase
    {
        public ERP_Accounts_PaymentReconciliationInvoice() : this(new ERPObject(_DockType.Accounts_PaymentReconciliationInvoice)) { }
        public ERP_Accounts_PaymentReconciliationInvoice(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_PaymentReconciliationInvoice>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_PaymentReconciliationInvoice>(columnName);
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

        [Column("invoice_type")]
        public string? InvoiceType
        {
            get { return data.invoice_type; }
            set { data.invoice_type = value; }
        }

        [Column("invoice_number")]
        public string? InvoiceNumber
        {
            get { return data.invoice_number; }
            set { data.invoice_number = value; }
        }

        [Column("invoice_date")]
        public DateOnly? InvoiceDate
        {
            get { return data.invoice_date; }
            set { data.invoice_date = value; }
        }

        [Column("amount")]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [Column("outstanding_amount")]
        public decimal OutstandingAmount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        [Column("currency")]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = value; }
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

