
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WebhookPreferenceDtoWebhookPayloadWrapperObject
    {
        /// <summary>
        /// 
        /// </summary>
        Preference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPreferenceDtoWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPreferenceDtoWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WebhookPreferenceDtoWebhookPayloadWrapperObject.Preference => "preference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPreferenceDtoWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "preference" => WebhookPreferenceDtoWebhookPayloadWrapperObject.Preference,
                _ => null,
            };
        }
    }
}