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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.AssetMovementItem
{
    public partial class ERP_Assets_AssetMovementItem : ERPNextObjectBase
    {
        public ERP_Assets_AssetMovementItem() : this(new ERPObject(_DockType.Assets_AssetMovementItem)) { }
        public ERP_Assets_AssetMovementItem(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Assets_AssetMovementItem>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Assets_AssetMovementItem>(columnName);
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

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("asset")]
        public string? Asset
        {
            get { return data.asset; }
            set { data.asset = value; }
        }

        [Column("source_location")]
        public string? SourceLocation
        {
            get { return data.source_location; }
            set { data.source_location = value; }
        }

        [Column("from_employee")]
        public string? FromEmployee
        {
            get { return data.from_employee; }
            set { data.from_employee = value; }
        }

        [Column("asset_name")]
        public string? AssetName
        {
            get { return data.asset_name; }
            set { data.asset_name = value; }
        }

        [Column("target_location")]
        public string? TargetLocation
        {
            get { return data.target_location; }
            set { data.target_location = value; }
        }

        [Column("to_employee")]
        public string? ToEmployee
        {
            get { return data.to_employee; }
            set { data.to_employee = value; }
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

