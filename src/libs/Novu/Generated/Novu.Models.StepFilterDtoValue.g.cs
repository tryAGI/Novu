
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum StepFilterDtoValue
    {
        /// <summary>
        /// 
        /// </summary>
        And,
        /// <summary>
        /// 
        /// </summary>
        Or,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepFilterDtoValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepFilterDtoValue value)
        {
            return value switch
            {
                StepFilterDtoValue.And => "AND",
                StepFilterDtoValue.Or => "OR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepFilterDtoValue? ToEnum(string value)
        {
            return value switch
            {
                "AND" => StepFilterDtoValue.And,
                "OR" => StepFilterDtoValue.Or,
                _ => null,
            };
        }
    }
}