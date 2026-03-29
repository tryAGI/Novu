
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPreferencesResponseDto
    {
        /// <summary>
        /// The level of the preference (global or template)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.PreferenceLevelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PreferenceLevelEnum Level { get; set; }

        /// <summary>
        /// Workflow information if this is a template-level preference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow")]
        public global::Novu.WorkflowDto? Workflow { get; set; }

        /// <summary>
        /// Whether the preference is enabled<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
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
        /// Condition using JSON Logic rules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public object? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPreferencesResponseDto" /> class.
        /// </summary>
        /// <param name="level">
        /// The level of the preference (global or template)
        /// </param>
        /// <param name="enabled">
        /// Whether the preference is enabled<br/>
        /// Example: true
        /// </param>
        /// <param name="channels">
        /// Channel-specific preference settings
        /// </param>
        /// <param name="workflow">
        /// Workflow information if this is a template-level preference
        /// </param>
        /// <param name="condition">
        /// Condition using JSON Logic rules
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPreferencesResponseDto(
            global::Novu.PreferenceLevelEnum level,
            bool enabled,
            global::Novu.SubscriberPreferenceChannels channels,
            global::Novu.WorkflowDto? workflow,
            object? condition)
        {
            this.Level = level;
            this.Workflow = workflow;
            this.Enabled = enabled;
            this.Channels = channels ?? throw new global::System.ArgumentNullException(nameof(channels));
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPreferencesResponseDto" /> class.
        /// </summary>
        public GetPreferencesResponseDto()
        {
        }
    }
}