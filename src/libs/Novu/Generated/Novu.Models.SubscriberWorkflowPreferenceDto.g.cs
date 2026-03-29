
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriberWorkflowPreferenceDto
    {
        /// <summary>
        /// Whether notifications are enabled for this workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Channel-specific preference settings for this workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SubscriberPreferenceChannels Channels { get; set; }

        /// <summary>
        /// List of preference overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto> Overrides { get; set; }

        /// <summary>
        /// Workflow information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SubscriberPreferencesWorkflowInfoDto Workflow { get; set; }

        /// <summary>
        /// Timestamp when the subscriber last updated their preference. Only present if subscriber explicitly set preferences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberWorkflowPreferenceDto" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether notifications are enabled for this workflow
        /// </param>
        /// <param name="channels">
        /// Channel-specific preference settings for this workflow
        /// </param>
        /// <param name="overrides">
        /// List of preference overrides
        /// </param>
        /// <param name="workflow">
        /// Workflow information
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the subscriber last updated their preference. Only present if subscriber explicitly set preferences.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriberWorkflowPreferenceDto(
            bool enabled,
            global::Novu.SubscriberPreferenceChannels channels,
            global::System.Collections.Generic.IList<global::Novu.SubscriberPreferenceOverrideDto> overrides,
            global::Novu.SubscriberPreferencesWorkflowInfoDto workflow,
            string? updatedAt)
        {
            this.Enabled = enabled;
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.Overrides = overrides ?? throw new global::System.ArgumentNullException(nameof(overrides));
            this.Workflow = workflow ?? throw new global::System.ArgumentNullException(nameof(workflow));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriberWorkflowPreferenceDto" /> class.
        /// </summary>
        public SubscriberWorkflowPreferenceDto()
        {
        }
    }
}