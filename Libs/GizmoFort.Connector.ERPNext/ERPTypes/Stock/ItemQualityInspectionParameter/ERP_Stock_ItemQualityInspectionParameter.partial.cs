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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.ItemQualityInspectionParameter
{
    public partial class ERP_Stock_ItemQualityInspectionParameter : ERPNextObjectBase
    {
        public ERP_Stock_ItemQualityInspectionParameter() : this(new ERPObject(_DockType.Stock_ItemQualityInspectionParameter)) { }
        public ERP_Stock_ItemQualityInspectionParameter(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Stock_ItemQualityInspectionParameter>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Stock_ItemQualityInspectionParameter>(columnName);
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

        [Column("specification")]
        public string? Specification
        {
            get { return data.specification; }
            set { data.specification = value; }
        }

        [Column("parameter_group")]
        public string? ParameterGroup
        {
            get { return data.parameter_group; }
            set { data.parameter_group = value; }
        }

        [Column("@value")]
        public string? Value
        {
            get { return data.@value; }
            set { data.@value = value; }
        }

        [Column("numeric")]
        public int Numeric
        {
            get { return data.numeric; }
            set { data.numeric = value; }
        }

        [Column("min_value")]
        public decimal MinValue
        {
            get { return data.min_value; }
            set { data.min_value = value; }
        }

        [Column("max_value")]
        public decimal MaxValue
        {
            get { return data.max_value; }
            set { data.max_value = value; }
        }

        [Column("formula_based_criteria")]
        public int FormulaBasedCriteria
        {
            get { return data.formula_based_criteria; }
            set { data.formula_based_criteria = value; }
        }

        [Column("acceptance_formula")]
        public string? AcceptanceFormula
        {
            get { return data.acceptance_formula; }
            set { data.acceptance_formula = value; }
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

