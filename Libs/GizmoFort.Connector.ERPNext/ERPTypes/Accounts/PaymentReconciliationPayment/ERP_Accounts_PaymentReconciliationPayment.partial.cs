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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.PaymentReconciliationPayment
{
    public partial class ERP_Accounts_PaymentReconciliationPayment : ERPNextObjectBase
    {
        public ERP_Accounts_PaymentReconciliationPayment() : this(new ERPObject(_DocType.Accounts_PaymentReconciliationPayment)) { }
        public ERP_Accounts_PaymentReconciliationPayment(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("reference_type", "varchar(140)", isNullable: true)]
        public string? ReferenceType
        {
            get { return data.reference_type; }
            set { data.reference_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_name", "varchar(140)", isNullable: true)]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("posting_date", "date", isNullable: true)]
        public DateOnly? PostingDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.posting_date); }
            set { data.posting_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("is_advance", "varchar(140)", isNullable: true)]
        public string? IsAdvance
        {
            get { return data.is_advance; }
            set { data.is_advance = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_row", "varchar(140)", isNullable: true)]
        public string? ReferenceRow
        {
            get { return data.reference_row; }
            set { data.reference_row = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amount", "decimal(21,9)", isNullable: false)]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [ColumnInfo("difference_amount", "decimal(21,9)", isNullable: false)]
        public decimal DifferenceAmount
        {
            get { return data.difference_amount; }
            set { data.difference_amount = value; }
        }

        [ColumnInfo("remark", "text", isNullable: true)]
        public string? Remark
        {
            get { return data.remark; }
            set { data.remark = value; }
        }

        [ColumnInfo("currency", "varchar(140)", isNullable: true)]
        public string? Currency
        {
            get { return data.currency; }
            set { data.currency = ERPNextConverter.TruncateString(value, 140); }
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

