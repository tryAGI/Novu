
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WebhookMessageDtoWebhookPayloadWrapperObject
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMessageDtoWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMessageDtoWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WebhookMessageDtoWebhookPayloadWrapperObject.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMessageDtoWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "message" => WebhookMessageDtoWebhookPayloadWrapperObject.Message,
                _ => null,
            };
        }
    }
}