
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of the layout
    /// </summary>
    public enum ResourceTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Bridge,
        /// <summary>
        /// 
        /// </summary>
        Echo,
        /// <summary>
        /// 
        /// </summary>
        Regular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResourceTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResourceTypeEnum value)
        {
            return value switch
            {
                ResourceTypeEnum.Bridge => "BRIDGE",
                ResourceTypeEnum.Echo => "ECHO",
                ResourceTypeEnum.Regular => "REGULAR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResourceTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "BRIDGE" => ResourceTypeEnum.Bridge,
                "ECHO" => ResourceTypeEnum.Echo,
                "REGULAR" => ResourceTypeEnum.Regular,
                _ => null,
            };
        }
    }
}