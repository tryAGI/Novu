
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageUnreadWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageUnread,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageUnreadWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageUnreadWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageUnreadWebhookPayloadWrapperType.MessageUnread => "message.unread",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageUnreadWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.unread" => MessageUnreadWebhookPayloadWrapperType.MessageUnread,
                _ => null,
            };
        }
    }
}