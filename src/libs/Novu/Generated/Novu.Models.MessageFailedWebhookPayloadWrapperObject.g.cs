
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum MessageFailedWebhookPayloadWrapperObject
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageFailedWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageFailedWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                MessageFailedWebhookPayloadWrapperObject.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageFailedWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "message" => MessageFailedWebhookPayloadWrapperObject.Message,
                _ => null,
            };
        }
    }
}