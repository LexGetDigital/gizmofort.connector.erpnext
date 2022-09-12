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

namespace GizmoFort.Connector.ERPNext.ERPTypes.EventStreaming.EventSyncLog
{
    public partial class ERP_EventStreaming_EventSyncLog : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_EventStreaming_EventSyncLog() : this(new ERPObject(_DockType.EventStreaming_EventSyncLog)) { }
        public ERP_EventStreaming_EventSyncLog(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_EventStreaming_EventSyncLog>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_EventStreaming_EventSyncLog>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_EventStreaming_EventSyncLog>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_EventStreaming_EventSyncLog? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_EventStreaming_EventSyncLog>(json: json);
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

        [Column("update_type")]
        public string? UpdateType
        {
            get { return data.update_type; }
            set { data.update_type = value; }
        }

        [Column("ref_doctype")]
        public string? RefDoctype
        {
            get { return data.ref_doctype; }
            set { data.ref_doctype = value; }
        }

        [Column("docname")]
        public string? Docname
        {
            get { return data.docname; }
            set { data.docname = value; }
        }

        [Column("status")]
        public string? Status
        {
            get { return data.status; }
            set { data.status = value; }
        }

        [Column("event_producer")]
        public string? EventProducer
        {
            get { return data.event_producer; }
            set { data.event_producer = value; }
        }

        [Column("producer_doc")]
        public string? ProducerDoc
        {
            get { return data.producer_doc; }
            set { data.producer_doc = value; }
        }

        [Column("use_same_name")]
        public string? UseSameName
        {
            get { return data.use_same_name; }
            set { data.use_same_name = value; }
        }

        [Column("mapping")]
        public string? Mapping
        {
            get { return data.mapping; }
            set { data.mapping = value; }
        }

        [Column("data")]
        public string? Data
        {
            get { return data.data; }
            set { data.data = value; }
        }

        [Column("error")]
        public string? Error
        {
            get { return data.error; }
            set { data.error = value; }
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

