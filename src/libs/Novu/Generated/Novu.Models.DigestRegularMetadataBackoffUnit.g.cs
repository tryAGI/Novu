
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DigestRegularMetadataBackoffUnit
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
    public static class DigestRegularMetadataBackoffUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestRegularMetadataBackoffUnit value)
        {
            return value switch
            {
                DigestRegularMetadataBackoffUnit.Days => "days",
                DigestRegularMetadataBackoffUnit.Hours => "hours",
                DigestRegularMetadataBackoffUnit.Minutes => "minutes",
                DigestRegularMetadataBackoffUnit.Months => "months",
                DigestRegularMetadataBackoffUnit.Seconds => "seconds",
                DigestRegularMetadataBackoffUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestRegularMetadataBackoffUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => DigestRegularMetadataBackoffUnit.Days,
                "hours" => DigestRegularMetadataBackoffUnit.Hours,
                "minutes" => DigestRegularMetadataBackoffUnit.Minutes,
                "months" => DigestRegularMetadataBackoffUnit.Months,
                "seconds" => DigestRegularMetadataBackoffUnit.Seconds,
                "weeks" => DigestRegularMetadataBackoffUnit.Weeks,
                _ => null,
            };
        }
    }
}