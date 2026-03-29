
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelEndpointsControllerListChannelEndpointsChannel
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
    public static class ChannelEndpointsControllerListChannelEndpointsChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelEndpointsControllerListChannelEndpointsChannel value)
        {
            return value switch
            {
                ChannelEndpointsControllerListChannelEndpointsChannel.Chat => "chat",
                ChannelEndpointsControllerListChannelEndpointsChannel.Email => "email",
                ChannelEndpointsControllerListChannelEndpointsChannel.InApp => "in_app",
                ChannelEndpointsControllerListChannelEndpointsChannel.Push => "push",
                ChannelEndpointsControllerListChannelEndpointsChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelEndpointsControllerListChannelEndpointsChannel? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ChannelEndpointsControllerListChannelEndpointsChannel.Chat,
                "email" => ChannelEndpointsControllerListChannelEndpointsChannel.Email,
                "in_app" => ChannelEndpointsControllerListChannelEndpointsChannel.InApp,
                "push" => ChannelEndpointsControllerListChannelEndpointsChannel.Push,
                "sms" => ChannelEndpointsControllerListChannelEndpointsChannel.Sms,
                _ => null,
            };
        }
    }
}