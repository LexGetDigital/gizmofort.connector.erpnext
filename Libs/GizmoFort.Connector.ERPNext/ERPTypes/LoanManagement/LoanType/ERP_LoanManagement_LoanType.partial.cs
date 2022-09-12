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

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanType
{
    public partial class ERP_LoanManagement_LoanType : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanType() : this(new ERPObject(_DockType.LoanManagement_LoanType)) { }
        public ERP_LoanManagement_LoanType(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_LoanManagement_LoanType>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_LoanManagement_LoanType>(columnName);
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

        [Column("loan_name")]
        public string? LoanName
        {
            get { return data.loan_name; }
            set { data.loan_name = value; }
        }

        [Column("maximum_loan_amount")]
        public decimal MaximumLoanAmount
        {
            get { return data.maximum_loan_amount; }
            set { data.maximum_loan_amount = value; }
        }

        [Column("rate_of_interest")]
        public decimal RateOfInterest
        {
            get { return data.rate_of_interest; }
            set { data.rate_of_interest = value; }
        }

        [Column("penalty_interest_rate")]
        public decimal PenaltyInterestRate
        {
            get { return data.penalty_interest_rate; }
            set { data.penalty_interest_rate = value; }
        }

        [Column("grace_period_in_days")]
        public int GracePeriodInDays
        {
            get { return data.grace_period_in_days; }
            set { data.grace_period_in_days = value; }
        }

        [Column("write_off_amount")]
        public decimal WriteOffAmount
        {
            get { return data.write_off_amount; }
            set { data.write_off_amount = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("is_term_loan")]
        public int IsTermLoan
        {
            get { return data.is_term_loan; }
            set { data.is_term_loan = value; }
        }

        [Column("disabled")]
        public int Disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("mode_of_payment")]
        public string? ModeOfPayment
        {
            get { return data.mode_of_payment; }
            set { data.mode_of_payment = value; }
        }

        [Column("disbursement_account")]
        public string? DisbursementAccount
        {
            get { return data.disbursement_account; }
            set { data.disbursement_account = value; }
        }

        [Column("payment_account")]
        public string? PaymentAccount
        {
            get { return data.payment_account; }
            set { data.payment_account = value; }
        }

        [Column("loan_account")]
        public string? LoanAccount
        {
            get { return data.loan_account; }
            set { data.loan_account = value; }
        }

        [Column("interest_income_account")]
        public string? InterestIncomeAccount
        {
            get { return data.interest_income_account; }
            set { data.interest_income_account = value; }
        }

        [Column("penalty_income_account")]
        public string? PenaltyIncomeAccount
        {
            get { return data.penalty_income_account; }
            set { data.penalty_income_account = value; }
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

