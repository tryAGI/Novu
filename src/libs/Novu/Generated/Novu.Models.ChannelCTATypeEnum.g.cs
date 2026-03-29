
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of call to action
    /// </summary>
    public enum ChannelCTATypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Redirect,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelCTATypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelCTATypeEnum value)
        {
            return value switch
            {
                ChannelCTATypeEnum.Redirect => "redirect",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelCTATypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "redirect" => ChannelCTATypeEnum.Redirect,
                _ => null,
            };
        }
    }
}