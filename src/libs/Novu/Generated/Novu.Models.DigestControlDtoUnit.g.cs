
#nullable enable

namespace Novu
{
    /// <summary>
    /// The unit of time for the digest interval (for REGULAR type).
    /// </summary>
    public enum DigestControlDtoUnit
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
    public static class DigestControlDtoUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestControlDtoUnit value)
        {
            return value switch
            {
                DigestControlDtoUnit.Days => "days",
                DigestControlDtoUnit.Hours => "hours",
                DigestControlDtoUnit.Minutes => "minutes",
                DigestControlDtoUnit.Months => "months",
                DigestControlDtoUnit.Seconds => "seconds",
                DigestControlDtoUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestControlDtoUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => DigestControlDtoUnit.Days,
                "hours" => DigestControlDtoUnit.Hours,
                "minutes" => DigestControlDtoUnit.Minutes,
                "months" => DigestControlDtoUnit.Months,
                "seconds" => DigestControlDtoUnit.Seconds,
                "weeks" => DigestControlDtoUnit.Weeks,
                _ => null,
            };
        }
    }
}