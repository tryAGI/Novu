
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DigestRegularMetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        Backoff,
        /// <summary>
        /// 
        /// </summary>
        Regular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DigestRegularMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestRegularMetadataType value)
        {
            return value switch
            {
                DigestRegularMetadataType.Backoff => "backoff",
                DigestRegularMetadataType.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestRegularMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "backoff" => DigestRegularMetadataType.Backoff,
                "regular" => DigestRegularMetadataType.Regular,
                _ => null,
            };
        }
    }
}