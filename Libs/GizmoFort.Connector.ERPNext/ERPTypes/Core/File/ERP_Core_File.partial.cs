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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.File
{
    public partial class ERP_Core_File : ERPNextObjectBase
    {
        public ERP_Core_File() : this(new ERPObject(_DocType.Core_File)) { }
        public ERP_Core_File(ERPObject obj) : base(obj) { }

        [ColumnInfo("file_size", "bigint(20)", isNullable: false)]
        public long FileSize
        {
            get { return data.file_size; }
            set { data.file_size = value; }
        }

        [ColumnInfo("attached_to_doctype", "varchar(140)", isNullable: true)]
        public string? AttachedToDoctype
        {
            get { return data.attached_to_doctype; }
            set { data.attached_to_doctype = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_private", "int(1)", isNullable: false)]
        public bool IsPrivate
        {
            get { return ERPNextConverter.IntToBool((int)data.is_private); }
            set { data.is_private = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_home_folder", "int(1)", isNullable: false)]
        public bool IsHomeFolder
        {
            get { return ERPNextConverter.IntToBool((int)data.is_home_folder); }
            set { data.is_home_folder = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_attachments_folder", "int(1)", isNullable: false)]
        public bool IsAttachmentsFolder
        {
            get { return ERPNextConverter.IntToBool((int)data.is_attachments_folder); }
            set { data.is_attachments_folder = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("thumbnail_url", "text", isNullable: true)]
        public string? ThumbnailUrl
        {
            get { return data.thumbnail_url; }
            set { data.thumbnail_url = value; }
        }

        [ColumnInfo("folder", "varchar(140)", isNullable: true)]
        public string? Folder
        {
            get { return data.folder; }
            set { data.folder = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("is_folder", "int(1)", isNullable: false)]
        public bool IsFolder
        {
            get { return ERPNextConverter.IntToBool((int)data.is_folder); }
            set { data.is_folder = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("attached_to_field", "varchar(140)", isNullable: true)]
        public string? AttachedToField
        {
            get { return data.attached_to_field; }
            set { data.attached_to_field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("old_parent", "varchar(140)", isNullable: true)]
        public string? OldParent
        {
            get { return data.old_parent; }
            set { data.old_parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("content_hash", "varchar(140)", isNullable: true)]
        public string? ContentHash
        {
            get { return data.content_hash; }
            set { data.content_hash = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("uploaded_to_dropbox", "int(1)", isNullable: false)]
        public bool UploadedToDropbox
        {
            get { return ERPNextConverter.IntToBool((int)data.uploaded_to_dropbox); }
            set { data.uploaded_to_dropbox = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("uploaded_to_google_drive", "int(1)", isNullable: false)]
        public bool UploadedToGoogleDrive
        {
            get { return ERPNextConverter.IntToBool((int)data.uploaded_to_google_drive); }
            set { data.uploaded_to_google_drive = ERPNextConverter.BoolToInt(value); }
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

        [ColumnInfo("name", "varchar(255)", isNullable: false)]
        public string Name
        {
            get { return data.name; }
            set { data.name = ERPNextConverter.TruncateString(value, 255); }
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

        [ColumnInfo("modified_by", "varchar(255)", isNullable: true)]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("owner", "varchar(255)", isNullable: true)]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("docstatus", "int(1)", isNullable: false)]
        public Docstatus Docstatus
        {
            get { return (Docstatus)data.docstatus; }
            set { data.docstatus = (int)value; }
        }

        [ColumnInfo("parent", "varchar(255)", isNullable: true)]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("parentfield", "varchar(255)", isNullable: true)]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("parenttype", "varchar(255)", isNullable: true)]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("idx", "int(8)", isNullable: false)]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [ColumnInfo("file_name", "varchar(140)", isNullable: true)]
        public string? FileName
        {
            get { return data.file_name; }
            set { data.file_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("file_url", "longtext", isNullable: true)]
        public string? FileUrl
        {
            get { return data.file_url; }
            set { data.file_url = value; }
        }

        [ColumnInfo("module", "varchar(255)", isNullable: true)]
        public string? Module
        {
            get { return data.module; }
            set { data.module = ERPNextConverter.TruncateString(value, 255); }
        }

        [ColumnInfo("attached_to_name", "varchar(140)", isNullable: true)]
        public string? AttachedToName
        {
            get { return data.attached_to_name; }
            set { data.attached_to_name = ERPNextConverter.TruncateString(value, 140); }
        }


    }
}

