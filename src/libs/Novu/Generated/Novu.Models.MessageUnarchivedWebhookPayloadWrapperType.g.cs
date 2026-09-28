
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageUnarchivedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageUnarchived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageUnarchivedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageUnarchivedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageUnarchivedWebhookPayloadWrapperType.MessageUnarchived => "message.unarchived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageUnarchivedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.unarchived" => MessageUnarchivedWebhookPayloadWrapperType.MessageUnarchived,
                _ => null,
            };
        }
    }
}