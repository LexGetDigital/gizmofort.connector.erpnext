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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.PackageRelease
{
    public partial class ERP_Core_PackageRelease : ERPNextObjectBase
    {
        public ERP_Core_PackageRelease() : this(new ERPObject(_DocType.Core_PackageRelease)) { }
        public ERP_Core_PackageRelease(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Core_PackageRelease>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Core_PackageRelease>(columnName);
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

        [ColumnInfo("package", "varchar(140)", isNullable: true)]
        public string? Package
        {
            get { return data.package; }
            set { data.package = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("publish", "int(1)", isNullable: false)]
        public bool Publish
        {
            get { return ERPNextConverter.IntToBool((int)data.publish); }
            set { data.publish = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("path", "text", isNullable: true)]
        public string? Path
        {
            get { return data.path; }
            set { data.path = value; }
        }

        [ColumnInfo("major", "int(11)", isNullable: false)]
        public int Major
        {
            get { return data.major; }
            set { data.major = value; }
        }

        [ColumnInfo("minor", "int(11)", isNullable: false)]
        public int Minor
        {
            get { return data.minor; }
            set { data.minor = value; }
        }

        [ColumnInfo("patch", "int(11)", isNullable: false)]
        public int Patch
        {
            get { return data.patch; }
            set { data.patch = value; }
        }

        [ColumnInfo("release_notes", "longtext", isNullable: true)]
        public string? ReleaseNotes
        {
            get { return data.release_notes; }
            set { data.release_notes = value; }
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

