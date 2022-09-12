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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.DocShare
{
    public partial class ERP_Core_DocShare : ERPNextObjectBase
    {
        public ERP_Core_DocShare() : this(new ERPObject(_DockType.Core_DocShare)) { }
        public ERP_Core_DocShare(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Core_DocShare>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Core_DocShare>(columnName);
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

        [Column("user")]
        public string? User
        {
            get { return data.user; }
            set { data.user = value; }
        }

        [Column("share_doctype")]
        public string? ShareDoctype
        {
            get { return data.share_doctype; }
            set { data.share_doctype = value; }
        }

        [Column("share_name")]
        public string? ShareName
        {
            get { return data.share_name; }
            set { data.share_name = value; }
        }

        [Column("read")]
        public int Read
        {
            get { return data.read; }
            set { data.read = value; }
        }

        [Column("write")]
        public int Write
        {
            get { return data.write; }
            set { data.write = value; }
        }

        [Column("share")]
        public int Share
        {
            get { return data.share; }
            set { data.share = value; }
        }

        [Column("submit")]
        public int Submit
        {
            get { return data.submit; }
            set { data.submit = value; }
        }

        [Column("everyone")]
        public int Everyone
        {
            get { return data.everyone; }
            set { data.everyone = value; }
        }

        [Column("notify_by_email")]
        public int NotifyByEmail
        {
            get { return data.notify_by_email; }
            set { data.notify_by_email = value; }
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

