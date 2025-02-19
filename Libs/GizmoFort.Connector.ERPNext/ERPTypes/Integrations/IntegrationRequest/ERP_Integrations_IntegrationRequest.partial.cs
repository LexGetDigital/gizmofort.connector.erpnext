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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.IntegrationRequest
{
    public partial class ERP_Integrations_IntegrationRequest : ERPNextObjectBase
    {
        public ERP_Integrations_IntegrationRequest() : this(new ERPObject(_DocType.Integrations_IntegrationRequest)) { }
        public ERP_Integrations_IntegrationRequest(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("request_id", "varchar(140)", isNullable: true)]
        public string? RequestId
        {
            get { return data.request_id; }
            set { data.request_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("integration_request_service", "varchar(140)", isNullable: true)]
        public string? IntegrationRequestService
        {
            get { return data.integration_request_service; }
            set { data.integration_request_service = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_remote_request", "int(1)", isNullable: false)]
        public bool IsRemoteRequest
        {
            get { return ERPNextConverter.IntToBool((int)data.is_remote_request); }
            set { data.is_remote_request = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("request_description", "varchar(140)", isNullable: true)]
        public string? RequestDescription
        {
            get { return data.request_description; }
            set { data.request_description = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("url", "varchar(140)", isNullable: true)]
        public string? Url
        {
            get { return data.url; }
            set { data.url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("request_headers", "longtext", isNullable: true)]
        public string? RequestHeaders
        {
            get { return data.request_headers; }
            set { data.request_headers = value; }
        }

        [ColumnInfo("data", "longtext", isNullable: true)]
        public string? Data
        {
            get { return data.data; }
            set { data.data = value; }
        }

        [ColumnInfo("output", "longtext", isNullable: true)]
        public string? Output
        {
            get { return data.output; }
            set { data.output = value; }
        }

        [ColumnInfo("error", "longtext", isNullable: true)]
        public string? Error
        {
            get { return data.error; }
            set { data.error = value; }
        }

        [ColumnInfo("reference_doctype", "varchar(140)", isNullable: true)]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_docname", "varchar(140)", isNullable: true)]
        public string? ReferenceDocname
        {
            get { return data.reference_docname; }
            set { data.reference_docname = ERPNextConverter.TruncateString(value, 140); }
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

