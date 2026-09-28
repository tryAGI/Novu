
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum EmailReceivedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        EmailReceived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailReceivedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailReceivedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                EmailReceivedWebhookPayloadWrapperType.EmailReceived => "email.received",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailReceivedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "email.received" => EmailReceivedWebhookPayloadWrapperType.EmailReceived,
                _ => null,
            };
        }
    }
}