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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.SalesPartner
{
    public partial class ERP_Setup_SalesPartner : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Setup_SalesPartner() : this(new ERPObject(_DockType.Setup_SalesPartner)) { }
        public ERP_Setup_SalesPartner(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Setup_SalesPartner>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Setup_SalesPartner>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Setup_SalesPartner>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Setup_SalesPartner? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Setup_SalesPartner>(json: json);
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

        [Column("partner_name")]
        public string? PartnerName
        {
            get { return data.partner_name; }
            set { data.partner_name = value; }
        }

        [Column("partner_type")]
        public string? PartnerType
        {
            get { return data.partner_type; }
            set { data.partner_type = value; }
        }

        [Column("territory")]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        [Column("commission_rate")]
        public decimal CommissionRate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = value; }
        }

        [Column("show_in_website")]
        public int ShowInWebsite
        {
            get { return data.show_in_website; }
            set { data.show_in_website = value; }
        }

        [Column("referral_code")]
        public string? ReferralCode
        {
            get { return data.referral_code; }
            set { data.referral_code = value; }
        }

        [Column("route")]
        public string? Route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        [Column("logo")]
        public string? Logo
        {
            get { return data.logo; }
            set { data.logo = value; }
        }

        [Column("partner_website")]
        public string? PartnerWebsite
        {
            get { return data.partner_website; }
            set { data.partner_website = value; }
        }

        [Column("introduction")]
        public string? Introduction
        {
            get { return data.introduction; }
            set { data.introduction = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
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

