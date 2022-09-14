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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Selling.SalesTeam
{
    public partial class ERP_Selling_SalesTeam : ERPNextObjectBase
    {
        public ERP_Selling_SalesTeam() : this(new ERPObject(_DocType.Selling_SalesTeam)) { }
        public ERP_Selling_SalesTeam(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Selling_SalesTeam>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Selling_SalesTeam>(columnName);
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

        [ColumnInfo("sales_person", "varchar(140)", isNullable: true)]
        public string? SalesPerson
        {
            get { return data.sales_person; }
            set { data.sales_person = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("contact_no", "varchar(140)", isNullable: true)]
        public string? ContactNo
        {
            get { return data.contact_no; }
            set { data.contact_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("allocated_percentage", "decimal(21,9)", isNullable: false)]
        public decimal AllocatedPercentage
        {
            get { return data.allocated_percentage; }
            set { data.allocated_percentage = value; }
        }

        [ColumnInfo("allocated_amount", "decimal(21,9)", isNullable: false)]
        public decimal AllocatedAmount
        {
            get { return data.allocated_amount; }
            set { data.allocated_amount = value; }
        }

        [ColumnInfo("commission_rate", "varchar(140)", isNullable: true)]
        public string? CommissionRate
        {
            get { return data.commission_rate; }
            set { data.commission_rate = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("incentives", "decimal(21,9)", isNullable: false)]
        public decimal Incentives
        {
            get { return data.incentives; }
            set { data.incentives = value; }
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

