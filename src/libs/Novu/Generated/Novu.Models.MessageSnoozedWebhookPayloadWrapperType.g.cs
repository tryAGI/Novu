
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageSnoozedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageSnoozed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageSnoozedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageSnoozedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageSnoozedWebhookPayloadWrapperType.MessageSnoozed => "message.snoozed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageSnoozedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.snoozed" => MessageSnoozedWebhookPayloadWrapperType.MessageSnoozed,
                _ => null,
            };
        }
    }
}