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

namespace GizmoFort.Connector.ERPNext.ERPTypes.CRM.Contract
{
    public partial class ERP_CRM_Contract : ERPNextObjectBase
    {
        public ERP_CRM_Contract() : this(new ERPObject(_DockType.CRM_Contract)) { }
        public ERP_CRM_Contract(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_CRM_Contract>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_CRM_Contract>(columnName);
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

        [Column("party_type")]
        public string? PartyType
        {
            get { return data.party_type; }
            set { data.party_type = value; }
        }

        [Column("is_signed")]
        public int IsSigned
        {
            get { return data.is_signed; }
            set { data.is_signed = value; }
        }

        [Column("party_name")]
        public string? PartyName
        {
            get { return data.party_name; }
            set { data.party_name = value; }
        }

        [Column("party_user")]
        public string? PartyUser
        {
            get { return data.party_user; }
            set { data.party_user = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("fulfilment_status")]
        public string? FulfilmentStatus
        {
            get { return data.fulfilment_status; }
            set { data.fulfilment_status = value; }
        }

        [Column("start_date")]
        public DateOnly? StartDate
        {
            get { return data.start_date; }
            set { data.start_date = value; }
        }

        [Column("end_date")]
        public DateOnly? EndDate
        {
            get { return data.end_date; }
            set { data.end_date = value; }
        }

        [Column("signee")]
        public string? Signee
        {
            get { return data.signee; }
            set { data.signee = value; }
        }

        [Column("signed_on")]
        public DateTime? SignedOn
        {
            get { return data.signed_on; }
            set { data.signed_on = value; }
        }

        [Column("ip_address")]
        public string? IpAddress
        {
            get { return data.ip_address; }
            set { data.ip_address = value; }
        }

        [Column("contract_template")]
        public string? ContractTemplate
        {
            get { return data.contract_template; }
            set { data.contract_template = value; }
        }

        [Column("contract_terms")]
        public string? ContractTerms
        {
            get { return data.contract_terms; }
            set { data.contract_terms = value; }
        }

        [Column("requires_fulfilment")]
        public int RequiresFulfilment
        {
            get { return data.requires_fulfilment; }
            set { data.requires_fulfilment = value; }
        }

        [Column("fulfilment_deadline")]
        public DateOnly? FulfilmentDeadline
        {
            get { return data.fulfilment_deadline; }
            set { data.fulfilment_deadline = value; }
        }

        [Column("signee_company")]
        public string? SigneeCompany
        {
            get { return data.signee_company; }
            set { data.signee_company = value; }
        }

        [Column("signed_by_company")]
        public string? SignedByCompany
        {
            get { return data.signed_by_company; }
            set { data.signed_by_company = value; }
        }

        [Column("document_type")]
        public string? DocumentType
        {
            get { return data.document_type; }
            set { data.document_type = value; }
        }

        [Column("document_name")]
        public string? DocumentName
        {
            get { return data.document_name; }
            set { data.document_name = value; }
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

        [Column("_seen")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}

