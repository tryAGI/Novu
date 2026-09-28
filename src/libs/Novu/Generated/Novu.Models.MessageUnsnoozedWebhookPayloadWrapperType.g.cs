
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageUnsnoozedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageUnsnoozed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageUnsnoozedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageUnsnoozedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageUnsnoozedWebhookPayloadWrapperType.MessageUnsnoozed => "message.unsnoozed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageUnsnoozedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.unsnoozed" => MessageUnsnoozedWebhookPayloadWrapperType.MessageUnsnoozed,
                _ => null,
            };
        }
    }
}