
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum FieldFilterPartDtoOperator
    {
        /// <summary>
        /// 
        /// </summary>
        AllIn,
        /// <summary>
        /// 
        /// </summary>
        AnyIn,
        /// <summary>
        /// 
        /// </summary>
        Between,
        /// <summary>
        /// 
        /// </summary>
        Equal,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        Larger,
        /// <summary>
        /// 
        /// </summary>
        LargerEqual,
        /// <summary>
        /// 
        /// </summary>
        Like,
        /// <summary>
        /// 
        /// </summary>
        NotBetween,
        /// <summary>
        /// 
        /// </summary>
        NotEqual,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
        /// <summary>
        /// 
        /// </summary>
        NotLike,
        /// <summary>
        /// 
        /// </summary>
        Smaller,
        /// <summary>
        /// 
        /// </summary>
        SmallerEqual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FieldFilterPartDtoOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FieldFilterPartDtoOperator value)
        {
            return value switch
            {
                FieldFilterPartDtoOperator.AllIn => "ALL_IN",
                FieldFilterPartDtoOperator.AnyIn => "ANY_IN",
                FieldFilterPartDtoOperator.Between => "BETWEEN",
                FieldFilterPartDtoOperator.Equal => "EQUAL",
                FieldFilterPartDtoOperator.In => "IN",
                FieldFilterPartDtoOperator.Larger => "LARGER",
                FieldFilterPartDtoOperator.LargerEqual => "LARGER_EQUAL",
                FieldFilterPartDtoOperator.Like => "LIKE",
                FieldFilterPartDtoOperator.NotBetween => "NOT_BETWEEN",
                FieldFilterPartDtoOperator.NotEqual => "NOT_EQUAL",
                FieldFilterPartDtoOperator.NotIn => "NOT_IN",
                FieldFilterPartDtoOperator.NotLike => "NOT_LIKE",
                FieldFilterPartDtoOperator.Smaller => "SMALLER",
                FieldFilterPartDtoOperator.SmallerEqual => "SMALLER_EQUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FieldFilterPartDtoOperator? ToEnum(string value)
        {
            return value switch
            {
                "ALL_IN" => FieldFilterPartDtoOperator.AllIn,
                "ANY_IN" => FieldFilterPartDtoOperator.AnyIn,
                "BETWEEN" => FieldFilterPartDtoOperator.Between,
                "EQUAL" => FieldFilterPartDtoOperator.Equal,
                "IN" => FieldFilterPartDtoOperator.In,
                "LARGER" => FieldFilterPartDtoOperator.Larger,
                "LARGER_EQUAL" => FieldFilterPartDtoOperator.LargerEqual,
                "LIKE" => FieldFilterPartDtoOperator.Like,
                "NOT_BETWEEN" => FieldFilterPartDtoOperator.NotBetween,
                "NOT_EQUAL" => FieldFilterPartDtoOperator.NotEqual,
                "NOT_IN" => FieldFilterPartDtoOperator.NotIn,
                "NOT_LIKE" => FieldFilterPartDtoOperator.NotLike,
                "SMALLER" => FieldFilterPartDtoOperator.Smaller,
                "SMALLER_EQUAL" => FieldFilterPartDtoOperator.SmallerEqual,
                _ => null,
            };
        }
    }
}