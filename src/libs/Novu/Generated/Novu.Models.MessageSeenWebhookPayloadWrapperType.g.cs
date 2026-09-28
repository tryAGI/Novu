
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageSeenWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageSeen,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageSeenWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSeenWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageSeenWebhookPayloadWrapperType.MessageSeen => "message.seen",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSeenWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.seen" => MessageSeenWebhookPayloadWrapperType.MessageSeen,
                _ => null,
            };
        }
    }
}