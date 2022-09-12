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

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.LoanSecurity
{
    public partial class ERP_LoanManagement_LoanSecurity : ERPNextObjectBase
    {
        public ERP_LoanManagement_LoanSecurity() : this(new ERPObject(_DockType.LoanManagement_LoanSecurity)) { }
        public ERP_LoanManagement_LoanSecurity(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_LoanManagement_LoanSecurity>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_LoanManagement_LoanSecurity>(columnName);
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

        [Column("loan_security_name")]
        public string? LoanSecurityName
        {
            get { return data.loan_security_name; }
            set { data.loan_security_name = value; }
        }

        [Column("haircut")]
        public decimal Haircut
        {
            get { return data.haircut; }
            set { data.haircut = value; }
        }

        [Column("loan_security_code")]
        public string? LoanSecurityCode
        {
            get { return data.loan_security_code; }
            set { data.loan_security_code = value; }
        }

        [Column("loan_security_type")]
        public string? LoanSecurityType
        {
            get { return data.loan_security_type; }
            set { data.loan_security_type = value; }
        }

        [Column("unit_of_measure")]
        public string? UnitOfMeasure
        {
            get { return data.unit_of_measure; }
            set { data.unit_of_measure = value; }
        }

        [Column("disabled")]
        public int Disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
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

