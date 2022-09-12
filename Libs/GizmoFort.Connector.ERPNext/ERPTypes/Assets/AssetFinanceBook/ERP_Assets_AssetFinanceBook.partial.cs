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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.AssetFinanceBook
{
    public partial class ERP_Assets_AssetFinanceBook : ERPNextObjectBase
    {
        public ERP_Assets_AssetFinanceBook() : this(new ERPObject(_DockType.Assets_AssetFinanceBook)) { }
        public ERP_Assets_AssetFinanceBook(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Assets_AssetFinanceBook>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Assets_AssetFinanceBook>(columnName);
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

        [Column("finance_book")]
        public string? FinanceBook
        {
            get { return data.finance_book; }
            set { data.finance_book = value; }
        }

        [Column("depreciation_method")]
        public string? DepreciationMethod
        {
            get { return data.depreciation_method; }
            set { data.depreciation_method = value; }
        }

        [Column("total_number_of_depreciations")]
        public int TotalNumberOfDepreciations
        {
            get { return data.total_number_of_depreciations; }
            set { data.total_number_of_depreciations = value; }
        }

        [Column("frequency_of_depreciation")]
        public int FrequencyOfDepreciation
        {
            get { return data.frequency_of_depreciation; }
            set { data.frequency_of_depreciation = value; }
        }

        [Column("depreciation_start_date")]
        public DateOnly? DepreciationStartDate
        {
            get { return data.depreciation_start_date; }
            set { data.depreciation_start_date = value; }
        }

        [Column("expected_value_after_useful_life")]
        public decimal ExpectedValueAfterUsefulLife
        {
            get { return data.expected_value_after_useful_life; }
            set { data.expected_value_after_useful_life = value; }
        }

        [Column("value_after_depreciation")]
        public decimal ValueAfterDepreciation
        {
            get { return data.value_after_depreciation; }
            set { data.value_after_depreciation = value; }
        }

        [Column("rate_of_depreciation")]
        public decimal RateOfDepreciation
        {
            get { return data.rate_of_depreciation; }
            set { data.rate_of_depreciation = value; }
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

