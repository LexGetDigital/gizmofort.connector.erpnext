/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/11/2022 7:52:10 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using _DockType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Email.NotificationRecipient
{
    public partial class ERP_Email_NotificationRecipient : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Email_NotificationRecipient() : this(new ERPObject(_DockType.Email_NotificationRecipient)) { }
        public ERP_Email_NotificationRecipient(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Email_NotificationRecipient>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Email_NotificationRecipient>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Email_NotificationRecipient>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Email_NotificationRecipient? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Email_NotificationRecipient>(json: json);
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

        [Column("receiver_by_document_field")]
        public string? ReceiverByDocumentField
        {
            get { return data.receiver_by_document_field; }
            set { data.receiver_by_document_field = value; }
        }

        [Column("receiver_by_role")]
        public string? ReceiverByRole
        {
            get { return data.receiver_by_role; }
            set { data.receiver_by_role = value; }
        }

        [Column("cc")]
        public string? Cc
        {
            get { return data.cc; }
            set { data.cc = value; }
        }

        [Column("bcc")]
        public string? Bcc
        {
            get { return data.bcc; }
            set { data.bcc = value; }
        }

        [Column("condition")]
        public string? Condition
        {
            get { return data.condition; }
            set { data.condition = value; }
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

