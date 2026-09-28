
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum MessageDeliveredWebhookPayloadWrapperObject
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeliveredWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeliveredWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                MessageDeliveredWebhookPayloadWrapperObject.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeliveredWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "message" => MessageDeliveredWebhookPayloadWrapperObject.Message,
                _ => null,
            };
        }
    }
}