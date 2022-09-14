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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Contacts.Contact
{
    public partial class ERP_Contacts_Contact : ERPNextObjectBase
    {
        public ERP_Contacts_Contact() : this(new ERPObject(_DocType.Contacts_Contact)) { }
        public ERP_Contacts_Contact(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("first_name", "varchar(140)", isNullable: true)]
        public string? FirstName
        {
            get { return data.first_name; }
            set { data.first_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("middle_name", "varchar(140)", isNullable: true)]
        public string? MiddleName
        {
            get { return data.middle_name; }
            set { data.middle_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("last_name", "varchar(140)", isNullable: true)]
        public string? LastName
        {
            get { return data.last_name; }
            set { data.last_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("email_id", "varchar(140)", isNullable: true)]
        public string? EmailId
        {
            get { return data.email_id; }
            set { data.email_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("user", "varchar(140)", isNullable: true)]
        public string? User
        {
            get { return data.user; }
            set { data.user = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("address", "varchar(140)", isNullable: true)]
        public string? Address
        {
            get { return data.address; }
            set { data.address = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sync_with_google_contacts", "int(1)", isNullable: false)]
        public bool SyncWithGoogleContacts
        {
            get { return ERPNextConverter.IntToBool((int)data.sync_with_google_contacts); }
            set { data.sync_with_google_contacts = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("salutation", "varchar(140)", isNullable: true)]
        public string? Salutation
        {
            get { return data.salutation; }
            set { data.salutation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("designation", "varchar(140)", isNullable: true)]
        public string? Designation
        {
            get { return data.designation; }
            set { data.designation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("gender", "varchar(140)", isNullable: true)]
        public string? Gender
        {
            get { return data.gender; }
            set { data.gender = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("phone", "varchar(140)", isNullable: true)]
        public string? Phone
        {
            get { return data.phone; }
            set { data.phone = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("mobile_no", "varchar(140)", isNullable: true)]
        public string? MobileNo
        {
            get { return data.mobile_no; }
            set { data.mobile_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company_name", "varchar(140)", isNullable: true)]
        public string? CompanyName
        {
            get { return data.company_name; }
            set { data.company_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("google_contacts", "varchar(140)", isNullable: true)]
        public string? GoogleContacts
        {
            get { return data.google_contacts; }
            set { data.google_contacts = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("google_contacts_id", "varchar(140)", isNullable: true)]
        public string? GoogleContactsId
        {
            get { return data.google_contacts_id; }
            set { data.google_contacts_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("pulled_from_google_contacts", "int(1)", isNullable: false)]
        public bool PulledFromGoogleContacts
        {
            get { return ERPNextConverter.IntToBool((int)data.pulled_from_google_contacts); }
            set { data.pulled_from_google_contacts = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_primary_contact", "int(1)", isNullable: false)]
        public bool IsPrimaryContact
        {
            get { return ERPNextConverter.IntToBool((int)data.is_primary_contact); }
            set { data.is_primary_contact = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("department", "varchar(140)", isNullable: true)]
        public string? Department
        {
            get { return data.department; }
            set { data.department = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("unsubscribed", "int(1)", isNullable: false)]
        public bool Unsubscribed
        {
            get { return ERPNextConverter.IntToBool((int)data.unsubscribed); }
            set { data.unsubscribed = ERPNextConverter.BoolToInt(value); }
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

        [ColumnInfo("is_billing_contact", "int(1)", isNullable: false)]
        public bool IsBillingContact
        {
            get { return ERPNextConverter.IntToBool((int)data.is_billing_contact); }
            set { data.is_billing_contact = ERPNextConverter.BoolToInt(value); }
        }


    }
}

