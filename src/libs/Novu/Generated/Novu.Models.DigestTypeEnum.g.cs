
#nullable enable

namespace Novu
{
    /// <summary>
    /// The Digest Type
    /// </summary>
    public enum DigestTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Backoff,
        /// <summary>
        /// 
        /// </summary>
        Regular,
        /// <summary>
        /// 
        /// </summary>
        Timed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DigestTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestTypeEnum value)
        {
            return value switch
            {
                DigestTypeEnum.Backoff => "backoff",
                DigestTypeEnum.Regular => "regular",
                DigestTypeEnum.Timed => "timed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "backoff" => DigestTypeEnum.Backoff,
                "regular" => DigestTypeEnum.Regular,
                "timed" => DigestTypeEnum.Timed,
                _ => null,
            };
        }
    }
}