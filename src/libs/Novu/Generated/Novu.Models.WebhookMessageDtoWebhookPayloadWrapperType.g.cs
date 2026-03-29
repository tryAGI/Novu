
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WebhookMessageDtoWebhookPayloadWrapperType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageSent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMessageDtoWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMessageDtoWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WebhookMessageDtoWebhookPayloadWrapperType.MessageSent => "message.sent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMessageDtoWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.sent" => WebhookMessageDtoWebhookPayloadWrapperType.MessageSent,
                _ => null,
            };
        }
    }
}