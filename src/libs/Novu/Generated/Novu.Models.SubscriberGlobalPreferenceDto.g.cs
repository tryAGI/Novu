
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriberGlobalPreferenceDto
    {
        /// <summary>
        /// Whether notifications are enabled globally
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Channel-specific preference settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SubscriberPreferenceChannels Channels { get; set; }

        /// <summary>
        /// Subscriber schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public global::Novu.ScheduleDto? Schedule { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberGlobalPreferenceDto" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether notifications are enabled globally
        /// </param>
        /// <param name="channels">
        /// Channel-specific preference settings
        /// </param>
        /// <param name="schedule">
        /// Subscriber schedule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriberGlobalPreferenceDto(
            bool enabled,
            global::Novu.SubscriberPreferenceChannels channels,
            global::Novu.ScheduleDto? schedule)
        {
            this.Enabled = enabled;
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.Schedule = schedule;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberGlobalPreferenceDto" /> class.
        /// </summary>
        public SubscriberGlobalPreferenceDto()
        {
        }
    }
}