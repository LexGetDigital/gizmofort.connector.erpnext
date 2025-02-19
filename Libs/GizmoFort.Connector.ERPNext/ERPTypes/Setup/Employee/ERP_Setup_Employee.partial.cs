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

namespace GizmoFort.Connector.ERPNext.ERPTypes.Setup.Employee
{
    public partial class ERP_Setup_Employee : ERPNextObjectBase
    {
        public ERP_Setup_Employee() : this(new ERPObject(_DocType.Setup_Employee)) { }
        public ERP_Setup_Employee(ERPObject obj) : base(obj) { }

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

        [ColumnInfo("employee", "varchar(140)", isNullable: true)]
        public string? Employee
        {
            get { return data.employee; }
            set { data.employee = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("naming_series", "varchar(140)", isNullable: true)]
        public string? NamingSeries
        {
            get { return data.naming_series; }
            set { data.naming_series = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("first_name", "varchar(140)", isNullable: true)]
        public string? FirstName
        {
            get { return data.first_name; }
            set { data.first_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("middle_name", "varchar(140)", isNullable: true)]
        public string? MiddleName
        {
            get { return data.middle_name; }
            set { data.middle_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("last_name", "varchar(140)", isNullable: true)]
        public string? LastName
        {
            get { return data.last_name; }
            set { data.last_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("salutation", "varchar(140)", isNullable: true)]
        public string? Salutation
        {
            get { return data.salutation; }
            set { data.salutation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("employee_name", "varchar(140)", isNullable: true)]
        public string? EmployeeName
        {
            get { return data.employee_name; }
            set { data.employee_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("image", "text", isNullable: true)]
        public string? Image
        {
            get { return data.image; }
            set { data.image = value; }
        }

        [ColumnInfo("company", "varchar(140)", isNullable: true)]
        public string? Company
        {
            get { return data.company; }
            set { data.company = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("status", "varchar(140)", isNullable: true)]
        public string? Status
        {
            get { return data.status; }
            set { data.status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("gender", "varchar(140)", isNullable: true)]
        public string? Gender
        {
            get { return data.gender; }
            set { data.gender = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("date_of_birth", "date", isNullable: true)]
        public DateOnly? DateOfBirth
        {
            get { return ERPNextConverter.StringToDateOnly(data.date_of_birth); }
            set { data.date_of_birth = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("date_of_joining", "date", isNullable: true)]
        public DateOnly? DateOfJoining
        {
            get { return ERPNextConverter.StringToDateOnly(data.date_of_joining); }
            set { data.date_of_joining = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("employee_number", "varchar(140)", isNullable: true)]
        public string? EmployeeNumber
        {
            get { return data.employee_number; }
            set { data.employee_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("person_to_be_contacted", "varchar(140)", isNullable: true)]
        public string? PersonToBeContacted
        {
            get { return data.person_to_be_contacted; }
            set { data.person_to_be_contacted = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("relation", "varchar(140)", isNullable: true)]
        public string? Relation
        {
            get { return data.relation; }
            set { data.relation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("emergency_phone_number", "varchar(140)", isNullable: true)]
        public string? EmergencyPhoneNumber
        {
            get { return data.emergency_phone_number; }
            set { data.emergency_phone_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("user_id", "varchar(140)", isNullable: true)]
        public string? UserId
        {
            get { return data.user_id; }
            set { data.user_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("create_user_permission", "int(1)", isNullable: false)]
        public bool CreateUserPermission
        {
            get { return ERPNextConverter.IntToBool((int)data.create_user_permission); }
            set { data.create_user_permission = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("scheduled_confirmation_date", "date", isNullable: true)]
        public DateOnly? ScheduledConfirmationDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.scheduled_confirmation_date); }
            set { data.scheduled_confirmation_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("final_confirmation_date", "date", isNullable: true)]
        public DateOnly? FinalConfirmationDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.final_confirmation_date); }
            set { data.final_confirmation_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("contract_end_date", "date", isNullable: true)]
        public DateOnly? ContractEndDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.contract_end_date); }
            set { data.contract_end_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("notice_number_of_days", "int(11)", isNullable: false)]
        public int NoticeNumberOfDays
        {
            get { return data.notice_number_of_days; }
            set { data.notice_number_of_days = value; }
        }

        [ColumnInfo("date_of_retirement", "date", isNullable: true)]
        public DateOnly? DateOfRetirement
        {
            get { return ERPNextConverter.StringToDateOnly(data.date_of_retirement); }
            set { data.date_of_retirement = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("department", "varchar(140)", isNullable: true)]
        public string? Department
        {
            get { return data.department; }
            set { data.department = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("designation", "varchar(140)", isNullable: true)]
        public string? Designation
        {
            get { return data.designation; }
            set { data.designation = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("reports_to", "varchar(140)", isNullable: true)]
        public string? ReportsTo
        {
            get { return data.reports_to; }
            set { data.reports_to = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("branch", "varchar(140)", isNullable: true)]
        public string? Branch
        {
            get { return data.branch; }
            set { data.branch = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("attendance_device_id", "varchar(140)", isNullable: true)]
        public string? AttendanceDeviceId
        {
            get { return data.attendance_device_id; }
            set { data.attendance_device_id = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("holiday_list", "varchar(140)", isNullable: true)]
        public string? HolidayList
        {
            get { return data.holiday_list; }
            set { data.holiday_list = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("salary_currency", "varchar(140)", isNullable: true)]
        public string? SalaryCurrency
        {
            get { return data.salary_currency; }
            set { data.salary_currency = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("ctc", "decimal(21,9)", isNullable: false)]
        public decimal Ctc
        {
            get { return data.ctc; }
            set { data.ctc = value; }
        }

        [ColumnInfo("bank_name", "varchar(140)", isNullable: true)]
        public string? BankName
        {
            get { return data.bank_name; }
            set { data.bank_name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("bank_ac_no", "varchar(140)", isNullable: true)]
        public string? BankAcNo
        {
            get { return data.bank_ac_no; }
            set { data.bank_ac_no = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("cell_number", "varchar(140)", isNullable: true)]
        public string? CellNumber
        {
            get { return data.cell_number; }
            set { data.cell_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("prefered_email", "varchar(140)", isNullable: true)]
        public string? PreferedEmail
        {
            get { return data.prefered_email; }
            set { data.prefered_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("personal_email", "varchar(140)", isNullable: true)]
        public string? PersonalEmail
        {
            get { return data.personal_email; }
            set { data.personal_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("unsubscribed", "int(1)", isNullable: false)]
        public bool Unsubscribed
        {
            get { return ERPNextConverter.IntToBool((int)data.unsubscribed); }
            set { data.unsubscribed = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("permanent_accommodation_type", "varchar(140)", isNullable: true)]
        public string? PermanentAccommodationType
        {
            get { return data.permanent_accommodation_type; }
            set { data.permanent_accommodation_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("permanent_address", "text", isNullable: true)]
        public string? PermanentAddress
        {
            get { return data.permanent_address; }
            set { data.permanent_address = value; }
        }

        [ColumnInfo("prefered_contact_email", "varchar(140)", isNullable: true)]
        public string? PreferedContactEmail
        {
            get { return data.prefered_contact_email; }
            set { data.prefered_contact_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("company_email", "varchar(140)", isNullable: true)]
        public string? CompanyEmail
        {
            get { return data.company_email; }
            set { data.company_email = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("current_accommodation_type", "varchar(140)", isNullable: true)]
        public string? CurrentAccommodationType
        {
            get { return data.current_accommodation_type; }
            set { data.current_accommodation_type = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("current_address", "text", isNullable: true)]
        public string? CurrentAddress
        {
            get { return data.current_address; }
            set { data.current_address = value; }
        }

        [ColumnInfo("bio", "longtext", isNullable: true)]
        public string? Bio
        {
            get { return data.bio; }
            set { data.bio = value; }
        }

        [ColumnInfo("passport_number", "varchar(140)", isNullable: true)]
        public string? PassportNumber
        {
            get { return data.passport_number; }
            set { data.passport_number = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("date_of_issue", "date", isNullable: true)]
        public DateOnly? DateOfIssue
        {
            get { return ERPNextConverter.StringToDateOnly(data.date_of_issue); }
            set { data.date_of_issue = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("valid_upto", "date", isNullable: true)]
        public DateOnly? ValidUpto
        {
            get { return ERPNextConverter.StringToDateOnly(data.valid_upto); }
            set { data.valid_upto = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("place_of_issue", "varchar(140)", isNullable: true)]
        public string? PlaceOfIssue
        {
            get { return data.place_of_issue; }
            set { data.place_of_issue = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("marital_status", "varchar(140)", isNullable: true)]
        public string? MaritalStatus
        {
            get { return data.marital_status; }
            set { data.marital_status = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("blood_group", "varchar(140)", isNullable: true)]
        public string? BloodGroup
        {
            get { return data.blood_group; }
            set { data.blood_group = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("family_background", "text", isNullable: true)]
        public string? FamilyBackground
        {
            get { return data.family_background; }
            set { data.family_background = value; }
        }

        [ColumnInfo("health_details", "text", isNullable: true)]
        public string? HealthDetails
        {
            get { return data.health_details; }
            set { data.health_details = value; }
        }

        [ColumnInfo("resignation_letter_date", "date", isNullable: true)]
        public DateOnly? ResignationLetterDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.resignation_letter_date); }
            set { data.resignation_letter_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("relieving_date", "date", isNullable: true)]
        public DateOnly? RelievingDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.relieving_date); }
            set { data.relieving_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("reason_for_leaving", "text", isNullable: true)]
        public string? ReasonForLeaving
        {
            get { return data.reason_for_leaving; }
            set { data.reason_for_leaving = value; }
        }

        [ColumnInfo("leave_encashed", "varchar(140)", isNullable: true)]
        public string? LeaveEncashed
        {
            get { return data.leave_encashed; }
            set { data.leave_encashed = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("encashment_date", "date", isNullable: true)]
        public DateOnly? EncashmentDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.encashment_date); }
            set { data.encashment_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("held_on", "date", isNullable: true)]
        public DateOnly? HeldOn
        {
            get { return ERPNextConverter.StringToDateOnly(data.held_on); }
            set { data.held_on = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("new_workplace", "varchar(140)", isNullable: true)]
        public string? NewWorkplace
        {
            get { return data.new_workplace; }
            set { data.new_workplace = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("feedback", "text", isNullable: true)]
        public string? Feedback
        {
            get { return data.feedback; }
            set { data.feedback = value; }
        }

        [ColumnInfo("lft", "int(11)", isNullable: false)]
        public int Lft
        {
            get { return data.lft; }
            set { data.lft = value; }
        }

        [ColumnInfo("rgt", "int(11)", isNullable: false)]
        public int Rgt
        {
            get { return data.rgt; }
            set { data.rgt = value; }
        }

        [ColumnInfo("old_parent", "varchar(140)", isNullable: true)]
        public string? OldParent
        {
            get { return data.old_parent; }
            set { data.old_parent = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("salary_mode", "varchar(140)", isNullable: true)]
        public string? SalaryMode
        {
            get { return data.salary_mode; }
            set { data.salary_mode = ERPNextConverter.TruncateString(value, 140); }
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

