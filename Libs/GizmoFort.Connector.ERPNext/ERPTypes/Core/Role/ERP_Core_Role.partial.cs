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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.Role
{
    public partial class ERP_Core_Role : ERPNextObjectBase
    {
        public ERP_Core_Role() : this(new ERPObject(_DocType.Core_Role)) { }
        public ERP_Core_Role(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Core_Role>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Core_Role>(columnName);
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

        [ColumnInfo("role_name", "varchar(140)", isNullable: true)]
        public string? RoleName
        {
            get { return data.role_name; }
            set { data.role_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("home_page", "varchar(140)", isNullable: true)]
        public string? HomePage
        {
            get { return data.home_page; }
            set { data.home_page = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("restrict_to_domain", "varchar(140)", isNullable: true)]
        public string? RestrictToDomain
        {
            get { return data.restrict_to_domain; }
            set { data.restrict_to_domain = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("disabled", "int(1)", isNullable: false)]
        public bool Disabled
        {
            get { return ERPNextConverter.IntToBool((int)data.disabled); }
            set { data.disabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_custom", "int(1)", isNullable: false)]
        public bool IsCustom
        {
            get { return ERPNextConverter.IntToBool((int)data.is_custom); }
            set { data.is_custom = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("desk_access", "int(1)", isNullable: false)]
        public bool DeskAccess
        {
            get { return ERPNextConverter.IntToBool((int)data.desk_access); }
            set { data.desk_access = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("two_factor_auth", "int(1)", isNullable: false)]
        public bool TwoFactorAuth
        {
            get { return ERPNextConverter.IntToBool((int)data.two_factor_auth); }
            set { data.two_factor_auth = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("search_bar", "int(1)", isNullable: false)]
        public bool SearchBar
        {
            get { return ERPNextConverter.IntToBool((int)data.search_bar); }
            set { data.search_bar = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("notifications", "int(1)", isNullable: false)]
        public bool Notifications
        {
            get { return ERPNextConverter.IntToBool((int)data.notifications); }
            set { data.notifications = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("list_sidebar", "int(1)", isNullable: false)]
        public bool ListSidebar
        {
            get { return ERPNextConverter.IntToBool((int)data.list_sidebar); }
            set { data.list_sidebar = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("bulk_actions", "int(1)", isNullable: false)]
        public bool BulkActions
        {
            get { return ERPNextConverter.IntToBool((int)data.bulk_actions); }
            set { data.bulk_actions = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("view_switcher", "int(1)", isNullable: false)]
        public bool ViewSwitcher
        {
            get { return ERPNextConverter.IntToBool((int)data.view_switcher); }
            set { data.view_switcher = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("form_sidebar", "int(1)", isNullable: false)]
        public bool FormSidebar
        {
            get { return ERPNextConverter.IntToBool((int)data.form_sidebar); }
            set { data.form_sidebar = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("timeline", "int(1)", isNullable: false)]
        public bool Timeline
        {
            get { return ERPNextConverter.IntToBool((int)data.timeline); }
            set { data.timeline = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("dashboard", "int(1)", isNullable: false)]
        public bool Dashboard
        {
            get { return ERPNextConverter.IntToBool((int)data.dashboard); }
            set { data.dashboard = ERPNextConverter.BoolToInt(value); }
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

