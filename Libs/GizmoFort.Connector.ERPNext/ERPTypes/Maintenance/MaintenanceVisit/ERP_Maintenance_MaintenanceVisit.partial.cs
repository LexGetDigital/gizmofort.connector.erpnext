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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Maintenance.MaintenanceVisit
{
    public partial class ERP_Maintenance_MaintenanceVisit : ERPNextObjectBase
    {
        public ERP_Maintenance_MaintenanceVisit() : this(new ERPObject(_DockType.Maintenance_MaintenanceVisit)) { }
        public ERP_Maintenance_MaintenanceVisit(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Maintenance_MaintenanceVisit>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Maintenance_MaintenanceVisit>(columnName);
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

        [Column("naming_series")]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = value; }
        }

        [Column("customer")]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = value; }
        }

        [Column("customer_name")]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = value; }
        }

        [Column("address_display")]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [Column("contact_display")]
        public string? ContactDisplay
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        [Column("contact_mobile")]
        public string? ContactMobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        [Column("contact_email")]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        [Column("maintenance_schedule")]
        public string? MaintenanceSchedule
        {
            get { return data.maintenance_schedule; }
            set { data.maintenance_schedule = value; }
        }

        [Column("maintenance_schedule_detail")]
        public string? MaintenanceScheduleDetail
        {
            get { return data.maintenance_schedule_detail; }
            set { data.maintenance_schedule_detail = value; }
        }

        [Column("mntc_date")]
        public DateOnly? MntcDate
        {
            get { return data.mntc_date; }
            set { data.mntc_date = value; }
        }

        [Column("mntc_time")]
        public TimeSpan? MntcTime
        {
            get { return data.mntc_time; }
            set { data.mntc_time = value; }
        }

        [Column("completion_status")]
        public string? CompletionStatus
        {
            get { return data.completion_status; }
            set { data.completion_status = value; }
        }

        [Column("maintenance_type")]
        public string? MaintenanceType
        {
            get { return data.maintenance_type; }
            set { data.maintenance_type = value; }
        }

        [Column("customer_feedback")]
        public string? CustomerFeedback
        {
            get { return data.customer_feedback; }
            set { data.customer_feedback = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("amended_from")]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = value; }
        }

        [Column("company")]
        public string? Company
        {
            get { return data.company; }
            set { data.company = value; }
        }

        [Column("customer_address")]
        public string? CustomerAddress
        {
            get { return data.customer_address; }
            set { data.customer_address = value; }
        }

        [Column("contact_person")]
        public string? ContactPerson
        {
            get { return data.contact_person; }
            set { data.contact_person = value; }
        }

        [Column("territory")]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = value; }
        }

        [Column("customer_group")]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = value; }
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

