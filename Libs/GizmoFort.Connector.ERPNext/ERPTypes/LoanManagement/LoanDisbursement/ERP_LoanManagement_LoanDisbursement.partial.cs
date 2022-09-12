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

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanDisbursement
{
    public partial class ERP_LoanManagement_LoanDisbursement : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanDisbursement() : this(new ERPObject(_DockType.LoanManagement_LoanDisbursement)) { }
        public ERP_LoanManagement_LoanDisbursement(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_LoanManagement_LoanDisbursement>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_LoanManagement_LoanDisbursement>(columnName);
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

        [Column("against_loan")]
        public string? AgainstLoan
        {
            get { return data.against_loan; }
            set { data.against_loan = value; }
        }

        [Column("posting_date")]
        public DateOnly? PostingDate
        {
            get { return data.posting_date; }
            set { data.posting_date = value; }
        }

        [Column("applicant_type")]
        public string? ApplicantType
        {
            get { return data.applicant_type; }
            set { data.applicant_type = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("applicant")]
        public string? Applicant
        {
            get { return data.applicant; }
            set { data.applicant = value; }
        }

        [Column("disbursement_date")]
        public DateOnly? DisbursementDate
        {
            get { return data.disbursement_date; }
            set { data.disbursement_date = value; }
        }

        [Column("clearance_date")]
        public DateOnly? ClearanceDate
        {
            get { return data.clearance_date; }
            set { data.clearance_date = value; }
        }

        [Column("disbursed_amount")]
        public decimal DisbursedAmount
        {
            get { return data.disbursed_amount; }
            set { data.disbursed_amount = value; }
        }

        [Column("cost_center")]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = value; }
        }

        [Column("disbursement_account")]
        public string? DisbursementAccount
        {
            get { return data.disbursement_account; }
            set { data.disbursement_account = value; }
        }

        [Column("loan_account")]
        public string? LoanAccount
        {
            get { return data.loan_account; }
            set { data.loan_account = value; }
        }

        [Column("bank_account")]
        public string? BankAccount
        {
            get { return data.bank_account; }
            set { data.bank_account = value; }
        }

        [Column("reference_date")]
        public DateOnly? ReferenceDate
        {
            get { return data.reference_date; }
            set { data.reference_date = value; }
        }

        [Column("reference_number")]
        public string? ReferenceNumber
        {
            get { return data.reference_number; }
            set { data.reference_number = value; }
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

