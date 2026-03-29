
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WebhookMessageFailedDtoWebhookPayloadWrapperObject
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMessageFailedDtoWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMessageFailedDtoWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WebhookMessageFailedDtoWebhookPayloadWrapperObject.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMessageFailedDtoWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "message" => WebhookMessageFailedDtoWebhookPayloadWrapperObject.Message,
                _ => null,
            };
        }
    }
}