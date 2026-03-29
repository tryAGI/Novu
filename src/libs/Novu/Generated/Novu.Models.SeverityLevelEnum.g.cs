
#nullable enable

namespace Novu
{
    /// <summary>
    /// Severity of the workflow
    /// </summary>
    public enum SeverityLevelEnum
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SeverityLevelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SeverityLevelEnum value)
        {
            return value switch
            {
                SeverityLevelEnum.High => "high",
                SeverityLevelEnum.Low => "low",
                SeverityLevelEnum.Medium => "medium",
                SeverityLevelEnum.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SeverityLevelEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => SeverityLevelEnum.High,
                "low" => SeverityLevelEnum.Low,
                "medium" => SeverityLevelEnum.Medium,
                "none" => SeverityLevelEnum.None,
                _ => null,
            };
        }
    }
}