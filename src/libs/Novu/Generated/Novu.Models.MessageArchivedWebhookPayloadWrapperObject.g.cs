
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum MessageArchivedWebhookPayloadWrapperObject
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageArchivedWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageArchivedWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                MessageArchivedWebhookPayloadWrapperObject.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageArchivedWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "message" => MessageArchivedWebhookPayloadWrapperObject.Message,
                _ => null,
            };
        }
    }
}