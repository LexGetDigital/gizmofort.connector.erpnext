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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.Location
{
    public partial class ERP_Assets_Location : ERPNextObjectBase
    {
        public ERP_Assets_Location() : this(new ERPObject(_DocType.Assets_Location)) { }
        public ERP_Assets_Location(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("location_name", "varchar(140)", isNullable: true)]
        public string? LocationName
        {
            get { return data.location_name; }
            set { data.location_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parent_location", "varchar(140)", isNullable: true)]
        public string? ParentLocation
        {
            get { return data.parent_location; }
            set { data.parent_location = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_container", "int(1)", isNullable: false)]
        public bool IsContainer
        {
            get { return ERPNextConverter.IntToBool((int)data.is_container); }
            set { data.is_container = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_group", "int(1)", isNullable: false)]
        public bool IsGroup
        {
            get { return ERPNextConverter.IntToBool((int)data.is_group); }
            set { data.is_group = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("latitude", "decimal(21,9)", isNullable: false)]
        public decimal Latitude
        {
            get { return data.latitude; }
            set { data.latitude = value; }
        }

        [ColumnInfo("longitude", "decimal(21,9)", isNullable: false)]
        public decimal Longitude
        {
            get { return data.longitude; }
            set { data.longitude = value; }
        }

        [ColumnInfo("area", "decimal(21,9)", isNullable: false)]
        public decimal Area
        {
            get { return data.area; }
            set { data.area = value; }
        }

        [ColumnInfo("area_uom", "varchar(140)", isNullable: true)]
        public string? AreaUom
        {
            get { return data.area_uom; }
            set { data.area_uom = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("location", "longtext", isNullable: true)]
        public string? Location
        {
            get { return data.location; }
            set { data.location = value; }
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

