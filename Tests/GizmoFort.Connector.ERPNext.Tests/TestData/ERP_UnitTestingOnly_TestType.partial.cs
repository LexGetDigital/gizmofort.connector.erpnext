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

namespace GizmoFort.Connector.ERPNext.ERPTypes.UnitTestingOnly.TestType
{
    public partial class ERP_UnitTestingOnly_TestType : ERPNextObjectBase
    {
        public ERP_UnitTestingOnly_TestType() : this(new ERPObject(_DocType.UnitTestingOnly_TestType)) { }
        public ERP_UnitTestingOnly_TestType(ERPObject obj) : base(obj) { }

        //public static string? GetColumnName(string propertyName)
        //{
        //    return ERPNextObjectBase.GetColumnName<ERP_UnitTestingOnly_TestType>(propertyName);
        //}

        //public static string? GetPropertyName(string columnName)
        //{
        //    return ERPNextObjectBase.GetPropertyName<ERP_UnitTestingOnly_TestType>(columnName);
        //}

        [ColumnInfo("name", "varchar(140)", isNullable: false)]
        public string Name
        {
            get { return data.name; }
            set { data.name = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("flag", "int(1)", isNullable: false)]
        public bool Flag
        {
            get { return ERPNextConverter.IntToBool((int)data.flag); }
            set { data.flag = ERPNextConverter.BoolToInt(value); }
        }

        [ColumnInfo("int_width_eight", "int(8)", isNullable: false)]
        public int IntWidthEight
        {
            get { return data.int_width_eight; }
            set { data.int_width_eight = value; }
        }

        [ColumnInfo("int_width_eleven", "int(11)", isNullable: false)]
        public int IntWidthEleven
        {
            get { return data.int_width_eleven; }
            set { data.int_width_eleven = value; }
        }

        [ColumnInfo("nullable_int_width_eleven", "int(11)", isNullable: true)]
        public int? NullableIntWidthEleven
        {
            get { return data.nullable_int_width_eleven; }
            set { data.nullable_int_width_eleven = value; }
        }

        [ColumnInfo("bigint_width_20", "bigint(20)", isNullable: false)]
        public long BigintWidth20
        {
            get { return data.bigint_width_20; }
            set { data.bigint_width_20 = value; }
        }

        [ColumnInfo("nullable_date", "date", isNullable: true)]
        public DateOnly? NullableDate
        {
            get { return ERPNextConverter.StringToDateOnly(data.nullable_date); }
            set { data.nullable_date = ERPNextConverter.DateOnlyToString(value); }
        }

        [ColumnInfo("nullable_datetime_width_six", "datetime(6)", isNullable: true)]
        public DateTimeOffset? NullableDatetimeWidthSix
        {
            get { return ERPNextConverter.StringToDateTimeOffset(data.nullable_datetime_width_six); }
            set { data.nullable_datetime_width_six = ERPNextConverter.DateTimeOffsetToString(value, 6); }
        }

        [ColumnInfo("nullable_time_width_six", "time(6)", isNullable: true)]
        public TimeSpan? NullableTimeWidthSix
        {
            get { return ERPNextConverter.StringToTimeSpan(data.nullable_time_width_six); }
            set { data.nullable_time_width_six = ERPNextConverter.TimeSpanToString(value, 6); }
        }

        [ColumnInfo("decimal_twentyone_by_nine", "decimal(21,9)", isNullable: false)]
        public decimal DecimalTwentyoneByNine
        {
            get { return data.decimal_twentyone_by_nine; }
            set { data.decimal_twentyone_by_nine = value; }
        }

        [ColumnInfo("nullable_decimal_twentyone_by_nine", "decimal(21,9)", isNullable: true)]
        public decimal? NullableDecimalTwentyoneByNine
        {
            get { return data.nullable_decimal_twentyone_by_nine; }
            set { data.nullable_decimal_twentyone_by_nine = value; }
        }

        [ColumnInfo("nullable_decimal_three_by_two", "decimal(3,2)", isNullable: true)]
        public decimal? NullableDecimalThreeByTwo
        {
            get { return data.nullable_decimal_three_by_two; }
            set { data.nullable_decimal_three_by_two = value; }
        }

        [ColumnInfo("nullable_longtext", "longtext", isNullable: true)]
        public string? NullableLongtext
        {
            get { return data.nullable_longtext; }
            set { data.nullable_longtext = value; }
        }

        [ColumnInfo("_nullable_text_underscore", "text", isNullable: true)]
#pragma warning disable IDE1006 // Naming Styles
        public string? _NullableTextUnderscore
#pragma warning restore IDE1006 // Naming Styles
        {
            get { return data._nullable_text_underscore; }
            set { data._nullable_text_underscore = value; }
        }

        [ColumnInfo("nullable_varchar_width_four", "varchar(4)", isNullable: true)]
        public string? NullableVarcharWidthFour
        {
            get { return data.nullable_varchar_width_four; }
            set { data.nullable_varchar_width_four = ERPNextConverter.TruncateString(value, 4); }
        }

        [ColumnInfo("nulable_varchar_width_nine_nine_five", "varchar(995)", isNullable: true)]
        public string? NulableVarcharWidthNineNineFive
        {
            get { return data.nulable_varchar_width_nine_nine_five; }
            set { data.nulable_varchar_width_nine_nine_five = ERPNextConverter.TruncateString(value, 995); }
        }

        [ColumnInfo("varchar_width_one_four_zero", "varchar(140)", isNullable: false)]
        public string VarcharWidthOneFourZero
        {
            get { return data.varchar_width_one_four_zero; }
            set { data.varchar_width_one_four_zero = ERPNextConverter.TruncateString(value, 140); }
        }

        [ColumnInfo("varchar_width_two_five_five", "varchar(255)", isNullable: false)]
        public string VarcharWidthTwoFiveFive
        {
            get { return data.varchar_width_two_five_five; }
            set { data.varchar_width_two_five_five = ERPNextConverter.TruncateString(value, 255); }
        }


    }
}

