
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WebhookPreferenceDtoWebhookPayloadWrapperType
    {
        /// <summary>
        /// 
        /// </summary>
        PreferenceUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPreferenceDtoWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPreferenceDtoWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WebhookPreferenceDtoWebhookPayloadWrapperType.PreferenceUpdated => "preference.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPreferenceDtoWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "preference.updated" => WebhookPreferenceDtoWebhookPayloadWrapperType.PreferenceUpdated,
                _ => null,
            };
        }
    }
}