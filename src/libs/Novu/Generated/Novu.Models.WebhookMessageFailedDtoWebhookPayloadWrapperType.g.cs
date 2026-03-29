
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WebhookMessageFailedDtoWebhookPayloadWrapperType
    {
        /// <summary>
        /// 
        /// </summary>
        MessageFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMessageFailedDtoWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMessageFailedDtoWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WebhookMessageFailedDtoWebhookPayloadWrapperType.MessageFailed => "message.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMessageFailedDtoWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "message.failed" => WebhookMessageFailedDtoWebhookPayloadWrapperType.MessageFailed,
                _ => null,
            };
        }
    }
}