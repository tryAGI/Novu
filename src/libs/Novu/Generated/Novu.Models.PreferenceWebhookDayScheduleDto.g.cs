
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreferenceWebhookDayScheduleDto
    {
        /// <summary>
        /// Whether delivery is enabled on this weekday
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        /// Delivery windows for this weekday
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hours")]
        public global::System.Collections.Generic.IList<global::Novu.PreferenceWebhookTimeRangeDto>? Hours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookDayScheduleDto" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Whether delivery is enabled on this weekday
        /// </param>
        /// <param name="hours">
        /// Delivery windows for this weekday
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreferenceWebhookDayScheduleDto(
            bool isEnabled,
            global::System.Collections.Generic.IList<global::Novu.PreferenceWebhookTimeRangeDto>? hours)
        {
            this.IsEnabled = isEnabled;
            this.Hours = hours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookDayScheduleDto" /> class.
        /// </summary>
        public PreferenceWebhookDayScheduleDto()
        {
        }

    }
}