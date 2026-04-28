
#nullable enable

namespace Novu
{
    /// <summary>
    /// Connection mode that determines how the channel connection is scoped. "subscriber" (default) associates the connection with a specific subscriber. "shared" associates the connection with a context instead of a subscriber.<br/>
    /// Example: shared
    /// </summary>
    public enum GenerateConnectOauthUrlRequestDtoConnectionMode
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
    public static class GenerateConnectOauthUrlRequestDtoConnectionModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateConnectOauthUrlRequestDtoConnectionMode value)
        {
            return value switch
            {
                GenerateConnectOauthUrlRequestDtoConnectionMode.Shared => "shared",
                GenerateConnectOauthUrlRequestDtoConnectionMode.Subscriber => "subscriber",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateConnectOauthUrlRequestDtoConnectionMode? ToEnum(string value)
        {
            return value switch
            {
                "shared" => GenerateConnectOauthUrlRequestDtoConnectionMode.Shared,
                "subscriber" => GenerateConnectOauthUrlRequestDtoConnectionMode.Subscriber,
                _ => null,
            };
        }
    }
}