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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.OAuthAuthorizationCode
{
    public partial class ERP_Integrations_OAuthAuthorizationCode : ERPNextObjectBase
    {
        public ERP_Integrations_OAuthAuthorizationCode() : this(new ERPObject(_DocType.Integrations_OAuthAuthorizationCode)) { }
        public ERP_Integrations_OAuthAuthorizationCode(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("client", "varchar(140)", isNullable: true)]
        public string? Client
        {
            get { return data.client; }
            set { data.client = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("user", "varchar(140)", isNullable: true)]
        public string? User
        {
            get { return data.user; }
            set { data.user = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("scopes", "text", isNullable: true)]
        public string? Scopes
        {
            get { return data.scopes; }
            set { data.scopes = value; }
        }

        [ColumnInfo("authorization_code", "varchar(140)", isNullable: true)]
        public string? AuthorizationCode
        {
            get { return data.authorization_code; }
            set { data.authorization_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("expiration_time", "datetime(6)", isNullable: true)]
        public DateTimeOffset? ExpirationTime
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.expiration_time); }
            set { data.expiration_time = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("redirect_uri_bound_to_authorization_code", "varchar(140)", isNullable: true)]
        public string? RedirectUriBoundToAuthorizationCode
        {
            get { return data.redirect_uri_bound_to_authorization_code; }
            set { data.redirect_uri_bound_to_authorization_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("validity", "varchar(140)", isNullable: true)]
        public string? Validity
        {
            get { return data.validity; }
            set { data.validity = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("nonce", "varchar(140)", isNullable: true)]
        public string? Nonce
        {
            get { return data.nonce; }
            set { data.nonce = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("code_challenge", "varchar(140)", isNullable: true)]
        public string? CodeChallenge
        {
            get { return data.code_challenge; }
            set { data.code_challenge = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("code_challenge_method", "varchar(140)", isNullable: true)]
        public string? CodeChallengeMethod
        {
            get { return data.code_challenge_method; }
            set { data.code_challenge_method = ERPNextConverter.TruncateString(value, 140); }
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

