
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WebhookInboundEmailDtoWebhookPayloadWrapperObject
    {
        /// <summary>
        /// 
        /// </summary>
        EmailInbound,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookInboundEmailDtoWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInboundEmailDtoWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WebhookInboundEmailDtoWebhookPayloadWrapperObject.EmailInbound => "email_inbound",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInboundEmailDtoWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "email_inbound" => WebhookInboundEmailDtoWebhookPayloadWrapperObject.EmailInbound,
                _ => null,
            };
        }
    }
}