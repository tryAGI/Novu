
#nullable enable

namespace Novu
{
    /// <summary>
    /// The channel type (email, sms, push, chat, etc.).
    /// </summary>
    public enum GetChannelEndpointResponseDtoChannel
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
    public static class GetChannelEndpointResponseDtoChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChannelEndpointResponseDtoChannel value)
        {
            return value switch
            {
                GetChannelEndpointResponseDtoChannel.Chat => "chat",
                GetChannelEndpointResponseDtoChannel.Email => "email",
                GetChannelEndpointResponseDtoChannel.InApp => "in_app",
                GetChannelEndpointResponseDtoChannel.Push => "push",
                GetChannelEndpointResponseDtoChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChannelEndpointResponseDtoChannel? ToEnum(string value)
        {
            return value switch
            {
                "chat" => GetChannelEndpointResponseDtoChannel.Chat,
                "email" => GetChannelEndpointResponseDtoChannel.Email,
                "in_app" => GetChannelEndpointResponseDtoChannel.InApp,
                "push" => GetChannelEndpointResponseDtoChannel.Push,
                "sms" => GetChannelEndpointResponseDtoChannel.Sms,
                _ => null,
            };
        }
    }
}