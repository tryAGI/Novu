
#nullable enable

namespace Novu
{
    /// <summary>
    /// OAuth flow mode. Use "connect" (default) to create a workspace channel connection, or "link_user" to identify the subscriber's Slack user ID without creating a connection.<br/>
    /// Example: link_user
    /// </summary>
    public enum GenerateChatOauthUrlRequestDtoMode
    {
        /// <summary>
        /// 
        /// </summary>
        Connect,
        /// <summary>
        /// 
        /// </summary>
        LinkUser,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateChatOauthUrlRequestDtoModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateChatOauthUrlRequestDtoMode value)
        {
            return value switch
            {
                GenerateChatOauthUrlRequestDtoMode.Connect => "connect",
                GenerateChatOauthUrlRequestDtoMode.LinkUser => "link_user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateChatOauthUrlRequestDtoMode? ToEnum(string value)
        {
            return value switch
            {
                "connect" => GenerateChatOauthUrlRequestDtoMode.Connect,
                "link_user" => GenerateChatOauthUrlRequestDtoMode.LinkUser,
                _ => null,
            };
        }
    }
}