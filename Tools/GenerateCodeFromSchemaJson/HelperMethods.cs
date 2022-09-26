using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace GenerateCodeFromSchemaJson
{
    public static class HelperMethods
    {
        public static string ConvertColumnNameToPascalCase(string columnName)
        {
            var noUnderscores = columnName.ToLower().Replace("_", " ");
            TextInfo info = CultureInfo.CurrentCulture.TextInfo;
            var propertyName = info.ToTitleCase(noUnderscores).Replace(" ", string.Empty);
            return propertyName;
        }

        public static string KeywordFixup(string name, string prefix)
        {
            return name switch
            {
                "abstract" => $"{prefix}abstract",
                "as" => $"{prefix}as",
                "base" => $"{prefix}base",
                "bool" => $"{prefix}bool",
                "break" => $"{prefix}break",
                "byte" => $"{prefix}byte",
                "case" => $"{prefix}case",
                "catch" => $"{prefix}catch",
                "char" => $"{prefix}char",
                "checked" => $"{prefix}checked",
                "class" => $"{prefix}class",
                "const" => $"{prefix}const",
                "continue" => $"{prefix}continue",
                "decimal" => $"{prefix}decimal",
                "default" => $"{prefix}default",
                "delegate" => $"{prefix}delegate",
                "do" => $"{prefix}do",
                "double" => $"{prefix}double",
                "else" => $"{prefix}else",
                "enum" => $"{prefix}enum",
                "event" => $"{prefix}event",
                "explicit" => $"{prefix}explicit",
                "extern" => $"{prefix}extern",
                "false" => $"{prefix}false",
                "finally" => $"{prefix}finally",
                "fixed" => $"{prefix}fixed",
                "float" => $"{prefix}float",
                "for" => $"{prefix}for",
                "foreach" => $"{prefix}foreach",
                "goto" => $"{prefix}goto",
                "if" => $"{prefix}if",
                "implicit" => $"{prefix}implicit",
                "in" => $"{prefix}in",
                "int" => $"{prefix}int",
                "interface" => $"{prefix}interface",
                "internal" => $"{prefix}internal",
                "is" => $"{prefix}is",
                "lock" => $"{prefix}lock",
                "long" => $"{prefix}long",
                "namespace" => $"{prefix}namespace",
                "new" => $"{prefix}new",
                "null" => $"{prefix}null",
                "object" => $"{prefix}object",
                "operator" => $"{prefix}operator",
                "out" => $"{prefix}out",
                "override" => $"{prefix}override",
                "params" => $"{prefix}params",
                "private" => $"{prefix}private",
                "protected" => $"{prefix}protected",
                "public" => $"{prefix}public",
                "readonly" => $"{prefix}readonly",
                "ref" => $"{prefix}ref",
                "return" => $"{prefix}return",
                "sbyte" => $"{prefix}sbyte",
                "sealed" => $"{prefix}sealed",
                "short" => $"{prefix}short",
                "sizeof" => $"{prefix}sizeof",
                "stackalloc" => $"{prefix}stackalloc",
                "static" => $"{prefix}static",
                "string" => $"{prefix}string",
                "struct" => $"{prefix}struct",
                "switch" => $"{prefix}switch",
                "this" => $"{prefix}this",
                "throw" => $"{prefix}throw",
                "TRUE" => $"{prefix}TRUE",
                "try" => $"{prefix}try",
                "typeof" => $"{prefix}typeof",
                "uint" => $"{prefix}uint",
                "ulong" => $"{prefix}ulong",
                "unchecked" => $"{prefix}unchecked",
                "unsafe" => $"{prefix}unsafe",
                "ushort" => $"{prefix}ushort",
                "using" => $"{prefix}using",
                "virtual" => $"{prefix}virtual",
                "void" => $"{prefix}void",
                "volatile" => $"{prefix}volatile",
                "while" => $"{prefix}while",
                "add" => $"{prefix}add",
                "and" => $"{prefix}and",
                "alias" => $"{prefix}alias",
                "ascending" => $"{prefix}ascending",
                "args" => $"{prefix}args",
                "async" => $"{prefix}async",
                "await" => $"{prefix}await",
                "by" => $"{prefix}by",
                "descending" => $"{prefix}descending",
                "dynamic" => $"{prefix}dynamic",
                "equals" => $"{prefix}equals",
                "from" => $"{prefix}from",
                "get" => $"{prefix}get",
                "global" => $"{prefix}global",
                "group" => $"{prefix}group",
                "init" => $"{prefix}init",
                "into" => $"{prefix}into",
                "join" => $"{prefix}join",
                "let" => $"{prefix}let",
                "managed" => $"{prefix}managed",
                "nameof" => $"{prefix}nameof",
                "nint" => $"{prefix}nint",
                "not" => $"{prefix}not",
                "notnull" => $"{prefix}notnull",
                "nuint" => $"{prefix}nuint",
                "on" => $"{prefix}on",
                "or" => $"{prefix}or",
                "orderby" => $"{prefix}orderby",
                "partial" => $"{prefix}partial",
                "record" => $"{prefix}record",
                "remove" => $"{prefix}remove",
                "required" => $"{prefix}required",
                "select" => $"{prefix}select",
                "set" => $"{prefix}set",
                "unmanaged" => $"{prefix}unmanaged",
                "value" => $"{prefix}value",
                "var" => $"{prefix}var",
                "when" => $"{prefix}when",
                "where" => $"{prefix}where",
                "with" => $"{prefix}with",
                "yield" => $"{prefix}yield",
                _ => name
            };
        }
        public static string GetCSharpTypeFromColumnInfo(ColumnInfo columnInfo)
        {
            var isNullable = columnInfo.column_name != "name" && columnInfo.is_nullable == "YES";

            if (columnInfo.column_type == "int(1)")
                return "bool" + (isNullable ? "?" : string.Empty);

            return columnInfo.data_type switch
            {
                "int" => "int",
                "decimal" => "decimal",
                "text" => "string",
                "varchar" => "string",
                "datetime" => "DateTimeOffset",
                "time" => "TimeSpan",
                "date" => "DateOnly",
                "bigint" => "long",
                "longtext" => "string",
                _ => "object",
            } + (isNullable ? "?" : string.Empty);
        }

        public static string GetGetterFuncFromColumnInfo(ColumnInfo columnInfo)
        {
            var isNullable = columnInfo.column_name != "name" && columnInfo.is_nullable == "YES";

            if (columnInfo.column_type == "int(1)")
                return (isNullable ? "ERPNextConverter.NullableIntToBool((int)*)" : "ERPNextConverter.IntToBool((int)*)");

            return columnInfo.data_type switch
            {
                "int" => "*",
                "decimal" => "*",
                "text" => "*",
                "varchar" => "*",
                "datetime" => "ERPNextConverter.StringToDateTimeOffset(*)",
                "time" => "ERPNextConverter.StringToTimeSpan(*)",
                "date" => "ERPNextConverter.StringToDateOnly(*)",
                "bigint" => "*",
                "longtext" => "*",
                _ => "*",
            };
        }

        public static string GetSetterFuncFromColumnInfo(ColumnInfo columnInfo)
        {
            var isNullable = columnInfo.column_name != "name" && columnInfo.is_nullable == "YES";

            if (columnInfo.column_type == "int(1)")
                return (isNullable ? "ERPNextConverter.NullableBoolToInt(*)" : "ERPNextConverter.BoolToInt(*)");

            var nullForgivenessOperator = (isNullable ? "!" : string.Empty);

            var fracSecs = columnInfo.FractionalSecondsDigits != -1 ? $", {columnInfo.FractionalSecondsDigits}" : String.Empty;
            var stringCvt = columnInfo.StringLength != -1 ? $"ERPNextConverter.TruncateString(*, {columnInfo.StringLength})" : "*";

            return columnInfo.data_type switch
            {
                "int" => "*",
                "decimal" => "*",
                "text" => $"{stringCvt}",
                "varchar" => $"{stringCvt}",
                "datetime" => $"ERPNextConverter.DateTimeOffsetToString(*{fracSecs})",
                "time" => $"ERPNextConverter.TimeSpanToString(*{fracSecs})",
                "date" => $"ERPNextConverter.DateOnlyToString(*{fracSecs})",
                "bigint" => "*",
                "longtext" => $"{stringCvt}",
                _ => "*",
            };
        }

        public static IList<ColumnInfo> GetColumnInfo()
        {
            var columnInfos = new List<ColumnInfo>();

            var assembly = Assembly.GetExecutingAssembly();

            var resourceName = "GenerateCodeFromSchemaJson.schema_14.0.3.json";
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                using var reader = new StreamReader(stream!);
                var schemaJson = reader.ReadToEnd();
                var columnInfo = JsonSerializer.Deserialize<AllColumnInfos>(schemaJson);
                columnInfos.AddRange(columnInfo!.schema);
            }

            resourceName = "GenerateCodeFromSchemaJson.unit_test_schema.json";
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                using var reader = new StreamReader(stream!);
                var schemaJson = reader.ReadToEnd();
                var columnInfo = JsonSerializer.Deserialize<AllColumnInfos>(schemaJson);
                columnInfos.AddRange(columnInfo!.schema);
            }

            return columnInfos;
        }

        public class AllColumnInfos
        {
#pragma warning disable IDE1006 // Naming Styles
            public List<ColumnInfo> schema { get; set; } = null!;
#pragma warning restore IDE1006 // Naming Styles
        }

        public class ColumnInfo
        {
#pragma warning disable IDE1006 // Naming Styles
            public string table_name { get; set; } = null!;
            public string column_name { get; set; } = null!;
            public string is_nullable { get; set; } = null!;
            public string data_type { get; set; } = null!;
            public string column_type { get; set; } = null!;
            public string module { get; set; } = null!;
            public string doctype { get; set; } = null!;
#pragma warning restore IDE1006 // Naming Styles

            private int _intDisplayWidth = -1;
            /// <summary>
            /// NOTE: This value is relevant to the client only (i.e. for use with display padding). Integers of any width can be transmitted to the database.
            /// </summary>
            public int IntDisplayWidth { get { GetTypeParameters(); return _intDisplayWidth; } }

            private int _decimalPrecision = -1;
            public int DecimalPrecision { get { GetTypeParameters(); return _decimalPrecision; } }

            private int _decimalScale = -1;
            public int DecimalScale { get { GetTypeParameters(); return _decimalScale; } }

            private int _stringLength = -1;
            public int StringLength { get { GetTypeParameters(); return _stringLength; } }

            private int _fractionalSecondsDigits = -1;
            public int FractionalSecondsDigits { get { GetTypeParameters(); return _fractionalSecondsDigits; } }

            private bool _analyzed = false;

            private void GetTypeParameters()
            {
                if (!_analyzed)
                {
                    var pattern = "([a-zA-Z]+)(?:\\((\\d+)(?:\\,*(\\d+))*\\))";
                    var match = Regex.Match(column_type, pattern);

                    string parsed_data_type = match.Groups[1].Value.ToLower();
                    int? parameter1 = string.IsNullOrEmpty(match.Groups[2].Value) ? null : int.Parse(match.Groups[2].Value);
                    int? parameter2 = string.IsNullOrEmpty(match.Groups[3].Value) ? null : int.Parse(match.Groups[3].Value);

                    if (parsed_data_type == data_type.ToLower())
                    {
                        switch (parsed_data_type)
                        {
                            case "int":
                            case "bigint":
                                if (parameter1.HasValue) _intDisplayWidth = parameter1.Value;
                                break;

                            case "decimal":
                                if (parameter1.HasValue) _decimalPrecision = parameter1.Value;
                                if (parameter2.HasValue) _decimalScale = parameter2.Value;
                                break;

                            case "longtext":
                            case "text":
                            case "varchar":
                            case "nvarchar":
                                if (parameter1.HasValue) _stringLength = parameter1.Value;
                                break;

                            case "datetime":
                            case "time":
                                if (parameter1.HasValue) _fractionalSecondsDigits = parameter1.Value;
                                break;

                            case "date":
                                break;

                        }
                    }

                    _analyzed = true;
                }
            }

        }

    }
}
