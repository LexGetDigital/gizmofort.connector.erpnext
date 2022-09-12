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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.TargetDetail
{
    public partial class ERP_Setup_TargetDetail : ERPNextObjectBase
    {
        public ERP_Setup_TargetDetail() : this(new ERPObject(_DockType.Setup_TargetDetail)) { }
        public ERP_Setup_TargetDetail(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Setup_TargetDetail>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Setup_TargetDetail>(columnName);
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

        [Column("item_group")]
        public string? ItemGroup
        {
            get { return data.item_group; }
            set { data.item_group = value; }
        }

        [Column("fiscal_year")]
        public string? FiscalYear
        {
            get { return data.fiscal_year; }
            set { data.fiscal_year = value; }
        }

        [Column("target_qty")]
        public decimal TargetQty
        {
            get { return data.target_qty; }
            set { data.target_qty = value; }
        }

        [Column("target_amount")]
        public decimal TargetAmount
        {
            get { return data.target_amount; }
            set { data.target_amount = value; }
        }

        [Column("distribution_id")]
        public string? DistributionId
        {
            get { return data.distribution_id; }
            set { data.distribution_id = value; }
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

