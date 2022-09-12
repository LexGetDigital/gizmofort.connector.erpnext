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

namespace GizmoFort.Connector.ERPNext.ERPTypes.LoanManagement.Unpledge
{
    public partial class ERP_LoanManagement_Unpledge : 
        ERPNextObjectBase, 
        ISerializePropertiesToJson, 
        IDeserializePropertiesFromJson<ERPNextObjectBase>
    {
        public ERP_LoanManagement_Unpledge() : this(new ERPObject(_DockType.LoanManagement_Unpledge)) { }
        public ERP_LoanManagement_Unpledge(ERPObject obj) : base(obj) { }

        public static string? GetColumnName(string propertyName)
        {
            return ERPNextObjectBase.GetColumnName<ERP_LoanManagement_Unpledge>(propertyName);
        }

        public static string? GetPropertyName(string columnName)
        {
            return ERPNextObjectBase.GetPropertyName<ERP_LoanManagement_Unpledge>(columnName);
        }

        public string Serialize()
        {
            //
            // serializtion is more complex... will need to serialize the data
            // property ONLY, but map the names to the exposed property names
            //
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = new CustomJsonSerializationPolicy<ERP_LoanManagement_Unpledge>()
            };
            return JsonSerializer.Serialize(value: this.data,
                                            options: options);
        }

        public static ERP_LoanManagement_Unpledge? Deserialize(string json)
        {
            //
            // deserialization is straight-forward... setters will only be called if values
            // are included in the json string
            //
            return JsonSerializer.Deserialize<ERP_LoanManagement_Unpledge>(json: json);
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

        [Column("loan_security")]
        public string? LoanSecurity
        {
            get { return data.loan_security; }
            set { data.loan_security = value; }
        }

        [Column("loan_security_name")]
        public string? LoanSecurityName
        {
            get { return data.loan_security_name; }
            set { data.loan_security_name = value; }
        }

        [Column("loan_security_type")]
        public string? LoanSecurityType
        {
            get { return data.loan_security_type; }
            set { data.loan_security_type = value; }
        }

        [Column("loan_security_code")]
        public string? LoanSecurityCode
        {
            get { return data.loan_security_code; }
            set { data.loan_security_code = value; }
        }

        [Column("haircut")]
        public decimal Haircut
        {
            get { return data.haircut; }
            set { data.haircut = value; }
        }

        [Column("uom")]
        public string? Uom
        {
            get { return data.uom; }
            set { data.uom = value; }
        }

        [Column("qty")]
        public decimal Qty
        {
            get { return data.qty; }
            set { data.qty = value; }
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

