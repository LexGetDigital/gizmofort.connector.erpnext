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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.SocialLoginKey
{
    public partial class ERP_Integrations_SocialLoginKey : ERPNextObjectBase
    {
        public ERP_Integrations_SocialLoginKey() : this(new ERPObject(_DocType.Integrations_SocialLoginKey)) { }
        public ERP_Integrations_SocialLoginKey(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("enable_social_login", "int(1)", isNullable: false)]
        public bool EnableSocialLogin
        {
            get { return ERPNextConverter.IntToBool((int)data.enable_social_login); }
            set { data.enable_social_login = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("social_login_provider", "varchar(140)", isNullable: true)]
        public string? SocialLoginProvider
        {
            get { return data.social_login_provider; }
            set { data.social_login_provider = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("client_id", "varchar(140)", isNullable: true)]
        public string? ClientId
        {
            get { return data.client_id; }
            set { data.client_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("provider_name", "varchar(140)", isNullable: true)]
        public string? ProviderName
        {
            get { return data.provider_name; }
            set { data.provider_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("client_secret", "text", isNullable: true)]
        public string? ClientSecret
        {
            get { return data.client_secret; }
            set { data.client_secret = value; }
        }

        [ColumnInfo("icon", "varchar(140)", isNullable: true)]
        public string? Icon
        {
            get { return data.icon; }
            set { data.icon = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("base_url", "varchar(140)", isNullable: true)]
        public string? BaseUrl
        {
            get { return data.base_url; }
            set { data.base_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("authorize_url", "varchar(140)", isNullable: true)]
        public string? AuthorizeUrl
        {
            get { return data.authorize_url; }
            set { data.authorize_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("access_token_url", "varchar(140)", isNullable: true)]
        public string? AccessTokenUrl
        {
            get { return data.access_token_url; }
            set { data.access_token_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("redirect_url", "varchar(140)", isNullable: true)]
        public string? RedirectUrl
        {
            get { return data.redirect_url; }
            set { data.redirect_url = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("api_endpoint", "varchar(140)", isNullable: true)]
        public string? ApiEndpoint
        {
            get { return data.api_endpoint; }
            set { data.api_endpoint = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("custom_base_url", "int(1)", isNullable: false)]
        public bool CustomBaseUrl
        {
            get { return ERPNextConverter.IntToBool((int)data.custom_base_url); }
            set { data.custom_base_url = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("api_endpoint_args", "longtext", isNullable: true)]
        public string? ApiEndpointArgs
        {
            get { return data.api_endpoint_args; }
            set { data.api_endpoint_args = value; }
        }

        [ColumnInfo("auth_url_data", "longtext", isNullable: true)]
        public string? AuthUrlData
        {
            get { return data.auth_url_data; }
            set { data.auth_url_data = value; }
        }

        [ColumnInfo("user_id_property", "varchar(140)", isNullable: true)]
        public string? UserIdProperty
        {
            get { return data.user_id_property; }
            set { data.user_id_property = ERPNextConverter.TruncateString(value, 140); }
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

