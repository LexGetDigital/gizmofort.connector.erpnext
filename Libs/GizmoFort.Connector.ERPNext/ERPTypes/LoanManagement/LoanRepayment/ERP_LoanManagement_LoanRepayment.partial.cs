/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanRepayment
{
    public partial class ERP_LoanManagement_LoanRepayment : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanRepayment() : this(new ERPObject(_DockType.LoanManagement_LoanRepayment)) { }
        public ERP_LoanManagement_LoanRepayment(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_LoanManagement_LoanRepayment>(propertyName);
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

        [Column("against_loan")]
        public string? AgainstLoan
        {
            get { return data.against_loan; }
            set { data.against_loan = value; }
        }

        [Column("applicant_type")]
        public string? ApplicantType
        {
            get { return data.applicant_type; }
            set { data.applicant_type = value; }
        }

        [Column("applicant")]
        public string? Applicant
        {
            get { return data.applicant; }
            set { data.applicant = value; }
        }

        [Column("loan_type")]
        public string? LoanType
        {
            get { return data.loan_type; }
            set { data.loan_type = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("posting_date")]
        public DateTime? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("clearance_date")]
        public DateOnly? ClearanceDate
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }

        [Column("rate_of_interest")]
        public decimal RateOfInterest
        {
            get { return data.rate_of_interest; }
            set { data.rate_of_interest = value; }
        }

        [Column("is_term_loan")]
        public int IsTermLoan
        {
            get { return data.is_term_loan; }
            set { data.is_term_loan = value; }
        }

        [Column("due_date")]
        public DateOnly? DueDate
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        [Column("pending_principal_amount")]
        public decimal PendingPrincipalAmount
        {
            get { return data.pending_principal_amount; }
            set { data.pending_principal_amount = value; }
        }

        [Column("interest_payable")]
        public decimal InterestPayable
        {
            get { return data.interest_payable; }
            set { data.interest_payable = value; }
        }

        [Column("payable_amount")]
        public decimal PayableAmount
        {
            get { return data.payable_amount; }
            set { data.payable_amount = value; }
        }

        [Column("shortfall_amount")]
        public decimal ShortfallAmount
        {
            get { return data.shortfall_amount; }
            set { data.shortfall_amount = value; }
        }

        [Column("payable_principal_amount")]
        public decimal PayablePrincipalAmount
        {
            get { return data.payable_principal_amount; }
            set { data.payable_principal_amount = value; }
        }

        [Column("penalty_amount")]
        public decimal PenaltyAmount
        {
            get { return data.penalty_amount; }
            set { data.penalty_amount = value; }
        }

        [Column("amount_paid")]
        public decimal AmountPaid
        {
            get { return data.amount_paid; }
            set { data.amount_paid = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("reference_number")]
        public string? ReferenceNumber
        {
            get { return data.reference_number; }
            set { data.reference_number = value; }
        }

        [Column("reference_date")]
        public DateOnly? ReferenceDate
        {
            get { return data.reference_date; }
            set { data.reference_date = value; }
        }

        [Column("principal_amount_paid")]
        public decimal PrincipalAmountPaid
        {
            get { return data.principal_amount_paid; }
            set { data.principal_amount_paid = value; }
        }

        [Column("total_penalty_paid")]
        public decimal TotalPenaltyPaid
        {
            get { return data.total_penalty_paid; }
            set { data.total_penalty_paid = value; }
        }

        [Column("total_interest_paid")]
        public decimal TotalInterestPaid
        {
            get { return data.total_interest_paid; }
            set { data.total_interest_paid = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        [Column("payment_account")]
        public string? PaymentAccount
        {
            get { return data.payment_account; }
            set { data.payment_account = value; }
        }

        [Column("penalty_income_account")]
        public string? PenaltyIncomeAccount
        {
            get { return data.penalty_income_account; }
            set { data.penalty_income_account = value; }
        }

        [Column("loan_account")]
        public string? LoanAccount
        {
            get { return data.loan_account; }
            set { data.loan_account = value; }
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

