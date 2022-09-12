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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Workflow.WorkflowDocumentState
{
    public partial class ERP_Workflow_WorkflowDocumentState : ERPNextObjectBase
    {
        public ERP_Workflow_WorkflowDocumentState() : this(new ERPObject(_DockType.Workflow_WorkflowDocumentState)) { }
        public ERP_Workflow_WorkflowDocumentState(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Workflow_WorkflowDocumentState>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Workflow_WorkflowDocumentState>(columnName);
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

        [Column("state")]
        public string? State
        {
            get { return data.state; }
            set { data.state = value; }
        }

        [Column("doc_status")]
        public string? DocStatus
        {
            get { return data.doc_status; }
            set { data.doc_status = value; }
        }

        [Column("update_field")]
        public string? UpdateField
        {
            get { return data.update_field; }
            set { data.update_field = value; }
        }

        [Column("update_value")]
        public string? UpdateValue
        {
            get { return data.update_value; }
            set { data.update_value = value; }
        }

        [Column("is_optional_state")]
        public int IsOptionalState
        {
            get { return data.is_optional_state; }
            set { data.is_optional_state = value; }
        }

        [Column("next_action_email_template")]
        public string? NextActionEmailTemplate
        {
            get { return data.next_action_email_template; }
            set { data.next_action_email_template = value; }
        }

        [Column("allow_edit")]
        public string? AllowEdit
        {
            get { return data.allow_edit; }
            set { data.allow_edit = value; }
        }

        [Column("message")]
        public string? Message
        {
            get { return data.message; }
            set { data.message = value; }
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

