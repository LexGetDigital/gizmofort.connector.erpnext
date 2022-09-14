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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Buying.SupplierScorecardScoringStanding
{
    public partial class ERP_Buying_SupplierScorecardScoringStanding : ERPNextObjectBase
    {
        public ERP_Buying_SupplierScorecardScoringStanding() : this(new ERPObject(_DocType.Buying_SupplierScorecardScoringStanding)) { }
        public ERP_Buying_SupplierScorecardScoringStanding(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("standing_name", "varchar(140)", isNullable: true)]
        public string? StandingName
        {
            get { return data.standing_name; }
            set { data.standing_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("standing_color", "varchar(140)", isNullable: true)]
        public string? StandingColor
        {
            get { return data.standing_color; }
            set { data.standing_color = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("min_grade", "decimal(21,9)", isNullable: false)]
        public decimal MinGrade
        {
            get { return data.min_grade; }
            set { data.min_grade = value; }
        }

        [ColumnInfo("max_grade", "decimal(21,9)", isNullable: false)]
        public decimal MaxGrade
        {
            get { return data.max_grade; }
            set { data.max_grade = value; }
        }

        [ColumnInfo("warn_rfqs", "int(1)", isNullable: false)]
        public bool WarnRfqs
        {
            get { return ERPNextConverter.IntToBool((int)data.warn_rfqs); }
            set { data.warn_rfqs = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("warn_pos", "int(1)", isNullable: false)]
        public bool WarnPos
        {
            get { return ERPNextConverter.IntToBool((int)data.warn_pos); }
            set { data.warn_pos = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("prevent_rfqs", "int(1)", isNullable: false)]
        public bool PreventRfqs
        {
            get { return ERPNextConverter.IntToBool((int)data.prevent_rfqs); }
            set { data.prevent_rfqs = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("prevent_pos", "int(1)", isNullable: false)]
        public bool PreventPos
        {
            get { return ERPNextConverter.IntToBool((int)data.prevent_pos); }
            set { data.prevent_pos = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("notify_supplier", "int(1)", isNullable: false)]
        public bool NotifySupplier
        {
            get { return ERPNextConverter.IntToBool((int)data.notify_supplier); }
            set { data.notify_supplier = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("notify_employee", "int(1)", isNullable: false)]
        public bool NotifyEmployee
        {
            get { return ERPNextConverter.IntToBool((int)data.notify_employee); }
            set { data.notify_employee = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("employee_link", "varchar(140)", isNullable: true)]
        public string? EmployeeLink
        {
            get { return data.employee_link; }
            set { data.employee_link = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parent", "varchar(140)", isNullable: true)]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parentfield", "varchar(140)", isNullable: true)]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("parenttype", "varchar(140)", isNullable: true)]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = ERPNextConverter.TruncateString(value, 140); }
        }


    }
}

