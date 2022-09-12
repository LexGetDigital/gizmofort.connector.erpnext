/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/12/2022 2:29:08 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Ecommerce.RecommendedItems
{
    public partial class ERP_Ecommerce_RecommendedItems : ERPNextObjectBase
    {
        public ERP_Ecommerce_RecommendedItems() : this(new ERPObject(_DockType.Ecommerce_RecommendedItems)) { }
        public ERP_Ecommerce_RecommendedItems(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Ecommerce_RecommendedItems>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Ecommerce_RecommendedItems>(columnName);
        }


        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTimeOffset? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTimeOffset? Modified
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

        [Column("website_item")]
        public string? WebsiteItem
        {
            get { return data.website_item; }
            set { data.website_item = value; }
        }

        [Column("website_item_name")]
        public string? WebsiteItemName
        {
            get { return data.website_item_name; }
            set { data.website_item_name = value; }
        }

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("route")]
        public string? Route
        {
            get { return data.route; }
            set { data.route = value; }
        }

        [Column("website_item_image")]
        public string? WebsiteItemImage
        {
            get { return data.website_item_image; }
            set { data.website_item_image = value; }
        }

        [Column("website_item_thumbnail")]
        public string? WebsiteItemThumbnail
        {
            get { return data.website_item_thumbnail; }
            set { data.website_item_thumbnail = value; }
        }

        [Column("parent")]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = value; }
        }

        [Column("parentfield")]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = value; }
        }

        [Column("parenttype")]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = value; }
        }


    }
}

