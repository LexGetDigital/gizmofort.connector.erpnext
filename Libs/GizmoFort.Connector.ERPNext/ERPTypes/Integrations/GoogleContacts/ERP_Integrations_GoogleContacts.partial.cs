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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Integrations.GoogleContacts
{
    public partial class ERP_Integrations_GoogleContacts : ERPNextObjectBase
    {
        public ERP_Integrations_GoogleContacts() : this(new ERPObject(_DockType.Integrations_GoogleContacts)) { }
        public ERP_Integrations_GoogleContacts(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Integrations_GoogleContacts>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Integrations_GoogleContacts>(columnName);
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

        [Column("enable")]
        public int Enable
        {
            get { return data.enable; }
            set { data.enable = value; }
        }

        [Column("email_id")]
        public string? EmailId
        {
            get { return data.email_id; }
            set { data.email_id = value; }
        }

        [Column("last_sync_on")]
        public DateTime? LastSyncOn
        {
            get { return data.last_sync_on; }
            set { data.last_sync_on = value; }
        }

        [Column("authorization_code")]
        public string? AuthorizationCode
        {
            get { return data.authorization_code; }
            set { data.authorization_code = value; }
        }

        [Column("refresh_token")]
        public string? RefreshToken
        {
            get { return data.refresh_token; }
            set { data.refresh_token = value; }
        }

        [Column("next_sync_token")]
        public string? NextSyncToken
        {
            get { return data.next_sync_token; }
            set { data.next_sync_token = value; }
        }

        [Column("pull_from_google_contacts")]
        public int PullFromGoogleContacts
        {
            get { return data.pull_from_google_contacts; }
            set { data.pull_from_google_contacts = value; }
        }

        [Column("push_to_google_contacts")]
        public int PushToGoogleContacts
        {
            get { return data.push_to_google_contacts; }
            set { data.push_to_google_contacts = value; }
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

