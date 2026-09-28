
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageSentWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageSent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageSentWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSentWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageSentWebhookPayloadWrapperType.MessageSent => "message.sent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSentWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.sent" => MessageSentWebhookPayloadWrapperType.MessageSent,
                _ => null,
            };
        }
    }
}