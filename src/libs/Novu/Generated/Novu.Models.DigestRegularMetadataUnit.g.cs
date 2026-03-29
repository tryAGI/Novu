
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DigestRegularMetadataUnit
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
    public static class DigestRegularMetadataUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestRegularMetadataUnit value)
        {
            return value switch
            {
                DigestRegularMetadataUnit.Days => "days",
                DigestRegularMetadataUnit.Hours => "hours",
                DigestRegularMetadataUnit.Minutes => "minutes",
                DigestRegularMetadataUnit.Months => "months",
                DigestRegularMetadataUnit.Seconds => "seconds",
                DigestRegularMetadataUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestRegularMetadataUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => DigestRegularMetadataUnit.Days,
                "hours" => DigestRegularMetadataUnit.Hours,
                "minutes" => DigestRegularMetadataUnit.Minutes,
                "months" => DigestRegularMetadataUnit.Months,
                "seconds" => DigestRegularMetadataUnit.Seconds,
                "weeks" => DigestRegularMetadataUnit.Weeks,
                _ => null,
            };
        }
    }
}