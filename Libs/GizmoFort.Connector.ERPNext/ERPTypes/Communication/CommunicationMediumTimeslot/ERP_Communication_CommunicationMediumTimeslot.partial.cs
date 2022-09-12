/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/12/2022 2:29:08 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Communication.CommunicationMediumTimeslot
{
    public partial class ERP_Communication_CommunicationMediumTimeslot : ERPNextObjectBase
    {
        public ERP_Communication_CommunicationMediumTimeslot() : this(new ERPObject(_DockType.Communication_CommunicationMediumTimeslot)) { }
        public ERP_Communication_CommunicationMediumTimeslot(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Communication_CommunicationMediumTimeslot>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Communication_CommunicationMediumTimeslot>(columnName);
        }


        [Column("name")]
        public string Name
        {
            get { return data.name; }
            set { data.name = value; }
        }

        [Column("creation")]
        public DateTimeOffset? Creation
        {
            get { return data.creation; }
            set { data.creation = value; }
        }

        [Column("modified")]
        public DateTimeOffset? Modified
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

        [Column("day_of_week")]
        public string? DayOfWeek
        {
            get { return data.day_of_week; }
            set { data.day_of_week = value; }
        }

        [Column("from_time")]
        public TimeSpan? FromTime
        {
            get { return data.from_time; }
            set { data.from_time = value; }
        }

        [Column("to_time")]
        public TimeSpan? ToTime
        {
            get { return data.to_time; }
            set { data.to_time = value; }
        }

        [Column("employee_group")]
        public string? EmployeeGroup
        {
            get { return data.employee_group; }
            set { data.employee_group = value; }
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

