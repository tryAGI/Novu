
#nullable enable

namespace Novu
{
    /// <summary>
    /// Ordinal position for the digest
    /// </summary>
    public enum OrdinalEnum
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
        /// <summary>
        /// 
        /// </summary>
        x2,
        /// <summary>
        /// 
        /// </summary>
        x3,
        /// <summary>
        /// 
        /// </summary>
        x4,
        /// <summary>
        /// 
        /// </summary>
        x5,
        /// <summary>
        /// 
        /// </summary>
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrdinalEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrdinalEnum value)
        {
            return value switch
            {
                OrdinalEnum.x1 => "1",
                OrdinalEnum.x2 => "2",
                OrdinalEnum.x3 => "3",
                OrdinalEnum.x4 => "4",
                OrdinalEnum.x5 => "5",
                OrdinalEnum.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrdinalEnum? ToEnum(string value)
        {
            return value switch
            {
                "1" => OrdinalEnum.x1,
                "2" => OrdinalEnum.x2,
                "3" => OrdinalEnum.x3,
                "4" => OrdinalEnum.x4,
                "5" => OrdinalEnum.x5,
                "last" => OrdinalEnum.Last,
                _ => null,
            };
        }
    }
}