
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChannelConnectionsControllerListChannelConnectionsConnectionMode
    {
        /// <summary>
        /// 
        /// </summary>
        Shared,
        /// <summary>
        /// 
        /// </summary>
        Subscriber,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelConnectionsControllerListChannelConnectionsConnectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelConnectionsControllerListChannelConnectionsConnectionMode value)
        {
            return value switch
            {
                ChannelConnectionsControllerListChannelConnectionsConnectionMode.Shared => "shared",
                ChannelConnectionsControllerListChannelConnectionsConnectionMode.Subscriber => "subscriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelConnectionsControllerListChannelConnectionsConnectionMode? ToEnum(string value)
        {
            return value switch
            {
                "shared" => ChannelConnectionsControllerListChannelConnectionsConnectionMode.Shared,
                "subscriber" => ChannelConnectionsControllerListChannelConnectionsConnectionMode.Subscriber,
                _ => null,
            };
        }
    }
}