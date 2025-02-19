/********************************************************************
    This file has been auto-generated by GenerateCodeFromSchemaJson
    created date: 9/14/2022 8:42:56 AM
********************************************************************/

using System;
using GizmoFort.Connector.ERPNext.PublicTypes;
using GizmoFort.Connector.ERPNext.WrapperTypes;
using GizmoFort.Connector.ERPNext.DataAnnotations;
using GizmoFort.Connector.ERPNext.Serialization;
using _DocType = GizmoFort.Connector.ERPNext.PublicTypes.DocType;

namespace GizmoFort.Connector.ERPNext.ERPTypes.Stock.QualityInspection
{
    public partial class ERP_Stock_QualityInspection : ERPNextObjectBase
    {
        public ERP_Stock_QualityInspection() : this(new ERPObject(_DocType.Stock_QualityInspection)) { }
        public ERP_Stock_QualityInspection(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("report_date", "date", isNullable: true)]
        public DateOnly? ReportDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.report_date); }
            set { data.report_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("inspection_type", "varchar(140)", isNullable: true)]
        public string? InspectionType
        {
            get { return data.inspection_type; }
            set { data.inspection_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_type", "varchar(140)", isNullable: true)]
        public string? ReferenceType
        {
            get { return data.reference_type; }
            set { data.reference_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reference_name", "varchar(140)", isNullable: true)]
        public string? ReferenceName
        {
            get { return data.reference_name; }
            set { data.reference_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_code", "varchar(140)", isNullable: true)]
        public string? ItemCode
        {
            get { return data.item_code; }
            set { data.item_code = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("item_serial_no", "varchar(140)", isNullable: true)]
        public string? ItemSerialNo
        {
            get { return data.item_serial_no; }
            set { data.item_serial_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("batch_no", "varchar(140)", isNullable: true)]
        public string? BatchNo
        {
            get { return data.batch_no; }
            set { data.batch_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("sample_size", "decimal(21,9)", isNullable: false)]
        public decimal SampleSize
        {
            get { return data.sample_size; }
            set { data.sample_size = value; }
        }

        [ColumnInfo("item_name", "varchar(140)", isNullable: true)]
        public string? ItemName
        {
            get { return data.item_name; }
            set { data.item_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("description", "text", isNullable: true)]
        public string? Description
        {
            get { return data.description; }
            set { data.description = value; }
        }

        [ColumnInfo("bom_no", "varchar(140)", isNullable: true)]
        public string? BomNo
        {
            get { return data.bom_no; }
            set { data.bom_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("quality_inspection_template", "varchar(140)", isNullable: true)]
        public string? QualityInspectionTemplate
        {
            get { return data.quality_inspection_template; }
            set { data.quality_inspection_template = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("inspected_by", "varchar(140)", isNullable: true)]
        public string? InspectedBy
        {
            get { return data.inspected_by; }
            set { data.inspected_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("verified_by", "varchar(140)", isNullable: true)]
        public string? VerifiedBy
        {
            get { return data.verified_by; }
            set { data.verified_by = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("remarks", "text", isNullable: true)]
        public string? Remarks
        {
            get { return data.remarks; }
            set { data.remarks = value; }
        }

        [ColumnInfo("amended_from", "varchar(140)", isNullable: true)]
        public string? AmendedFrom
        {
            get { return data.amended_from; }
            set { data.amended_from = ERPNextConverter.TruncateString(value, 140); }
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

