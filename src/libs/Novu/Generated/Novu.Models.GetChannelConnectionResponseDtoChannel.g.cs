
#nullable enable

namespace Novu
{
    /// <summary>
    /// The channel type (email, sms, push, chat, etc.).
    /// </summary>
    public enum GetChannelConnectionResponseDtoChannel
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
    public static class GetChannelConnectionResponseDtoChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChannelConnectionResponseDtoChannel value)
        {
            return value switch
            {
                GetChannelConnectionResponseDtoChannel.Chat => "chat",
                GetChannelConnectionResponseDtoChannel.Email => "email",
                GetChannelConnectionResponseDtoChannel.InApp => "in_app",
                GetChannelConnectionResponseDtoChannel.Push => "push",
                GetChannelConnectionResponseDtoChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChannelConnectionResponseDtoChannel? ToEnum(string value)
        {
            return value switch
            {
                "chat" => GetChannelConnectionResponseDtoChannel.Chat,
                "email" => GetChannelConnectionResponseDtoChannel.Email,
                "in_app" => GetChannelConnectionResponseDtoChannel.InApp,
                "push" => GetChannelConnectionResponseDtoChannel.Push,
                "sms" => GetChannelConnectionResponseDtoChannel.Sms,
                _ => null,
            };
        }
    }
}