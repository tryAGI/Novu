
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DirectionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DirectionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DirectionEnum value)
        {
            return value switch
            {
                DirectionEnum.Asc => "ASC",
                DirectionEnum.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DirectionEnum? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => DirectionEnum.Asc,
                "DESC" => DirectionEnum.Desc,
                _ => null,
            };
        }
    }
}