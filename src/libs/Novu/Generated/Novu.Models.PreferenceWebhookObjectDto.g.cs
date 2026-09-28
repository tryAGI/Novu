
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreferenceWebhookObjectDto
    {
        /// <summary>
        /// Whether this preference is global or workflow-specific
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.PreferenceLevelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PreferenceLevelEnum Level { get; set; }

        /// <summary>
        /// Whether notifications are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PreferenceChannelsDto Channels { get; set; }

        /// <summary>
        /// Topic subscription identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
        public string? SubscriptionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::Novu.PreferenceWebhookWorkflowDto? Workflow { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        public global::Novu.PreferenceWebhookScheduleDto? Schedule { get; set; }

        /// <summary>
        /// JsonLogic condition controlling whether this preference applies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public object? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookObjectDto" /> class.
        /// </summary>
        /// <param name="level">
        /// Whether this preference is global or workflow-specific
        /// </param>
        /// <param name="enabled">
        /// Whether notifications are enabled
        /// </param>
        /// <param name="channels"></param>
        /// <param name="subscriptionId">
        /// Topic subscription identifier
        /// </param>
        /// <param name="workflow"></param>
        /// <param name="schedule"></param>
        /// <param name="condition">
        /// JsonLogic condition controlling whether this preference applies
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreferenceWebhookObjectDto(
            global::Novu.PreferenceLevelEnum level,
            bool enabled,
            global::Novu.PreferenceChannelsDto channels,
            string? subscriptionId,
            global::Novu.PreferenceWebhookWorkflowDto? workflow,
            global::Novu.PreferenceWebhookScheduleDto? schedule,
            object? condition)
        {
            this.Level = level;
            this.Enabled = enabled;
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.SubscriptionId = subscriptionId;
            this.Workflow = workflow;
            this.Schedule = schedule;
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookObjectDto" /> class.
        /// </summary>
        public PreferenceWebhookObjectDto()
        {
        }

    }
}