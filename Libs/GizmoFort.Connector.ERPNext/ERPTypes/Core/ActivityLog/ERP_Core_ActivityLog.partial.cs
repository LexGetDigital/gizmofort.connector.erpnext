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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.ActivityLog
{
    public partial class ERP_Core_ActivityLog : ERPNextObjectBase
    {
        public ERP_Core_ActivityLog() : this(new ERPObject(_DockType.Core_ActivityLog)) { }
        public ERP_Core_ActivityLog(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Core_ActivityLog>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Core_ActivityLog>(columnName);
        }


        [Column("name")]
        public long Name
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

        [Column("subject")]
        public string? Subject
        {
            get { return data.subject; }
            set { data.subject = value; }
        }

        [Column("content")]
        public string? Content
        {
            get { return data.content; }
            set { data.content = value; }
        }

        [Column("communication_date")]
        public DateTime? CommunicationDate
        {
            get { return data.communication_date; }
            set { data.communication_date = value; }
        }

        [Column("operation")]
        public string? Operation
        {
            get { return data.operation; }
            set { data.operation = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("reference_doctype")]
        public string? ReferenceDoctype
        {
            get { return data.reference_doctype; }
            set { data.reference_doctype = value; }
        }

        [Column("reference_name")]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = value; }
        }

        [Column("reference_owner")]
        public string? ReferenceOwner
        {
            get { return data.reference_owner; }
            set { data.reference_owner = value; }
        }

        [Column("timeline_doctype")]
        public string? TimelineDoctype
        {
            get { return data.timeline_doctype; }
            set { data.timeline_doctype = value; }
        }

        [Column("timeline_name")]
        public string? TimelineName
        {
            get { return data.timeline_name; }
            set { data.timeline_name = value; }
        }

        [Column("link_doctype")]
        public string? LinkDoctype
        {
            get { return data.link_doctype; }
            set { data.link_doctype = value; }
        }

        [Column("link_name")]
        public string? LinkName
        {
            get { return data.link_name; }
            set { data.link_name = value; }
        }

        [Column("user")]
        public string? User
        {
            get { return data.user; }
            set { data.user = value; }
        }

        [Column("full_name")]
        public string? FullName
        {
            get { return data.full_name; }
            set { data.full_name = value; }
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

