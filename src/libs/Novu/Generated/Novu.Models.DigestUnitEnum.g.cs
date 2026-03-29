
#nullable enable

namespace Novu
{
    /// <summary>
    /// Regular digest: Unit for backoff
    /// </summary>
    public enum DigestUnitEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Days,
        /// <summary>
        /// 
        /// </summary>
        Hours,
        /// <summary>
        /// 
        /// </summary>
        Minutes,
        /// <summary>
        /// 
        /// </summary>
        Months,
        /// <summary>
        /// 
        /// </summary>
        Seconds,
        /// <summary>
        /// 
        /// </summary>
        Weeks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DigestUnitEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestUnitEnum value)
        {
            return value switch
            {
                DigestUnitEnum.Days => "days",
                DigestUnitEnum.Hours => "hours",
                DigestUnitEnum.Minutes => "minutes",
                DigestUnitEnum.Months => "months",
                DigestUnitEnum.Seconds => "seconds",
                DigestUnitEnum.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestUnitEnum? ToEnum(string value)
        {
            return value switch
            {
                "days" => DigestUnitEnum.Days,
                "hours" => DigestUnitEnum.Hours,
                "minutes" => DigestUnitEnum.Minutes,
                "months" => DigestUnitEnum.Months,
                "seconds" => DigestUnitEnum.Seconds,
                "weeks" => DigestUnitEnum.Weeks,
                _ => null,
            };
        }
    }
}