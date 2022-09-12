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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Custom.CustomField
{
    public partial class ERP_Custom_CustomField : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Custom_CustomField() : this(new ERPObject(_DockType.Custom_CustomField)) { }
        public ERP_Custom_CustomField(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Custom_CustomField>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Custom_CustomField>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Custom_CustomField>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Custom_CustomField? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Custom_CustomField>(json: json);
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

        [Column("is_system_generated")]
        public int IsSystemGenerated
        {
            get { return data.is_system_generated; }
            set { data.is_system_generated = value; }
        }

        [Column("dt")]
        public string? Dt
        {
            get { return data.dt; }
            set { data.dt = value; }
        }

        [Column("module")]
        public string? Module
        {
            get { return data.module; }
            set { data.module = value; }
        }

        [Column("label")]
        public string? Label
        {
            get { return data.label; }
            set { data.label = value; }
        }

        [Column("fieldname")]
        public string? Fieldname
        {
            get { return data.fieldname; }
            set { data.fieldname = value; }
        }

        [Column("insert_after")]
        public string? InsertAfter
        {
            get { return data.insert_after; }
            set { data.insert_after = value; }
        }

        [Column("length")]
        public int Length
        {
            get { return data.length; }
            set { data.length = value; }
        }

        [Column("fieldtype")]
        public string? Fieldtype
        {
            get { return data.fieldtype; }
            set { data.fieldtype = value; }
        }

        [Column("precision")]
        public string? Precision
        {
            get { return data.precision; }
            set { data.precision = value; }
        }

        [Column("hide_seconds")]
        public int HideSeconds
        {
            get { return data.hide_seconds; }
            set { data.hide_seconds = value; }
        }

        [Column("hide_days")]
        public int HideDays
        {
            get { return data.hide_days; }
            set { data.hide_days = value; }
        }

        [Column("options")]
        public string? Options
        {
            get { return data.options; }
            set { data.options = value; }
        }

        [Column("fetch_from")]
        public string? FetchFrom
        {
            get { return data.fetch_from; }
            set { data.fetch_from = value; }
        }

        [Column("fetch_if_empty")]
        public int FetchIfEmpty
        {
            get { return data.fetch_if_empty; }
            set { data.fetch_if_empty = value; }
        }

        [Column("collapsible")]
        public int Collapsible
        {
            get { return data.collapsible; }
            set { data.collapsible = value; }
        }

        [Column("collapsible_depends_on")]
        public string? CollapsibleDependsOn
        {
            get { return data.collapsible_depends_on; }
            set { data.collapsible_depends_on = value; }
        }

        [Column("@default")]
        public string? Default
        {
            get { return data.@default; }
            set { data.@default = value; }
        }

        [Column("depends_on")]
        public string? DependsOn
        {
            get { return data.depends_on; }
            set { data.depends_on = value; }
        }

        [Column("mandatory_depends_on")]
        public string? MandatoryDependsOn
        {
            get { return data.mandatory_depends_on; }
            set { data.mandatory_depends_on = value; }
        }

        [Column("read_only_depends_on")]
        public string? ReadOnlyDependsOn
        {
            get { return data.read_only_depends_on; }
            set { data.read_only_depends_on = value; }
        }

        [Column("non_negative")]
        public int NonNegative
        {
            get { return data.non_negative; }
            set { data.non_negative = value; }
        }

        [Column("reqd")]
        public int Reqd
        {
            get { return data.reqd; }
            set { data.reqd = value; }
        }

        [Column("unique")]
        public int Unique
        {
            get { return data.unique; }
            set { data.unique = value; }
        }

        [Column("is_virtual")]
        public int IsVirtual
        {
            get { return data.is_virtual; }
            set { data.is_virtual = value; }
        }

        [Column("read_only")]
        public int ReadOnly
        {
            get { return data.read_only; }
            set { data.read_only = value; }
        }

        [Column("ignore_user_permissions")]
        public int IgnoreUserPermissions
        {
            get { return data.ignore_user_permissions; }
            set { data.ignore_user_permissions = value; }
        }

        [Column("hidden")]
        public int Hidden
        {
            get { return data.hidden; }
            set { data.hidden = value; }
        }

        [Column("print_hide")]
        public int PrintHide
        {
            get { return data.print_hide; }
            set { data.print_hide = value; }
        }

        [Column("print_hide_if_no_value")]
        public int PrintHideIfNoValue
        {
            get { return data.print_hide_if_no_value; }
            set { data.print_hide_if_no_value = value; }
        }

        [Column("print_width")]
        public string? PrintWidth
        {
            get { return data.print_width; }
            set { data.print_width = value; }
        }

        [Column("no_copy")]
        public int NoCopy
        {
            get { return data.no_copy; }
            set { data.no_copy = value; }
        }

        [Column("allow_on_submit")]
        public int AllowOnSubmit
        {
            get { return data.allow_on_submit; }
            set { data.allow_on_submit = value; }
        }

        [Column("in_list_view")]
        public int InListView
        {
            get { return data.in_list_view; }
            set { data.in_list_view = value; }
        }

        [Column("in_standard_filter")]
        public int InStandardFilter
        {
            get { return data.in_standard_filter; }
            set { data.in_standard_filter = value; }
        }

        [Column("in_global_search")]
        public int InGlobalSearch
        {
            get { return data.in_global_search; }
            set { data.in_global_search = value; }
        }

        [Column("in_preview")]
        public int InPreview
        {
            get { return data.in_preview; }
            set { data.in_preview = value; }
        }

        [Column("bold")]
        public int Bold
        {
            get { return data.bold; }
            set { data.bold = value; }
        }

        [Column("report_hide")]
        public int ReportHide
        {
            get { return data.report_hide; }
            set { data.report_hide = value; }
        }

        [Column("search_index")]
        public int SearchIndex
        {
            get { return data.search_index; }
            set { data.search_index = value; }
        }

        [Column("allow_in_quick_entry")]
        public int AllowInQuickEntry
        {
            get { return data.allow_in_quick_entry; }
            set { data.allow_in_quick_entry = value; }
        }

        [Column("ignore_xss_filter")]
        public int IgnoreXssFilter
        {
            get { return data.ignore_xss_filter; }
            set { data.ignore_xss_filter = value; }
        }

        [Column("translatable")]
        public int Translatable
        {
            get { return data.translatable; }
            set { data.translatable = value; }
        }

        [Column("hide_border")]
        public int HideBorder
        {
            get { return data.hide_border; }
            set { data.hide_border = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("permlevel")]
        public int Permlevel
        {
            get { return data.permlevel; }
            set { data.permlevel = value; }
        }

        [Column("width")]
        public string? Width
        {
            get { return data.width; }
            set { data.width = value; }
        }

        [Column("columns")]
        public int Columns
        {
            get { return data.columns; }
            set { data.columns = value; }
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

