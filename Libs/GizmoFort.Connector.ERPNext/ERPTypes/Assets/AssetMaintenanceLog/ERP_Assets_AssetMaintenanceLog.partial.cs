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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Assets.AssetMaintenanceLog
{
    public partial class ERP_Assets_AssetMaintenanceLog : ERPNextObjectBase
    {
        public ERP_Assets_AssetMaintenanceLog() : this(new ERPObject(_DockType.Assets_AssetMaintenanceLog)) { }
        public ERP_Assets_AssetMaintenanceLog(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Assets_AssetMaintenanceLog>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Assets_AssetMaintenanceLog>(columnName);
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

        [Column("asset_maintenance")]
        public string? AssetMaintenance
        {
            get { return data.asset_maintenance; }
            set { data.asset_maintenance = value; }
        }

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("asset_name")]
        public string? AssetName
        {
            get { return data.asset_name; }
            set { data.asset_name = value; }
        }

        [Column("item_code")]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = value; }
        }

        [Column("item_name")]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = value; }
        }

        [Column("task")]
        public string? Task
        {
            get { return data.task; }
            set { data.task = value; }
        }

        [Column("task_name")]
        public string? TaskName
        {
            get { return data.task_name; }
            set { data.task_name = value; }
        }

        [Column("maintenance_type")]
        public string? MaintenanceType
        {
            get { return data.maintenance_type; }
            set { data.maintenance_type = value; }
        }

        [Column("periodicity")]
        public string? Periodicity
        {
            get { return data.periodicity; }
            set { data.periodicity = value; }
        }

        [Column("has_certificate")]
        public int HasCertificate
        {
            get { return data.has_certificate; }
            set { data.has_certificate = value; }
        }

        [Column("certificate_attachement")]
        public string? CertificateAttachement
        {
            get { return data.certificate_attachement; }
            set { data.certificate_attachement = value; }
        }

        [Column("maintenance_status")]
        public string? MaintenanceStatus
        {
            get { return data.maintenance_status; }
            set { data.maintenance_status = value; }
        }

        [Column("assign_to_name")]
        public string? AssignToName
        {
            get { return data.assign_to_name; }
            set { data.assign_to_name = value; }
        }

        [Column("due_date")]
        public DateOnly? DueDate
        {
            get { return data.due_date; }
            set { data.due_date = value; }
        }

        [Column("completion_date")]
        public DateOnly? CompletionDate
        {
            get { return data.completion_date; }
            set { data.completion_date = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [Column("actions_performed")]
        public string? ActionsPerformed
        {
            get { return data.actions_performed; }
            set { data.actions_performed = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
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

        [Column("_seen")]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Seen
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._seen; }
            set { data._seen = value; }
        }


    }
}

