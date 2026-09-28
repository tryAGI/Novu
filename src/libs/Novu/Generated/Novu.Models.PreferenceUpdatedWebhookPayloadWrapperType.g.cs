
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum PreferenceUpdatedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        PreferenceUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreferenceUpdatedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreferenceUpdatedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                PreferenceUpdatedWebhookPayloadWrapperType.PreferenceUpdated => "preference.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreferenceUpdatedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "preference.updated" => PreferenceUpdatedWebhookPayloadWrapperType.PreferenceUpdated,
                _ => null,
            };
        }
    }
}