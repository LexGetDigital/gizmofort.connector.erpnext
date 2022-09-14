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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.EmployeeInternalWorkHistory
{
    public partial class ERP_Setup_EmployeeInternalWorkHistory : ERPNextObjectBase
    {
        public ERP_Setup_EmployeeInternalWorkHistory() : this(new ERPObject(_DocType.Setup_EmployeeInternalWorkHistory)) { }
        public ERP_Setup_EmployeeInternalWorkHistory(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("branch", "varchar(140)", isNullable: true)]
        public string? Branch
        {
            get { return data.branch; }
            set { data.branch = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("department", "varchar(140)", isNullable: true)]
        public string? Department
        {
            get { return data.department; }
            set { data.department = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("designation", "varchar(140)", isNullable: true)]
        public string? Designation
        {
            get { return data.designation; }
            set { data.designation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("from_date", "date", isNullable: true)]
        public DateOnly? FromDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.from_date); }
            set { data.from_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("to_date", "date", isNullable: true)]
        public DateOnly? ToDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.to_date); }
            set { data.to_date = ERPNextConverter.DateOnlyToString(value); }
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

