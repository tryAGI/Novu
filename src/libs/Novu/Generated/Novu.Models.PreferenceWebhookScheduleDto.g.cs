
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreferenceWebhookScheduleDto
    {
        /// <summary>
        /// Whether the delivery schedule is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isEnabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weeklySchedule")]
        public global::Novu.PreferenceWebhookWeeklyScheduleDto? WeeklySchedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookScheduleDto" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Whether the delivery schedule is enabled
        /// </param>
        /// <param name="weeklySchedule"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreferenceWebhookScheduleDto(
            bool isEnabled,
            global::Novu.PreferenceWebhookWeeklyScheduleDto? weeklySchedule)
        {
            this.IsEnabled = isEnabled;
            this.WeeklySchedule = weeklySchedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookScheduleDto" /> class.
        /// </summary>
        public PreferenceWebhookScheduleDto()
        {
        }

    }
}