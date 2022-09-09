/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/9/2022 12:40:42 AM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Core.UserDocumentType
{
    public partial class ERP_Core_UserDocumentType : ERPNextObjectBase
    {
        public ERP_Core_UserDocumentType() : this(new ERPObject(_DockType.Core_UserDocumentType)) { }
        public ERP_Core_UserDocumentType(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Core_UserDocumentType>(propertyName);
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

        [Column("document_type")]
        public string? DocumentType
        {
            get { return data.document_type; }
            set { data.document_type = value; }
        }

        [Column("is_custom")]
        public int IsCustom
        {
            get { return data.is_custom; }
            set { data.is_custom = value; }
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

        [Column("create")]
        public int Create
        {
            get { return data.create; }
            set { data.create = value; }
        }

        [Column("submit")]
        public int Submit
        {
            get { return data.submit; }
            set { data.submit = value; }
        }

        [Column("cancel")]
        public int Cancel
        {
            get { return data.cancel; }
            set { data.cancel = value; }
        }

        [Column("amend")]
        public int Amend
        {
            get { return data.amend; }
            set { data.amend = value; }
        }

        [Column("delete")]
        public int Delete
        {
            get { return data.delete; }
            set { data.delete = value; }
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

