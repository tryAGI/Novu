
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum MessageReadWebhookPayloadWrapperObject
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageReadWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageReadWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                MessageReadWebhookPayloadWrapperObject.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageReadWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "message" => MessageReadWebhookPayloadWrapperObject.Message,
                _ => null,
            };
        }
    }
}