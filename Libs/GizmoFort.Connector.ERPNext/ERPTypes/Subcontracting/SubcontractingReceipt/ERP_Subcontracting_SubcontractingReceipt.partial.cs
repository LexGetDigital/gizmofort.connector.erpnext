/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/13/2022 7:48:39 PM
********************************************************************/

using System;
using System.ComponentModel.DataAnnotations.Schema;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;
using System.Text.Json;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Subcontracting.SubcontractingReceipt
{
    public partial class ERP_Subcontracting_SubcontractingReceipt : ERPNextObjectBase
    {
        public ERP_Subcontracting_SubcontractingReceipt() : this(new ERPObject(_DocType.Subcontracting_SubcontractingReceipt)) { }
        public ERP_Subcontracting_SubcontractingReceipt(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_Subcontracting_SubcontractingReceipt>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_Subcontracting_SubcontractingReceipt>(columnName);
        //}

        [ColumnInfo("name", "varchar(140)", isNullable: false)]
        public string Name
        {
            get { return data.name; }
            set { data.name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("creation", "datetime(6)", isNullable: true)]
        public DateTimeOffset? Creation
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.creation); }
            set { data.creation = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("modified", "datetime(6)", isNullable: true)]
        public DateTimeOffset? Modified
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.modified); }
            set { data.modified = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("modified_by", "varchar(140)", isNullable: true)]
        public string? ModifiedBy
        {
            get { return data.modified_by; }
            set { data.modified_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("owner", "varchar(140)", isNullable: true)]
        public string? Owner
        {
            get { return data.owner; }
            set { data.owner = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("docstatus", "int(1)", isNullable: false)]
        public Docstatus Docstatus
        {
            get { return (Docstatus)data.docstatus; }
            set { data.docstatus = (int)value; }
        }

        [ColumnInfo("idx", "int(8)", isNullable: false)]
        public int Idx
        {
            get { return data.idx; }
            set { data.idx = value; }
        }

        [ColumnInfo("title", "varchar(140)", isNullable: true)]
        public string? Title
        {
            get { return data.title; }
            set { data.title = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("supplier", "varchar(140)", isNullable: true)]
        public string? Supplier
        {
            get { return data.supplier; }
            set { data.supplier = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("supplier_name", "varchar(140)", isNullable: true)]
        public string? SupplierName
        {
            get { return data.supplier_name; }
            set { data.supplier_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("posting_date", "date", isNullable: true)]
        public DateOnly? PostingDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.posting_date); }
            set { data.posting_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("posting_time", "time(6)", isNullable: true)]
        public TimeSpan? PostingTime
        {
            get { return ERPNextConverter.StringToTimeSpan(data.posting_time); }
            set { data.posting_time = ERPNextConverter.TimeSpanToString(value, 6); }
        }

        [ColumnInfo("set_posting_time", "int(1)", isNullable: false)]
        public bool SetPostingTime
        {
            get { return ERPNextConverter.IntToBool((int)data.set_posting_time); }
            set { data.set_posting_time = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("is_return", "int(1)", isNullable: false)]
        public bool IsReturn
        {
            get { return ERPNextConverter.IntToBool((int)data.is_return); }
            set { data.is_return = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("return_against", "varchar(140)", isNullable: true)]
        public string? ReturnAgainst
        {
            get { return data.return_against; }
            set { data.return_against = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("project", "varchar(140)", isNullable: true)]
        public string? Project
        {
            get { return data.project; }
            set { data.project = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("supplier_address", "varchar(140)", isNullable: true)]
        public string? SupplierAddress
        {
            get { return data.supplier_address; }
            set { data.supplier_address = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("contact_person", "varchar(140)", isNullable: true)]
        public string? ContactPerson
        {
            get { return data.contact_person; }
            set { data.contact_person = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("address_display", "text", isNullable: true)]
        public string? AddressDisplay
        {
            get { return data.address_display; }
            set { data.address_display = value; }
        }

        [ColumnInfo("contact_display", "text", isNullable: true)]
        public string? ContactDisplay
        {
            get { return data.contact_display; }
            set { data.contact_display = value; }
        }

        [ColumnInfo("contact_mobile", "text", isNullable: true)]
        public string? ContactMobile
        {
            get { return data.contact_mobile; }
            set { data.contact_mobile = value; }
        }

        [ColumnInfo("contact_email", "text", isNullable: true)]
        public string? ContactEmail
        {
            get { return data.contact_email; }
            set { data.contact_email = value; }
        }

        [ColumnInfo("shipping_address", "varchar(140)", isNullable: true)]
        public string? ShippingAddress
        {
            get { return data.shipping_address; }
            set { data.shipping_address = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("shipping_address_display", "text", isNullable: true)]
        public string? ShippingAddressDisplay
        {
            get { return data.shipping_address_display; }
            set { data.shipping_address_display = value; }
        }

        [ColumnInfo("billing_address", "varchar(140)", isNullable: true)]
        public string? BillingAddress
        {
            get { return data.billing_address; }
            set { data.billing_address = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("billing_address_display", "text", isNullable: true)]
        public string? BillingAddressDisplay
        {
            get { return data.billing_address_display; }
            set { data.billing_address_display = value; }
        }

        [ColumnInfo("set_warehouse", "varchar(140)", isNullable: true)]
        public string? SetWarehouse
        {
            get { return data.set_warehouse; }
            set { data.set_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("rejected_warehouse", "varchar(140)", isNullable: true)]
        public string? RejectedWarehouse
        {
            get { return data.rejected_warehouse; }
            set { data.rejected_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("supplier_warehouse", "varchar(140)", isNullable: true)]
        public string? SupplierWarehouse
        {
            get { return data.supplier_warehouse; }
            set { data.supplier_warehouse = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("total_qty", "decimal(21,9)", isNullable: false)]
        public decimal TotalQty
        {
            get { return data.total_qty; }
            set { data.total_qty = value; }
        }

        [ColumnInfo("total", "decimal(21,9)", isNullable: false)]
        public decimal Total
        {
            get { return data.total; }
            set { data.total = value; }
        }

        [ColumnInfo("distribute_additional_costs_based_on", "varchar(140)", isNullable: true)]
        public string? DistributeAdditionalCostsBasedOn
        {
            get { return data.distribute_additional_costs_based_on; }
            set { data.distribute_additional_costs_based_on = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("total_additional_costs", "decimal(21,9)", isNullable: false)]
        public decimal TotalAdditionalCosts
        {
            get { return data.total_additional_costs; }
            set { data.total_additional_costs = value; }
        }

        [ColumnInfo("in_words", "varchar(240)", isNullable: true)]
        public string? InWords
        {
            get { return data.in_words; }
            set { data.in_words = ERPNextConverter.TruncateString(value, 240); }
        }

        [ColumnInfo("bill_no", "varchar(140)", isNullable: true)]
        public string? BillNo
        {
            get { return data.bill_no; }
            set { data.bill_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("bill_date", "date", isNullable: true)]
        public DateOnly? BillDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.bill_date); }
            set { data.bill_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("per_returned", "decimal(21,9)", isNullable: false)]
        public decimal PerReturned
        {
            get { return data.per_returned; }
            set { data.per_returned = value; }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("range", "varchar(140)", isNullable: true)]
        public string? Range
        {
            get { return data.range; }
            set { data.range = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("represents_company", "varchar(140)", isNullable: true)]
        public string? RepresentsCompany
        {
            get { return data.represents_company; }
            set { data.represents_company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("auto_repeat", "varchar(140)", isNullable: true)]
        public string? AutoRepeat
        {
            get { return data.auto_repeat; }
            set { data.auto_repeat = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("letter_head", "varchar(140)", isNullable: true)]
        public string? LetterHead
        {
            get { return data.letter_head; }
            set { data.letter_head = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("language", "varchar(140)", isNullable: true)]
        public string? Language
        {
            get { return data.language; }
            set { data.language = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("instructions", "text", isNullable: true)]
        public string? Instructions
        {
            get { return data.instructions; }
            set { data.instructions = value; }
        }

        [ColumnInfo("select_print_heading", "varchar(140)", isNullable: true)]
        public string? SelectPrintHeading
        {
            get { return data.select_print_heading; }
            set { data.select_print_heading = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("remarks", "text", isNullable: true)]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        [ColumnInfo("transporter_name", "varchar(140)", isNullable: true)]
        public string? TransporterName
        {
            get { return data.transporter_name; }
            set { data.transporter_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lr_no", "varchar(140)", isNullable: true)]
        public string? LrNo
        {
            get { return data.lr_no; }
            set { data.lr_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("lr_date", "date", isNullable: true)]
        public DateOnly? LrDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.lr_date); }
            set { data.lr_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("_user_tags", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _UserTags
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._user_tags; }
            set { data._user_tags = value; }
        }

        [ColumnInfo("_comments", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Comments
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._comments; }
            set { data._comments = value; }
        }

        [ColumnInfo("_assign", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _Assign
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._assign; }
            set { data._assign = value; }
        }

        [ColumnInfo("_liked_by", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _LikedBy
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._liked_by; }
            set { data._liked_by = value; }
        }


    }
}

