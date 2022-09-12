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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Manufacturing.Workstation
{
    public partial class ERP_Manufacturing_Workstation : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_Manufacturing_Workstation() : this(new ERPObject(_DockType.Manufacturing_Workstation)) { }
        public ERP_Manufacturing_Workstation(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_Manufacturing_Workstation>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_Manufacturing_Workstation>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_Manufacturing_Workstation>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_Manufacturing_Workstation? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_Manufacturing_Workstation>(json: json);
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

        [Column("workstation_name")]
        public string? WorkstationName
        {
            get { return data.workstation_name; }
            set { data.workstation_name = value; }
        }

        [Column("production_capacity")]
        public int ProductionCapacity
        {
            get { return data.production_capacity; }
            set { data.production_capacity = value; }
        }

        [Column("hour_rate_electricity")]
        public decimal HourRateElectricity
        {
            get { return data.hour_rate_electricity; }
            set { data.hour_rate_electricity = value; }
        }

        [Column("hour_rate_consumable")]
        public decimal HourRateConsumable
        {
            get { return data.hour_rate_consumable; }
            set { data.hour_rate_consumable = value; }
        }

        [Column("hour_rate_rent")]
        public decimal HourRateRent
        {
            get { return data.hour_rate_rent; }
            set { data.hour_rate_rent = value; }
        }

        [Column("hour_rate_labour")]
        public decimal HourRateLabour
        {
            get { return data.hour_rate_labour; }
            set { data.hour_rate_labour = value; }
        }

        [Column("hour_rate")]
        public decimal HourRate
        {
            get { return data.hour_rate; }
            set { data.hour_rate = value; }
        }

        [Column("holiday_list")]
        public string? HolidayList
        {
            get { return data.holiday_list; }
            set { data.holiday_list = value; }
        }

        [Column("description")]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
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

