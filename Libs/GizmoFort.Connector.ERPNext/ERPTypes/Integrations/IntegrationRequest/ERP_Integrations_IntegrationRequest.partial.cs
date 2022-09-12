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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.IntegrationRequest
{
    public partial class ERP_Integrations_IntegrationRequest : ERPNextObjectBase
    {
        public ERP_Integrations_IntegrationRequest() : this(new ERPObject(_DockType.Integrations_IntegrationRequest)) { }
        public ERP_Integrations_IntegrationRequest(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Integrations_IntegrationRequest>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Integrations_IntegrationRequest>(columnName);
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

        [Column("request_id")]
        public string? RequestId
        {
            get { return data.request_id; }
            set { data.request_id = value; }
        }

        [Column("integration_request_service")]
        public string? IntegrationRequestService
        {
            get { return data.integration_request_service; }
            set { data.integration_request_service = value; }
        }

        [Column("is_remote_request")]
        public int IsRemoteRequest
        {
            get { return data.is_remote_request; }
            set { data.is_remote_request = value; }
        }

        [Column("request_description")]
        public string? RequestDescription
        {
            get { return data.request_description; }
            set { data.request_description = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("url")]
        public string? Url
        {
            get { return data.url; }
            set { data.url = value; }
        }

        [Column("request_headers")]
        public string? RequestHeaders
        {
            get { return data.request_headers; }
            set { data.request_headers = value; }
        }

        [Column("data")]
        public string? Data
        {
            get { return data.data; }
            set { data.data = value; }
        }

        [Column("output")]
        public string? Output
        {
            get { return data.output; }
            set { data.output = value; }
        }

        [Column("error")]
        public string? Error
        {
            get { return data.error; }
            set { data.error = value; }
        }

        [Column("reference_doctype")]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        [Column("reference_docname")]
        public string? ReferenceDocname
        {
            get { return data.reference_docname; }
            set { data.reference_docname = value; }
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

