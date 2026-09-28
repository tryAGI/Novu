
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreferenceWebhookWeeklyScheduleDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monday")]
        public global::Novu.PreferenceWebhookDayScheduleDto? Monday { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tuesday")]
        public global::Novu.PreferenceWebhookDayScheduleDto? Tuesday { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wednesday")]
        public global::Novu.PreferenceWebhookDayScheduleDto? Wednesday { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thursday")]
        public global::Novu.PreferenceWebhookDayScheduleDto? Thursday { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("friday")]
        public global::Novu.PreferenceWebhookDayScheduleDto? Friday { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("saturday")]
        public global::Novu.PreferenceWebhookDayScheduleDto? Saturday { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sunday")]
        public global::Novu.PreferenceWebhookDayScheduleDto? Sunday { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookWeeklyScheduleDto" /> class.
        /// </summary>
        /// <param name="monday"></param>
        /// <param name="tuesday"></param>
        /// <param name="wednesday"></param>
        /// <param name="thursday"></param>
        /// <param name="friday"></param>
        /// <param name="saturday"></param>
        /// <param name="sunday"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreferenceWebhookWeeklyScheduleDto(
            global::Novu.PreferenceWebhookDayScheduleDto? monday,
            global::Novu.PreferenceWebhookDayScheduleDto? tuesday,
            global::Novu.PreferenceWebhookDayScheduleDto? wednesday,
            global::Novu.PreferenceWebhookDayScheduleDto? thursday,
            global::Novu.PreferenceWebhookDayScheduleDto? friday,
            global::Novu.PreferenceWebhookDayScheduleDto? saturday,
            global::Novu.PreferenceWebhookDayScheduleDto? sunday)
        {
            this.Monday = monday;
            this.Tuesday = tuesday;
            this.Wednesday = wednesday;
            this.Thursday = thursday;
            this.Friday = friday;
            this.Saturday = saturday;
            this.Sunday = sunday;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookWeeklyScheduleDto" /> class.
        /// </summary>
        public PreferenceWebhookWeeklyScheduleDto()
        {
        }

    }
}