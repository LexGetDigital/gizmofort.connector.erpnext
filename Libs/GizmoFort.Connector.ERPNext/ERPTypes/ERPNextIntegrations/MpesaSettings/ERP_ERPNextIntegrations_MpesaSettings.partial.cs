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

namespace GizmoFort.Connector.ERPNext.ERPTypes.ERPNextIntegrations.MpesaSettings
{
    public partial class ERP_ERPNextIntegrations_MpesaSettings : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_ERPNextIntegrations_MpesaSettings() : this(new ERPObject(_DockType.ERPNextIntegrations_MpesaSettings)) { }
        public ERP_ERPNextIntegrations_MpesaSettings(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_ERPNextIntegrations_MpesaSettings>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_ERPNextIntegrations_MpesaSettings>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_ERPNextIntegrations_MpesaSettings>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_ERPNextIntegrations_MpesaSettings? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_ERPNextIntegrations_MpesaSettings>(json: json);
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

        [Column("payment_gateway_name")]
        public string? PaymentGatewayName
        {
            get { return data.payment_gateway_name; }
            set { data.payment_gateway_name = value; }
        }

        [Column("consumer_key")]
        public string? ConsumerKey
        {
            get { return data.consumer_key; }
            set { data.consumer_key = value; }
        }

        [Column("consumer_secret")]
        public string? ConsumerSecret
        {
            get { return data.consumer_secret; }
            set { data.consumer_secret = value; }
        }

        [Column("initiator_name")]
        public string? InitiatorName
        {
            get { return data.initiator_name; }
            set { data.initiator_name = value; }
        }

        [Column("till_number")]
        public string? TillNumber
        {
            get { return data.till_number; }
            set { data.till_number = value; }
        }

        [Column("transaction_limit")]
        public decimal TransactionLimit
        {
            get { return data.transaction_limit; }
            set { data.transaction_limit = value; }
        }

        [Column("sandbox")]
        public int Sandbox
        {
            get { return data.sandbox; }
            set { data.sandbox = value; }
        }

        [Column("business_shortcode")]
        public string? BusinessShortcode
        {
            get { return data.business_shortcode; }
            set { data.business_shortcode = value; }
        }

        [Column("online_passkey")]
        public string? OnlinePasskey
        {
            get { return data.online_passkey; }
            set { data.online_passkey = value; }
        }

        [Column("security_credential")]
        public string? SecurityCredential
        {
            get { return data.security_credential; }
            set { data.security_credential = value; }
        }

        [Column("account_balance")]
        public string? AccountBalance
        {
            get { return data.account_balance; }
            set { data.account_balance = value; }
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

