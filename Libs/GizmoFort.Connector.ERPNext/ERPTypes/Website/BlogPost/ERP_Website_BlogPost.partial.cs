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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Website.BlogPost
{
    public partial class ERP_Website_BlogPost : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Website_BlogPost() : this(new ERPObject(_DockType.Website_BlogPost)) { }
        public ERP_Website_BlogPost(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Website_BlogPost>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Website_BlogPost>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Website_BlogPost>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Website_BlogPost? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Website_BlogPost>(json: json);
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

        [Column("title")]
        public string? Title
        {
            get { return data.title; }
            set { data.title = value; }
        }

        [Column("blog_category")]
        public string? BlogCategory
        {
            get { return data.blog_category; }
            set { data.blog_category = value; }
        }

        [Column("blogger")]
        public string? Blogger
        {
            get { return data.blogger; }
            set { data.blogger = value; }
        }

        [Column("route")]
        public string? Route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        [Column("read_time")]
        public int ReadTime
        {
            get { return data.read_time; }
            set { data.read_time = value; }
        }

        [Column("published_on")]
        public DateOnly? PublishedOn
        {
            get { return data.published_on; }
            set { data.published_on = value; }
        }

        [Column("published")]
        public int Published
        {
            get { return data.published; }
            set { data.published = value; }
        }

        [Column("featured")]
        public int Featured
        {
            get { return data.featured; }
            set { data.featured = value; }
        }

        [Column("hide_cta")]
        public int HideCta
        {
            get { return data.hide_cta; }
            set { data.hide_cta = value; }
        }

        [Column("enable_email_notification")]
        public int EnableEmailNotification
        {
            get { return data.enable_email_notification; }
            set { data.enable_email_notification = value; }
        }

        [Column("disable_comments")]
        public int DisableComments
        {
            get { return data.disable_comments; }
            set { data.disable_comments = value; }
        }

        [Column("disable_likes")]
        public int DisableLikes
        {
            get { return data.disable_likes; }
            set { data.disable_likes = value; }
        }

        [Column("blog_intro")]
        public string? BlogIntro
        {
            get { return data.blog_intro; }
            set { data.blog_intro = value; }
        }

        [Column("content_type")]
        public string? ContentType
        {
            get { return data.content_type; }
            set { data.content_type = value; }
        }

        [Column("content")]
        public string? Content
        {
            get { return data.content; }
            set { data.content = value; }
        }

        [Column("content_md")]
        public string? ContentMd
        {
            get { return data.content_md; }
            set { data.content_md = value; }
        }

        [Column("content_html")]
        public string? ContentHtml
        {
            get { return data.content_html; }
            set { data.content_html = value; }
        }

        [Column("email_sent")]
        public int EmailSent
        {
            get { return data.email_sent; }
            set { data.email_sent = value; }
        }

        [Column("meta_title")]
        public string? MetaTitle
        {
            get { return data.meta_title; }
            set { data.meta_title = value; }
        }

        [Column("meta_description")]
        public string? MetaDescription
        {
            get { return data.meta_description; }
            set { data.meta_description = value; }
        }

        [Column("meta_image")]
        public string? MetaImage
        {
            get { return data.meta_image; }
            set { data.meta_image = value; }
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

