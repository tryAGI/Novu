
#nullable enable

namespace Novu
{
    /// <summary>
    /// Channel type through which the message is sent
    /// </summary>
    public enum ChannelTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
        /// <summary>
        /// 
        /// </summary>
        Email,
        /// <summary>
        /// 
        /// </summary>
        InApp,
        /// <summary>
        /// 
        /// </summary>
        Push,
        /// <summary>
        /// 
        /// </summary>
        Sms,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelTypeEnum value)
        {
            return value switch
            {
                ChannelTypeEnum.Chat => "chat",
                ChannelTypeEnum.Email => "email",
                ChannelTypeEnum.InApp => "in_app",
                ChannelTypeEnum.Push => "push",
                ChannelTypeEnum.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ChannelTypeEnum.Chat,
                "email" => ChannelTypeEnum.Email,
                "in_app" => ChannelTypeEnum.InApp,
                "push" => ChannelTypeEnum.Push,
                "sms" => ChannelTypeEnum.Sms,
                _ => null,
            };
        }
    }
}