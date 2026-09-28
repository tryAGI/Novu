
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageReadWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageRead,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageReadWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageReadWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageReadWebhookPayloadWrapperType.MessageRead => "message.read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageReadWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.read" => MessageReadWebhookPayloadWrapperType.MessageRead,
                _ => null,
            };
        }
    }
}