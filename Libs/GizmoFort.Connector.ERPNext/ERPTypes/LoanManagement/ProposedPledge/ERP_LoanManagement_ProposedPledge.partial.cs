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

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.ProposedPledge
{
    public partial class ERP_LoanManagement_ProposedPledge : ERPNextObjectBase
    {
        public ERP_LoanManagement_ProposedPledge() : this(new ERPObject(_DocType.LoanManagement_ProposedPledge)) { }
        public ERP_LoanManagement_ProposedPledge(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("loan_security", "varchar(140)", isNullable: true)]
        public string? LoanSecurity
        {
            get { return data.loan_security; }
            set { data.loan_security = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("loan_security_name", "varchar(140)", isNullable: true)]
        public string? LoanSecurityName
        {
            get { return data.loan_security_name; }
            set { data.loan_security_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("qty", "decimal(21,9)", isNullable: false)]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
        }

        [ColumnInfo("loan_security_price", "decimal(21,9)", isNullable: false)]
        public decimal LoanSecurityPrice
        {
            get { return data.loan_security_price; }
            set { data.loan_security_price = value; }
        }

        [ColumnInfo("amount", "decimal(21,9)", isNullable: false)]
        public decimal Amount
        {
            get { return data.amount; }
            set { data.amount = value; }
        }

        [ColumnInfo("haircut", "decimal(21,9)", isNullable: false)]
        public decimal Haircut
        {
            get { return data.haircut; }
            set { data.haircut = value; }
        }

        [ColumnInfo("post_haircut_amount", "decimal(21,9)", isNullable: false)]
        public decimal PostHaircutAmount
        {
            get { return data.post_haircut_amount; }
            set { data.post_haircut_amount = value; }
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

