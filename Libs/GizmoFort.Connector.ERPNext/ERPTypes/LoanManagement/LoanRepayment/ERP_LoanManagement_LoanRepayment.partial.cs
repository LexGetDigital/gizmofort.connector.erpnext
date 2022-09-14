/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/13/2022 7:48:39 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanRepayment
{
    public partial class ERP_LoanManagement_LoanRepayment : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanRepayment() : this(new ERPObject(_DocType.LoanManagement_LoanRepayment)) { }
        public ERP_LoanManagement_LoanRepayment(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_LoanManagement_LoanRepayment>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_LoanManagement_LoanRepayment>(columnName);
        //}

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

        [ColumnInfo("against_loan", "varchar(140)", isNullable: true)]
        public string? AgainstLoan
        {
            get { return data.against_loan; }
            set { data.against_loan = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("applicant_type", "varchar(140)", isNullable: true)]
        public string? ApplicantType
        {
            get { return data.applicant_type; }
            set { data.applicant_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("applicant", "varchar(140)", isNullable: true)]
        public string? Applicant
        {
            get { return data.applicant; }
            set { data.applicant = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("loan_type", "varchar(140)", isNullable: true)]
        public string? LoanType
        {
            get { return data.loan_type; }
            set { data.loan_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("posting_date", "datetime(6)", isNullable: true)]
        public DateTimeOffset? PostingDate
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.posting_date); }
            set { data.posting_date = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("clearance_date", "date", isNullable: true)]
        public DateOnly? ClearanceDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.clearance_date); }
            set { data.clearance_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("rate_of_interest", "decimal(21,9)", isNullable: false)]
        public decimal RateOfInterest
        {
            get { return data.rate_of_interest; }
            set { data.rate_of_interest = value; }
        }

        [ColumnInfo("is_term_loan", "int(1)", isNullable: false)]
        public bool IsTermLoan
        {
            get { return ERPNextConverter.IntToBool((int)data.is_term_loan); }
            set { data.is_term_loan = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("due_date", "date", isNullable: true)]
        public DateOnly? DueDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.due_date); }
            set { data.due_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("pending_principal_amount", "decimal(21,9)", isNullable: false)]
        public decimal PendingPrincipalAmount
        {
            get { return data.pending_principal_amount; }
            set { data.pending_principal_amount = value; }
        }

        [ColumnInfo("interest_payable", "decimal(21,9)", isNullable: false)]
        public decimal InterestPayable
        {
            get { return data.interest_payable; }
            set { data.interest_payable = value; }
        }

        [ColumnInfo("payable_amount", "decimal(21,9)", isNullable: false)]
        public decimal PayableAmount
        {
            get { return data.payable_amount; }
            set { data.payable_amount = value; }
        }

        [ColumnInfo("shortfall_amount", "decimal(21,9)", isNullable: false)]
        public decimal ShortfallAmount
        {
            get { return data.shortfall_amount; }
            set { data.shortfall_amount = value; }
        }

        [ColumnInfo("payable_principal_amount", "decimal(21,9)", isNullable: false)]
        public decimal PayablePrincipalAmount
        {
            get { return data.payable_principal_amount; }
            set { data.payable_principal_amount = value; }
        }

        [ColumnInfo("penalty_amount", "decimal(21,9)", isNullable: false)]
        public decimal PenaltyAmount
        {
            get { return data.penalty_amount; }
            set { data.penalty_amount = value; }
        }

        [ColumnInfo("amount_paid", "decimal(21,9)", isNullable: false)]
        public decimal AmountPaid
        {
            get { return data.amount_paid; }
            set { data.amount_paid = value; }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_number", "varchar(140)", isNullable: true)]
        public string? ReferenceNumber
        {
            get { return data.reference_number; }
            set { data.reference_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_date", "date", isNullable: true)]
        public DateOnly? ReferenceDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.reference_date); }
            set { data.reference_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("principal_amount_paid", "decimal(21,9)", isNullable: false)]
        public decimal PrincipalAmountPaid
        {
            get { return data.principal_amount_paid; }
            set { data.principal_amount_paid = value; }
        }

        [ColumnInfo("total_penalty_paid", "decimal(21,9)", isNullable: false)]
        public decimal TotalPenaltyPaid
        {
            get { return data.total_penalty_paid; }
            set { data.total_penalty_paid = value; }
        }

        [ColumnInfo("total_interest_paid", "decimal(21,9)", isNullable: false)]
        public decimal TotalInterestPaid
        {
            get { return data.total_interest_paid; }
            set { data.total_interest_paid = value; }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("payment_account", "varchar(140)", isNullable: true)]
        public string? PaymentAccount
        {
            get { return data.payment_account; }
            set { data.payment_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("penalty_income_account", "varchar(140)", isNullable: true)]
        public string? PenaltyIncomeAccount
        {
            get { return data.penalty_income_account; }
            set { data.penalty_income_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("loan_account", "varchar(140)", isNullable: true)]
        public string? LoanAccount
        {
            get { return data.loan_account; }
            set { data.loan_account = ERPNextConverter.TruncateString(value, 140); }
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

