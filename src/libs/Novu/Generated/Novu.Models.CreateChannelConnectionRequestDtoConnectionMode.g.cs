
#nullable enable

namespace Novu
{
    /// <summary>
    /// Connection mode that determines how the channel connection is scoped. Use "subscriber" (default) to associate the connection with a specific subscriber. Use "shared" to associate the connection with a context instead of a subscriber — subscriberId will not be stored on the connection.<br/>
    /// Example: shared
    /// </summary>
    public enum CreateChannelConnectionRequestDtoConnectionMode
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
    public static class CreateChannelConnectionRequestDtoConnectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChannelConnectionRequestDtoConnectionMode value)
        {
            return value switch
            {
                CreateChannelConnectionRequestDtoConnectionMode.Shared => "shared",
                CreateChannelConnectionRequestDtoConnectionMode.Subscriber => "subscriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChannelConnectionRequestDtoConnectionMode? ToEnum(string value)
        {
            return value switch
            {
                "shared" => CreateChannelConnectionRequestDtoConnectionMode.Shared,
                "subscriber" => CreateChannelConnectionRequestDtoConnectionMode.Subscriber,
                _ => null,
            };
        }
    }
}