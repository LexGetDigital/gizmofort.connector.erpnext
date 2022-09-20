using System;
using System.Runtime.CompilerServices;

namespace GizmoFort.Connector.ERPNext.PublicTypes
{
    public class ERPFilter
    {
        public DocType DocType { get; set; }
        public string TargetField { get; set; }
        public OperatorFilter OperatorFilter { get; set; }
        public object Operand
        {
            get
            {
                switch (OperatorFilter)
                {
                    case OperatorFilter.In:
                    case OperatorFilter.NotIn:
                        return _operands;

                    default:
                        return _operands[0];

                }
            }
        }

        private readonly string[] _operands;

        public ERPFilter(DocType docType, string targetField, OperatorFilter @operator, params string[] operands)
        {
            DocType = docType;
            TargetField = targetField;
            OperatorFilter = @operator;

            _operands = operands;
        }
    }

    public enum OperatorFilter
    {
        Equals,
        NotEquals,
        GreaterThan,
        LessThan,
        GreaterThanOrEqual,
        LessThanOrEqual,
        Like,
        NotLike,
        In,
        NotIn,
    }

    public class OperatorFilterUtils
    {
        public static string ToString(OperatorFilter opFilter) {
            switch (opFilter)
            {
                case OperatorFilter.Equals:
                    return "=";
                case OperatorFilter.NotEquals:
                    return "!=";
                case OperatorFilter.GreaterThan:
                    return ">";
                case OperatorFilter.LessThan:
                    return "<";
                case OperatorFilter.GreaterThanOrEqual:
                    return ">=";
                case OperatorFilter.LessThanOrEqual:
                    return "<=";
                case OperatorFilter.Like:
                    return "like";
                case OperatorFilter.NotLike:
                    return "not like";
                case OperatorFilter.In:
                    return "in";
                case OperatorFilter.NotIn:
                    return "not in";
                default:
                    throw new ArgumentOutOfRangeException(nameof(opFilter), opFilter, null);
            }
        }
    }
}