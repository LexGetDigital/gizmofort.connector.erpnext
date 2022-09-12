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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Desk.DesktopIcon
{
    public partial class ERP_Desk_DesktopIcon : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Desk_DesktopIcon() : this(new ERPObject(_DockType.Desk_DesktopIcon)) { }
        public ERP_Desk_DesktopIcon(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Desk_DesktopIcon>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Desk_DesktopIcon>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Desk_DesktopIcon>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Desk_DesktopIcon? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Desk_DesktopIcon>(json: json);
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

        [Column("module_name")]
        public string? ModuleName
        {
            get { return data.module_name; }
            set { data.module_name = value; }
        }

        [Column("label")]
        public string? Label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        [Column("standard")]
        public int Standard
        {
            get { return data.standard; }
            set { data.standard = value; }
        }

        [Column("custom")]
        public int Custom
        {
            get { return data.custom; }
            set { data.custom = value; }
        }

        [Column("app")]
        public string? App
        {
            get { return data.app; }
            set { data.app = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("category")]
        public string? Category
        {
            get { return data.category; }
            set { data.category = value; }
        }

        [Column("hidden")]
        public int Hidden
        {
            get { return data.hidden; }
            set { data.hidden = value; }
        }

        [Column("blocked")]
        public int Blocked
        {
            get { return data.blocked; }
            set { data.blocked = value; }
        }

        [Column("force_show")]
        public int ForceShow
        {
            get { return data.force_show; }
            set { data.force_show = value; }
        }

        [Column("type")]
        public string? Type
        {
            get { return data.type; }
            set { data.type = value; }
        }

        [Column("_doctype")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Doctype
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._doctype; }
            set { data._doctype = value; }
        }

        [Column("_report")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Report
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._report; }
            set { data._report = value; }
        }

        [Column("link")]
        public string? Link
        {
            get { return data.link; }
            set { data.link = value; }
        }

        [Column("color")]
        public string? Color
        {
            get { return data.color; }
            set { data.color = value; }
        }

        [Column("icon")]
        public string? Icon
        {
            get { return data.icon; }
            set { data.icon = value; }
        }

        [Column("reverse")]
        public int Reverse
        {
            get { return data.reverse; }
            set { data.reverse = value; }
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

