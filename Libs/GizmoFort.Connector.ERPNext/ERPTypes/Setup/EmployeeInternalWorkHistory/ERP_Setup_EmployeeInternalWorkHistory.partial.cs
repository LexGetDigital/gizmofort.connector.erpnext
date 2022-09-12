/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/12/2022 11:57:48 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.EmployeeInternalWorkHistory
{
    public partial class ERP_Setup_EmployeeInternalWorkHistory : ERPNextObjectBase
    {
        public ERP_Setup_EmployeeInternalWorkHistory() : this(new ERPObject(_DockType.Setup_EmployeeInternalWorkHistory)) { }
        public ERP_Setup_EmployeeInternalWorkHistory(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Setup_EmployeeInternalWorkHistory>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Setup_EmployeeInternalWorkHistory>(columnName);
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

        [Column("branch")]
        public string? Branch
        {
            get { return data.branch; }
            set { data.branch = value; }
        }

        [Column("department")]
        public string? Department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        [Column("designation")]
        public string? Designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        [Column("from_date")]
        public DateOnly? FromDate
        {
            get { return data.from_date; }
            set { data.from_date = value; }
        }

        [Column("to_date")]
        public DateOnly? ToDate
        {
            get { return data.to_date; }
            set { data.to_date = value; }
        }

        [Column("parent")]
        public string? Parent
        {
            get { return data.parent; }
            set { data.parent = value; }
        }

        [Column("parentfield")]
        public string? Parentfield
        {
            get { return data.parentfield; }
            set { data.parentfield = value; }
        }

        [Column("parenttype")]
        public string? Parenttype
        {
            get { return data.parenttype; }
            set { data.parenttype = value; }
        }


    }
}

