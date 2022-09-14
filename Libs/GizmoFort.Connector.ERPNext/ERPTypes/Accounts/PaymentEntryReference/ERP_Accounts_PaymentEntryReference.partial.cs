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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentEntryReference
{
    public partial class ERP_Accounts_PaymentEntryReference : ERPNextObjectBase
    {
        public ERP_Accounts_PaymentEntryReference() : this(new ERPObject(_DocType.Accounts_PaymentEntryReference)) { }
        public ERP_Accounts_PaymentEntryReference(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("reference_doctype", "varchar(140)", isNullable: true)]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_name", "varchar(140)", isNullable: true)]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("due_date", "date", isNullable: true)]
        public DateOnly? DueDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.due_date); }
            set { data.due_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("bill_no", "varchar(140)", isNullable: true)]
        public string? BillNo
        {
            get { return data.bill_no; }
            set { data.bill_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_term", "varchar(140)", isNullable: true)]
        public string? PaymentTerm
        {
            get { return data.payment_term; }
            set { data.payment_term = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("total_amount", "decimal(21,9)", isNullable: false)]
        public decimal TotalAmount
        {
            get { return data.total_amount; }
            set { data.total_amount = value; }
        }

        [ColumnInfo("outstanding_amount", "decimal(21,9)", isNullable: false)]
        public decimal OutstandingAmount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        [ColumnInfo("allocated_amount", "decimal(21,9)", isNullable: false)]
        public decimal AllocatedAmount
        {
            get { return data.allocated_amount; }
            set { data.allocated_amount = value; }
        }

        [ColumnInfo("exchange_rate", "decimal(21,9)", isNullable: false)]
        public decimal ExchangeRate
        {
            get { return data.exchange_rate; }
            set { data.exchange_rate = value; }
        }

        [ColumnInfo("exchange_gain_loss", "decimal(21,9)", isNullable: false)]
        public decimal ExchangeGainLoss
        {
            get { return data.exchange_gain_loss; }
            set { data.exchange_gain_loss = value; }
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

