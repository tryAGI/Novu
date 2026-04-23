
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WebhookInboundEmailDtoWebhookPayloadWrapperType
    {
        /// <summary>
        /// 
        /// </summary>
        EmailReceived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookInboundEmailDtoWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInboundEmailDtoWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WebhookInboundEmailDtoWebhookPayloadWrapperType.EmailReceived => "email.received",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInboundEmailDtoWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "email.received" => WebhookInboundEmailDtoWebhookPayloadWrapperType.EmailReceived,
                _ => null,
            };
        }
    }
}