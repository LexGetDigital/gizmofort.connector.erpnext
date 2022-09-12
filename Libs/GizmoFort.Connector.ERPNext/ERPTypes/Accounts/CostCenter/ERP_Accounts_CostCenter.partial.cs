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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.CostCenter
{
    public partial class ERP_Accounts_CostCenter : ERPNextObjectBase
    {
        public ERP_Accounts_CostCenter() : this(new ERPObject(_DockType.Accounts_CostCenter)) { }
        public ERP_Accounts_CostCenter(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Accounts_CostCenter>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Accounts_CostCenter>(columnName);
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

        [Column("cost_center_name")]
        public string? CostCenterName
        {
            get { return data.cost_center_name; }
            set { data.cost_center_name = value; }
        }

        [Column("cost_center_number")]
        public string? CostCenterNumber
        {
            get { return data.cost_center_number; }
            set { data.cost_center_number = value; }
        }

        [Column("parent_cost_center")]
        public string? ParentCostCenter
        {
            get { return data.parent_cost_center; }
            set { data.parent_cost_center = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("is_group")]
        public int IsGroup
        {
            get { return data.is_group; }
            set { data.is_group = value; }
        }

        [Column("disabled")]
        public int Disabled
        {
            get { return data.disabled; }
            set { data.disabled = value; }
        }

        [Column("lft")]
        public int Lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        [Column("rgt")]
        public int Rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        [Column("old_parent")]
        public string? OldParent
        {
            get { return data.old_parent; }
            set { data.old_parent = value; }
        }

        [Column("_user_tags")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [Column("_comments")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [Column("_assign")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [Column("_liked_by")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

