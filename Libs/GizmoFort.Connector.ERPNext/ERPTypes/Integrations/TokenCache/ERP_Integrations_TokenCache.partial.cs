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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.TokenCache
{
    public partial class ERP_Integrations_TokenCache : ERPNextObjectBase
    {
        public ERP_Integrations_TokenCache() : this(new ERPObject(_DockType.Integrations_TokenCache)) { }
        public ERP_Integrations_TokenCache(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Integrations_TokenCache>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Integrations_TokenCache>(columnName);
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

        [Column("user")]
        public string? User
        {
            get { return data.user; }
            set { data.user = value; }
        }

        [Column("connected_app")]
        public string? ConnectedApp
        {
            get { return data.connected_app; }
            set { data.connected_app = value; }
        }

        [Column("provider_name")]
        public string? ProviderName
        {
            get { return data.provider_name; }
            set { data.provider_name = value; }
        }

        [Column("access_token")]
        public string? AccessToken
        {
            get { return data.access_token; }
            set { data.access_token = value; }
        }

        [Column("refresh_token")]
        public string? RefreshToken
        {
            get { return data.refresh_token; }
            set { data.refresh_token = value; }
        }

        [Column("expires_in")]
        public int ExpiresIn
        {
            get { return data.expires_in; }
            set { data.expires_in = value; }
        }

        [Column("state")]
        public string? State
        {
            get { return data.state; }
            set { data.state = value; }
        }

        [Column("success_uri")]
        public string? SuccessUri
        {
            get { return data.success_uri; }
            set { data.success_uri = value; }
        }

        [Column("token_type")]
        public string? TokenType
        {
            get { return data.token_type; }
            set { data.token_type = value; }
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

