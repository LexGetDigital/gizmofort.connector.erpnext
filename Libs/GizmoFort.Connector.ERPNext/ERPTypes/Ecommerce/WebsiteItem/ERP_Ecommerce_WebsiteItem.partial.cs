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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ecommerce.WebsiteItem
{
    public partial class ERP_Ecommerce_WebsiteItem : ERPNextObjectBase
    {
        public ERP_Ecommerce_WebsiteItem() : this(new ERPObject(_DocType.Ecommerce_WebsiteItem)) { }
        public ERP_Ecommerce_WebsiteItem(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("web_item_name", "varchar(140)", isNullable: true)]
        public string? WebItemName
        {
            get { return data.web_item_name; }
            set { data.web_item_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("route", "text", isNullable: true)]
        public string? Route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        [ColumnInfo("has_variants", "int(1)", isNullable: false)]
        public bool HasVariants
        {
            get { return ERPNextConverter.IntToBool((int)data.has_variants); }
            set { data.has_variants = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("variant_of", "varchar(140)", isNullable: true)]
        public string? VariantOf
        {
            get { return data.variant_of; }
            set { data.variant_of = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("published", "int(1)", isNullable: false)]
        public bool Published
        {
            get { return ERPNextConverter.IntToBool((int)data.published); }
            set { data.published = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("item_code", "varchar(140)", isNullable: true)]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_name", "varchar(140)", isNullable: true)]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_group", "varchar(140)", isNullable: true)]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("stock_uom", "varchar(140)", isNullable: true)]
        public string? StockUom
        {
            get { return data.stock_uom; }
            set { data.stock_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("brand", "varchar(140)", isNullable: true)]
        public string? Brand
        {
            get { return data.brand; }
            set { data.brand = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("website_image", "text", isNullable: true)]
        public string? WebsiteImage
        {
            get { return data.website_image; }
            set { data.website_image = value; }
        }

        [ColumnInfo("website_image_alt", "varchar(140)", isNullable: true)]
        public string? WebsiteImageAlt
        {
            get { return data.website_image_alt; }
            set { data.website_image_alt = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("slideshow", "varchar(140)", isNullable: true)]
        public string? Slideshow
        {
            get { return data.slideshow; }
            set { data.slideshow = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("thumbnail", "varchar(140)", isNullable: true)]
        public string? Thumbnail
        {
            get { return data.thumbnail; }
            set { data.thumbnail = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("website_warehouse", "varchar(140)", isNullable: true)]
        public string? WebsiteWarehouse
        {
            get { return data.website_warehouse; }
            set { data.website_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("on_backorder", "int(1)", isNullable: false)]
        public bool OnBackorder
        {
            get { return ERPNextConverter.IntToBool((int)data.on_backorder); }
            set { data.on_backorder = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("short_description", "text", isNullable: true)]
        public string? ShortDescription
        {
            get { return data.short_description; }
            set { data.short_description = value; }
        }

        [ColumnInfo("web_long_description", "longtext", isNullable: true)]
        public string? WebLongDescription
        {
            get { return data.web_long_description; }
            set { data.web_long_description = value; }
        }

        [ColumnInfo("show_tabbed_section", "int(1)", isNullable: false)]
        public bool ShowTabbedSection
        {
            get { return ERPNextConverter.IntToBool((int)data.show_tabbed_section); }
            set { data.show_tabbed_section = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("ranking", "int(11)", isNullable: false)]
        public int Ranking
        {
            get { return data.ranking; }
            set { data.ranking = value; }
        }

        [ColumnInfo("website_content", "longtext", isNullable: true)]
        public string? WebsiteContent
        {
            get { return data.website_content; }
            set { data.website_content = value; }
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

