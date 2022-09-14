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

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanSecurityPledge
{
    public partial class ERP_LoanManagement_LoanSecurityPledge : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanSecurityPledge() : this(new ERPObject(_DocType.LoanManagement_LoanSecurityPledge)) { }
        public ERP_LoanManagement_LoanSecurityPledge(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("loan", "varchar(140)", isNullable: true)]
        public string? Loan
        {
            get { return data.loan; }
            set { data.loan = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("loan_application", "varchar(140)", isNullable: true)]
        public string? LoanApplication
        {
            get { return data.loan_application; }
            set { data.loan_application = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("pledge_time", "datetime(6)", isNullable: true)]
        public DateTimeOffset? PledgeTime
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.pledge_time); }
            set { data.pledge_time = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("total_security_value", "decimal(21,9)", isNullable: false)]
        public decimal TotalSecurityValue
        {
            get { return data.total_security_value; }
            set { data.total_security_value = value; }
        }

        [ColumnInfo("maximum_loan_value", "decimal(21,9)", isNullable: false)]
        public decimal MaximumLoanValue
        {
            get { return data.maximum_loan_value; }
            set { data.maximum_loan_value = value; }
        }

        [ColumnInfo("reference_no", "varchar(140)", isNullable: true)]
        public string? ReferenceNo
        {
            get { return data.reference_no; }
            set { data.reference_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "text", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
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

