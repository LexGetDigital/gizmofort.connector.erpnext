/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/14/2022 8:42:56 AM
********************************************************************/

using System;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Support.WarrantyClaim
{
    public partial class ERP_Support_WarrantyClaim : ERPNextObjectBase
    {
        public ERP_Support_WarrantyClaim() : this(new ERPObject(_DocType.Support_WarrantyClaim)) { }
        public ERP_Support_WarrantyClaim(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("complaint_date", "date", isNullable: true)]
        public DateOnly? ComplaintDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.complaint_date); }
            set { data.complaint_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("customer", "varchar(140)", isNullable: true)]
        public string? Customer
        {
            get { return data.customer; }
            set { data.customer = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("serial_no", "varchar(140)", isNullable: true)]
        public string? SerialNo
        {
            get { return data.serial_no; }
            set { data.serial_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("complaint", "longtext", isNullable: true)]
        public string? Complaint
        {
            get { return data.complaint; }
            set { data.complaint = value; }
        }

        [ColumnInfo("item_code", "varchar(140)", isNullable: true)]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_name", "varchar(140)", isNullable: true)]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "text", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("warranty_amc_status", "varchar(140)", isNullable: true)]
        public string? WarrantyAmcStatus
        {
            get { return data.warranty_amc_status; }
            set { data.warranty_amc_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("warranty_expiry_date", "date", isNullable: true)]
        public DateOnly? WarrantyExpiryDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.warranty_expiry_date); }
            set { data.warranty_expiry_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("amc_expiry_date", "date", isNullable: true)]
        public DateOnly? AmcExpiryDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.amc_expiry_date); }
            set { data.amc_expiry_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("resolution_date", "datetime(6)", isNullable: true)]
        public DateTimeOffset? ResolutionDate
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.resolution_date); }
            set { data.resolution_date = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("resolved_by", "varchar(140)", isNullable: true)]
        public string? ResolvedBy
        {
            get { return data.resolved_by; }
            set { data.resolved_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("resolution_details", "text", isNullable: true)]
        public string? ResolutionDetails
        {
            get { return data.resolution_details; }
            set { data.resolution_details = value; }
        }

        [ColumnInfo("customer_name", "varchar(140)", isNullable: true)]
        public string? CustomerName
        {
            get { return data.customer_name; }
            set { data.customer_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("contact_person", "varchar(140)", isNullable: true)]
        public string? ContactPerson
        {
            get { return data.contact_person; }
            set { data.contact_person = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("contact_display", "text", isNullable: true)]
        public string? ContactDisplay
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        [ColumnInfo("contact_mobile", "varchar(140)", isNullable: true)]
        public string? ContactMobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("contact_email", "varchar(140)", isNullable: true)]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("territory", "varchar(140)", isNullable: true)]
        public string? Territory
        {
            get { return data.territory; }
            set { data.territory = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_group", "varchar(140)", isNullable: true)]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_address", "varchar(140)", isNullable: true)]
        public string? CustomerAddress
        {
            get { return data.customer_address; }
            set { data.customer_address = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("address_display", "text", isNullable: true)]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [ColumnInfo("service_address", "text", isNullable: true)]
        public string? ServiceAddress
        {
            get { return data.service_address; }
            set { data.service_address = value; }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("complaint_raised_by", "varchar(140)", isNullable: true)]
        public string? ComplaintRaisedBy
        {
            get { return data.complaint_raised_by; }
            set { data.complaint_raised_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("from_company", "varchar(140)", isNullable: true)]
        public string? FromCompany
        {
            get { return data.from_company; }
            set { data.from_company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("_user_tags", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [ColumnInfo("_comments", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [ColumnInfo("_assign", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [ColumnInfo("_liked_by", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

