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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.OAuthClient
{
    public partial class ERP_Integrations_OAuthClient : ERPNextObjectBase
    {
        public ERP_Integrations_OAuthClient() : this(new ERPObject(_DocType.Integrations_OAuthClient)) { }
        public ERP_Integrations_OAuthClient(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("client_id", "varchar(140)", isNullable: true)]
        public string? ClientId
        {
            get { return data.client_id; }
            set { data.client_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("app_name", "varchar(140)", isNullable: true)]
        public string? AppName
        {
            get { return data.app_name; }
            set { data.app_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("user", "varchar(140)", isNullable: true)]
        public string? User
        {
            get { return data.user; }
            set { data.user = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("client_secret", "varchar(140)", isNullable: true)]
        public string? ClientSecret
        {
            get { return data.client_secret; }
            set { data.client_secret = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("skip_authorization", "int(1)", isNullable: false)]
        public bool SkipAuthorization
        {
            get { return ERPNextConverter.IntToBool((int)data.skip_authorization); }
            set { data.skip_authorization = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("scopes", "text", isNullable: true)]
        public string? Scopes
        {
            get { return data.scopes; }
            set { data.scopes = value; }
        }

        [ColumnInfo("redirect_uris", "text", isNullable: true)]
        public string? RedirectUris
        {
            get { return data.redirect_uris; }
            set { data.redirect_uris = value; }
        }

        [ColumnInfo("default_redirect_uri", "varchar(140)", isNullable: true)]
        public string? DefaultRedirectUri
        {
            get { return data.default_redirect_uri; }
            set { data.default_redirect_uri = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("grant_type", "varchar(140)", isNullable: true)]
        public string? GrantType
        {
            get { return data.grant_type; }
            set { data.grant_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("response_type", "varchar(140)", isNullable: true)]
        public string? ResponseType
        {
            get { return data.response_type; }
            set { data.response_type = ERPNextConverter.TruncateString(value, 140); }
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

