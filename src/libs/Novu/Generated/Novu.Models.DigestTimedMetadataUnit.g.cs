
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DigestTimedMetadataUnit
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
    public static class DigestTimedMetadataUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestTimedMetadataUnit value)
        {
            return value switch
            {
                DigestTimedMetadataUnit.Days => "days",
                DigestTimedMetadataUnit.Hours => "hours",
                DigestTimedMetadataUnit.Minutes => "minutes",
                DigestTimedMetadataUnit.Months => "months",
                DigestTimedMetadataUnit.Seconds => "seconds",
                DigestTimedMetadataUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestTimedMetadataUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => DigestTimedMetadataUnit.Days,
                "hours" => DigestTimedMetadataUnit.Hours,
                "minutes" => DigestTimedMetadataUnit.Minutes,
                "months" => DigestTimedMetadataUnit.Months,
                "seconds" => DigestTimedMetadataUnit.Seconds,
                "weeks" => DigestTimedMetadataUnit.Weeks,
                _ => null,
            };
        }
    }
}