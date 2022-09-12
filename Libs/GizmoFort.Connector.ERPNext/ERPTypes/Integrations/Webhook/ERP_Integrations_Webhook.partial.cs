/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/11/2022 7:52:10 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.Webhook
{
    public partial class ERP_Integrations_Webhook : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Integrations_Webhook() : this(new ERPObject(_DockType.Integrations_Webhook)) { }
        public ERP_Integrations_Webhook(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Integrations_Webhook>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Integrations_Webhook>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Integrations_Webhook>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Integrations_Webhook? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Integrations_Webhook>(json: json);
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

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("webhook_doctype")]
        public string? WebhookDoctype
        {
            get { return data.webhook_doctype; }
            set { data.webhook_doctype = value; }
        }

        [Column("webhook_docevent")]
        public string? WebhookDocevent
        {
            get { return data.webhook_docevent; }
            set { data.webhook_docevent = value; }
        }

        [Column("enabled")]
        public int Enabled
        {
            get { return data.enabled; }
            set { data.enabled = value; }
        }

        [Column("condition")]
        public string? Condition
        {
            get { return data.condition; }
            set { data.condition = value; }
        }

        [Column("request_url")]
        public string? RequestUrl
        {
            get { return data.request_url; }
            set { data.request_url = value; }
        }

        [Column("request_method")]
        public string? RequestMethod
        {
            get { return data.request_method; }
            set { data.request_method = value; }
        }

        [Column("request_structure")]
        public string? RequestStructure
        {
            get { return data.request_structure; }
            set { data.request_structure = value; }
        }

        [Column("enable_security")]
        public int EnableSecurity
        {
            get { return data.enable_security; }
            set { data.enable_security = value; }
        }

        [Column("webhook_secret")]
        public string? WebhookSecret
        {
            get { return data.webhook_secret; }
            set { data.webhook_secret = value; }
        }

        [Column("webhook_json")]
        public string? WebhookJson
        {
            get { return data.webhook_json; }
            set { data.webhook_json = value; }
        }

        [Column("preview_document")]
        public string? PreviewDocument
        {
            get { return data.preview_document; }
            set { data.preview_document = value; }
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

