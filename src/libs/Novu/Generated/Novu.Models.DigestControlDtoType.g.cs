
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of digest strategy. Determines which fields are applicable.
    /// </summary>
    public enum DigestControlDtoType
    {
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
    public static class DigestControlDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestControlDtoType value)
        {
            return value switch
            {
                DigestControlDtoType.Regular => "regular",
                DigestControlDtoType.Timed => "timed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestControlDtoType? ToEnum(string value)
        {
            return value switch
            {
                "regular" => DigestControlDtoType.Regular,
                "timed" => DigestControlDtoType.Timed,
                _ => null,
            };
        }
    }
}