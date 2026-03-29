
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelConnectionsControllerListChannelConnectionsChannel
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
    public static class ChannelConnectionsControllerListChannelConnectionsChannelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelConnectionsControllerListChannelConnectionsChannel value)
        {
            return value switch
            {
                ChannelConnectionsControllerListChannelConnectionsChannel.Chat => "chat",
                ChannelConnectionsControllerListChannelConnectionsChannel.Email => "email",
                ChannelConnectionsControllerListChannelConnectionsChannel.InApp => "in_app",
                ChannelConnectionsControllerListChannelConnectionsChannel.Push => "push",
                ChannelConnectionsControllerListChannelConnectionsChannel.Sms => "sms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelConnectionsControllerListChannelConnectionsChannel? ToEnum(string value)
        {
            return value switch
            {
                "chat" => ChannelConnectionsControllerListChannelConnectionsChannel.Chat,
                "email" => ChannelConnectionsControllerListChannelConnectionsChannel.Email,
                "in_app" => ChannelConnectionsControllerListChannelConnectionsChannel.InApp,
                "push" => ChannelConnectionsControllerListChannelConnectionsChannel.Push,
                "sms" => ChannelConnectionsControllerListChannelConnectionsChannel.Sms,
                _ => null,
            };
        }
    }
}