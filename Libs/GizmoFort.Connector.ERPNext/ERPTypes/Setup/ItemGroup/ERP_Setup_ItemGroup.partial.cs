/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/13/2022 7:48:39 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.ItemGroup
{
    public partial class ERP_Setup_ItemGroup : ERPNextObjectBase
    {
        public ERP_Setup_ItemGroup() : this(new ERPObject(_DocType.Setup_ItemGroup)) { }
        public ERP_Setup_ItemGroup(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Setup_ItemGroup>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Setup_ItemGroup>(columnName);
        //}

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

        [ColumnInfo("item_group_name", "varchar(140)", isNullable: true)]
        public string? ItemGroupName
        {
            get { return data.item_group_name; }
            set { data.item_group_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parent_item_group", "varchar(140)", isNullable: true)]
        public string? ParentItemGroup
        {
            get { return data.parent_item_group; }
            set { data.parent_item_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_group", "int(1)", isNullable: false)]
        public bool IsGroup
        {
            get { return ERPNextConverter.IntToBool((int)data.is_group); }
            set { data.is_group = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("route", "varchar(140)", isNullable: true)]
        public string? Route
        {
            get { return data.route; }
            set { data.route = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("website_title", "varchar(140)", isNullable: true)]
        public string? WebsiteTitle
        {
            get { return data.website_title; }
            set { data.website_title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "longtext", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("show_in_website", "int(1)", isNullable: false)]
        public bool ShowInWebsite
        {
            get { return ERPNextConverter.IntToBool((int)data.show_in_website); }
            set { data.show_in_website = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("include_descendants", "int(1)", isNullable: false)]
        public bool IncludeDescendants
        {
            get { return ERPNextConverter.IntToBool((int)data.include_descendants); }
            set { data.include_descendants = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("weightage", "int(11)", isNullable: false)]
        public int Weightage
        {
            get { return data.weightage; }
            set { data.weightage = value; }
        }

        [ColumnInfo("slideshow", "varchar(140)", isNullable: true)]
        public string? Slideshow
        {
            get { return data.slideshow; }
            set { data.slideshow = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lft", "int(11)", isNullable: false)]
        public int Lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        [ColumnInfo("rgt", "int(11)", isNullable: false)]
        public int Rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        [ColumnInfo("old_parent", "varchar(140)", isNullable: true)]
        public string? OldParent
        {
            get { return data.old_parent; }
            set { data.old_parent = ERPNextConverter.TruncateString(value, 140); }
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

