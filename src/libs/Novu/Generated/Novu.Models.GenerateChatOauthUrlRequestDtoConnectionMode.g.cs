
#nullable enable

namespace Novu
{
    /// <summary>
    /// Connection mode that determines how the channel connection is scoped. Use "subscriber" (default) to associate the connection with a specific subscriber. Use "shared" to associate the connection with a context instead of a subscriber — subscriberId will not be stored on the connection.<br/>
    /// Example: shared
    /// </summary>
    public enum GenerateChatOauthUrlRequestDtoConnectionMode
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
    public static class GenerateChatOauthUrlRequestDtoConnectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateChatOauthUrlRequestDtoConnectionMode value)
        {
            return value switch
            {
                GenerateChatOauthUrlRequestDtoConnectionMode.Shared => "shared",
                GenerateChatOauthUrlRequestDtoConnectionMode.Subscriber => "subscriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateChatOauthUrlRequestDtoConnectionMode? ToEnum(string value)
        {
            return value switch
            {
                "shared" => GenerateChatOauthUrlRequestDtoConnectionMode.Shared,
                "subscriber" => GenerateChatOauthUrlRequestDtoConnectionMode.Subscriber,
                _ => null,
            };
        }
    }
}