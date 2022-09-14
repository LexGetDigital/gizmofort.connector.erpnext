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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Automation.AssignmentRule
{
    public partial class ERP_Automation_AssignmentRule : ERPNextObjectBase
    {
        public ERP_Automation_AssignmentRule() : this(new ERPObject(_DocType.Automation_AssignmentRule)) { }
        public ERP_Automation_AssignmentRule(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Automation_AssignmentRule>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Automation_AssignmentRule>(columnName);
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

        [ColumnInfo("document_type", "varchar(140)", isNullable: true)]
        public string? DocumentType
        {
            get { return data.document_type; }
            set { data.document_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("due_date_based_on", "varchar(140)", isNullable: true)]
        public string? DueDateBasedOn
        {
            get { return data.due_date_based_on; }
            set { data.due_date_based_on = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("priority", "int(11)", isNullable: false)]
        public int Priority
        {
            get { return data.priority; }
            set { data.priority = value; }
        }

        [ColumnInfo("disabled", "int(1)", isNullable: false)]
        public bool Disabled
        {
            get { return ERPNextConverter.IntToBool((int)data.disabled); }
            set { data.disabled = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("description", "text", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("assign_condition", "longtext", isNullable: true)]
        public string? AssignCondition
        {
            get { return data.assign_condition; }
            set { data.assign_condition = value; }
        }

        [ColumnInfo("unassign_condition", "longtext", isNullable: true)]
        public string? UnassignCondition
        {
            get { return data.unassign_condition; }
            set { data.unassign_condition = value; }
        }

        [ColumnInfo("close_condition", "longtext", isNullable: true)]
        public string? CloseCondition
        {
            get { return data.close_condition; }
            set { data.close_condition = value; }
        }

        [ColumnInfo("rule", "varchar(140)", isNullable: true)]
        public string? Rule
        {
            get { return data.rule; }
            set { data.rule = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("field", "varchar(140)", isNullable: true)]
        public string? Field
        {
            get { return data.field; }
            set { data.field = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("last_user", "varchar(140)", isNullable: true)]
        public string? LastUser
        {
            get { return data.last_user; }
            set { data.last_user = ERPNextConverter.TruncateString(value, 140); }
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

