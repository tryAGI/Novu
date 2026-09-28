
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageDeletedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeletedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeletedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageDeletedWebhookPayloadWrapperType.MessageDeleted => "message.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeletedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.deleted" => MessageDeletedWebhookPayloadWrapperType.MessageDeleted,
                _ => null,
            };
        }
    }
}