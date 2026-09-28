
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageFailedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageFailedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageFailedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageFailedWebhookPayloadWrapperType.MessageFailed => "message.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageFailedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.failed" => MessageFailedWebhookPayloadWrapperType.MessageFailed,
                _ => null,
            };
        }
    }
}