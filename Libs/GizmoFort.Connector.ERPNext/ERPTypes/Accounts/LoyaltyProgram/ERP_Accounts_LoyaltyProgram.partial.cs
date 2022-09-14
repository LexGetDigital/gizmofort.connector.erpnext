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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Accounts.LoyaltyProgram
{
    public partial class ERP_Accounts_LoyaltyProgram : ERPNextObjectBase
    {
        public ERP_Accounts_LoyaltyProgram() : this(new ERPObject(_DocType.Accounts_LoyaltyProgram)) { }
        public ERP_Accounts_LoyaltyProgram(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("loyalty_program_name", "varchar(140)", isNullable: true)]
        public string? LoyaltyProgramName
        {
            get { return data.loyalty_program_name; }
            set { data.loyalty_program_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("loyalty_program_type", "varchar(140)", isNullable: true)]
        public string? LoyaltyProgramType
        {
            get { return data.loyalty_program_type; }
            set { data.loyalty_program_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("from_date", "date", isNullable: true)]
        public DateOnly? FromDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.from_date); }
            set { data.from_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("to_date", "date", isNullable: true)]
        public DateOnly? ToDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.to_date); }
            set { data.to_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("customer_group", "varchar(140)", isNullable: true)]
        public string? CustomerGroup
        {
            get { return data.customer_group; }
            set { data.customer_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("customer_territory", "varchar(140)", isNullable: true)]
        public string? CustomerTerritory
        {
            get { return data.customer_territory; }
            set { data.customer_territory = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("auto_opt_in", "int(1)", isNullable: false)]
        public bool AutoOptIn
        {
            get { return ERPNextConverter.IntToBool((int)data.auto_opt_in); }
            set { data.auto_opt_in = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("conversion_factor", "decimal(21,9)", isNullable: false)]
        public decimal ConversionFactor
        {
            get { return data.conversion_factor; }
            set { data.conversion_factor = value; }
        }

        [ColumnInfo("expiry_duration", "int(11)", isNullable: false)]
        public int ExpiryDuration
        {
            get { return data.expiry_duration; }
            set { data.expiry_duration = value; }
        }

        [ColumnInfo("expense_account", "varchar(140)", isNullable: true)]
        public string? ExpenseAccount
        {
            get { return data.expense_account; }
            set { data.expense_account = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("cost_center", "varchar(140)", isNullable: true)]
        public string? CostCenter
        {
            get { return data.cost_center; }
            set { data.cost_center = ERPNextConverter.TruncateString(value, 140); }
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

