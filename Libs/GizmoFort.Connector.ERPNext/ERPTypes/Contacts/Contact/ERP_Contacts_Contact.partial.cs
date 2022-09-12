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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Contacts.Contact
{
    public partial class ERP_Contacts_Contact : ERPNextObjectBase
    {
        public ERP_Contacts_Contact() : this(new ERPObject(_DockType.Contacts_Contact)) { }
        public ERP_Contacts_Contact(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Contacts_Contact>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Contacts_Contact>(columnName);
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

        [Column("first_name")]
        public string? FirstName
        {
            get { return data.first_name; }
            set { data.first_name = value; }
        }

        [Column("middle_name")]
        public string? MiddleName
        {
            get { return data.middle_name; }
            set { data.middle_name = value; }
        }

        [Column("last_name")]
        public string? LastName
        {
            get { return data.last_name; }
            set { data.last_name = value; }
        }

        [Column("email_id")]
        public string? EmailId
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        [Column("user")]
        public string? User
        {
            get { return data.user; }
            set { data.user = value; }
        }

        [Column("address")]
        public string? Address
        {
            get { return data.address; }
            set { data.address = value; }
        }

        [Column("sync_with_google_contacts")]
        public int SyncWithGoogleContacts
        {
            get { return data.sync_with_google_contacts; }
            set { data.sync_with_google_contacts = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("salutation")]
        public string? Salutation
        {
            get { return data.salutation; }
            set { data.salutation = value; }
        }

        [Column("designation")]
        public string? Designation
        {
            get { return data.designation; }
            set { data.designation = value; }
        }

        [Column("gender")]
        public string? Gender
        {
            get { return data.gender; }
            set { data.gender = value; }
        }

        [Column("phone")]
        public string? Phone
        {
            get { return data.phone; }
            set { data.phone = value; }
        }

        [Column("mobile_no")]
        public string? MobileNo
        {
            get { return data.mobile_no; }
            set { data.mobile_no = value; }
        }

        [Column("company_name")]
        public string? CompanyName
        {
            get { return data.company_name; }
            set { data.company_name = value; }
        }

        [Column("image")]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [Column("google_contacts")]
        public string? GoogleContacts
        {
            get { return data.google_contacts; }
            set { data.google_contacts = value; }
        }

        [Column("google_contacts_id")]
        public string? GoogleContactsId
        {
            get { return data.google_contacts_id; }
            set { data.google_contacts_id = value; }
        }

        [Column("pulled_from_google_contacts")]
        public int PulledFromGoogleContacts
        {
            get { return data.pulled_from_google_contacts; }
            set { data.pulled_from_google_contacts = value; }
        }

        [Column("is_primary_contact")]
        public int IsPrimaryContact
        {
            get { return data.is_primary_contact; }
            set { data.is_primary_contact = value; }
        }

        [Column("department")]
        public string? Department
        {
            get { return data.department; }
            set { data.department = value; }
        }

        [Column("unsubscribed")]
        public int Unsubscribed
        {
            get { return data.unsubscribed; }
            set { data.unsubscribed = value; }
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

        [Column("is_billing_contact")]
        public int IsBillingContact
        {
            get { return data.is_billing_contact; }
            set { data.is_billing_contact = value; }
        }


    }
}

