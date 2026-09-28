
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum MessageArchivedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        MessageArchived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageArchivedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageArchivedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                MessageArchivedWebhookPayloadWrapperType.MessageArchived => "message.archived",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageArchivedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.archived" => MessageArchivedWebhookPayloadWrapperType.MessageArchived,
                _ => null,
            };
        }
    }
}