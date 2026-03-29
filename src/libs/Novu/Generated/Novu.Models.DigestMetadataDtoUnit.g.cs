
#nullable enable

namespace Novu
{
    /// <summary>
    /// Unit of the digest
    /// </summary>
    public enum DigestMetadataDtoUnit
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
    public static class DigestMetadataDtoUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestMetadataDtoUnit value)
        {
            return value switch
            {
                DigestMetadataDtoUnit.Days => "days",
                DigestMetadataDtoUnit.Hours => "hours",
                DigestMetadataDtoUnit.Minutes => "minutes",
                DigestMetadataDtoUnit.Months => "months",
                DigestMetadataDtoUnit.Seconds => "seconds",
                DigestMetadataDtoUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestMetadataDtoUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => DigestMetadataDtoUnit.Days,
                "hours" => DigestMetadataDtoUnit.Hours,
                "minutes" => DigestMetadataDtoUnit.Minutes,
                "months" => DigestMetadataDtoUnit.Months,
                "seconds" => DigestMetadataDtoUnit.Seconds,
                "weeks" => DigestMetadataDtoUnit.Weeks,
                _ => null,
            };
        }
    }
}