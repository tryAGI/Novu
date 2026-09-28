
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum MessageSeenWebhookPayloadWrapperObject
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageSeenWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSeenWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                MessageSeenWebhookPayloadWrapperObject.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSeenWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "message" => MessageSeenWebhookPayloadWrapperObject.Message,
                _ => null,
            };
        }
    }
}