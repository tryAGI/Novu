
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageDeliveredWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageDelivered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeliveredWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeliveredWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageDeliveredWebhookPayloadWrapperType.MessageDelivered => "message.delivered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeliveredWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.delivered" => MessageDeliveredWebhookPayloadWrapperType.MessageDelivered,
                _ => null,
            };
        }
    }
}