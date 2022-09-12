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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ecommerce.WebsiteItem
{
    public partial class ERP_Ecommerce_WebsiteItem : ERPNextObjectBase
    {
        public ERP_Ecommerce_WebsiteItem() : this(new ERPObject(_DockType.Ecommerce_WebsiteItem)) { }
        public ERP_Ecommerce_WebsiteItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Ecommerce_WebsiteItem>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Ecommerce_WebsiteItem>(columnName);
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

        [Column("web_item_name")]
        public string? WebItemName
        {
            get { return data.web_item_name; }
            set { data.web_item_name = value; }
        }

        [Column("route")]
        public string? Route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        [Column("has_variants")]
        public int HasVariants
        {
            get { return data.has_variants; }
            set { data.has_variants = value; }
        }

        [Column("variant_of")]
        public string? VariantOf
        {
            get { return data.variant_of; }
            set { data.variant_of = value; }
        }

        [Column("published")]
        public int Published
        {
            get { return data.published; }
            set { data.published = value; }
        }

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("item_group")]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        [Column("stock_uom")]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("brand")]
        public string? Brand
        {
            get { return data.brand; }
            set { data.brand = value; }
        }

        [Column("website_image")]
        public string? WebsiteImage
        {
            get { return data.website_image; }
            set { data.website_image = value; }
        }

        [Column("website_image_alt")]
        public string? WebsiteImageAlt
        {
            get { return data.website_image_alt; }
            set { data.website_image_alt = value; }
        }

        [Column("slideshow")]
        public string? Slideshow
        {
            get { return data.slideshow; }
            set { data.slideshow = value; }
        }

        [Column("thumbnail")]
        public string? Thumbnail
        {
            get { return data.thumbnail; }
            set { data.thumbnail = value; }
        }

        [Column("website_warehouse")]
        public string? WebsiteWarehouse
        {
            get { return data.website_warehouse; }
            set { data.website_warehouse = value; }
        }

        [Column("on_backorder")]
        public int OnBackorder
        {
            get { return data.on_backorder; }
            set { data.on_backorder = value; }
        }

        [Column("short_description")]
        public string? ShortDescription
        {
            get { return data.short_description; }
            set { data.short_description = value; }
        }

        [Column("web_long_description")]
        public string? WebLongDescription
        {
            get { return data.web_long_description; }
            set { data.web_long_description = value; }
        }

        [Column("show_tabbed_section")]
        public int ShowTabbedSection
        {
            get { return data.show_tabbed_section; }
            set { data.show_tabbed_section = value; }
        }

        [Column("ranking")]
        public int Ranking
        {
            get { return data.ranking; }
            set { data.ranking = value; }
        }

        [Column("website_content")]
        public string? WebsiteContent
        {
            get { return data.website_content; }
            set { data.website_content = value; }
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

