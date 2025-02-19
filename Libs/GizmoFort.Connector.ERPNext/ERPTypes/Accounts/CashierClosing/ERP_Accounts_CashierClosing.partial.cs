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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.CashierClosing
{
    public partial class ERP_Accounts_CashierClosing : ERPNextObjectBase
    {
        public ERP_Accounts_CashierClosing() : this(new ERPObject(_DocType.Accounts_CashierClosing)) { }
        public ERP_Accounts_CashierClosing(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("user", "varchar(140)", isNullable: true)]
        public string? User
        {
            get { return data.user; }
            set { data.user = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("date", "date", isNullable: true)]
        public DateOnly? Date
        {
            get { return ERPNextConverter.StringToDateOnly(data.date); }
            set { data.date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("from_time", "time(6)", isNullable: true)]
        public TimeSpan? FromTime
        {
            get { return ERPNextConverter.StringToTimeSpan(data.from_time); }
            set { data.from_time = ERPNextConverter.TimeSpanToString(value, 6); }
        }

        [ColumnInfo("time", "time(6)", isNullable: true)]
        public TimeSpan? Time
        {
            get { return ERPNextConverter.StringToTimeSpan(data.time); }
            set { data.time = ERPNextConverter.TimeSpanToString(value, 6); }
        }

        [ColumnInfo("expense", "decimal(21,9)", isNullable: false)]
        public decimal Expense
        {
            get { return data.expense; }
            set { data.expense = value; }
        }

        [ColumnInfo("custody", "decimal(21,9)", isNullable: false)]
        public decimal Custody
        {
            get { return data.custody; }
            set { data.custody = value; }
        }

        [ColumnInfo("returns", "decimal(21,9)", isNullable: false)]
        public decimal Returns
        {
            get { return data.returns; }
            set { data.returns = value; }
        }

        [ColumnInfo("outstanding_amount", "decimal(21,9)", isNullable: false)]
        public decimal OutstandingAmount
        {
            get { return data.outstanding_amount; }
            set { data.outstanding_amount = value; }
        }

        [ColumnInfo("net_amount", "decimal(21,9)", isNullable: false)]
        public decimal NetAmount
        {
            get { return data.net_amount; }
            set { data.net_amount = value; }
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

