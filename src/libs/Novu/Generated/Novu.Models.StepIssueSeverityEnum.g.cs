
#nullable enable

namespace Novu
{
    /// <summary>
    /// Blocking severity of the issue. `error` (default when omitted) blocks save; `warning` is a non-blocking notice.
    /// </summary>
    public enum StepIssueSeverityEnum
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepIssueSeverityEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepIssueSeverityEnum value)
        {
            return value switch
            {
                StepIssueSeverityEnum.Error => "error",
                StepIssueSeverityEnum.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepIssueSeverityEnum? ToEnum(string value)
        {
            return value switch
            {
                "error" => StepIssueSeverityEnum.Error,
                "warning" => StepIssueSeverityEnum.Warning,
                _ => null,
            };
        }
    }
}