
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowPreferenceDto
    {
        /// <summary>
        /// A flag specifying if notification delivery is enabled for the workflow. If true, notification delivery is enabled by default for all channels. This setting can be overridden by the channel preferences.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// A flag specifying if the preference is read-only. If true, the preference cannot be changed by the Subscriber.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readOnly")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPreferenceDto" /> class.
        /// </summary>
        /// <param name="enabled">
        /// A flag specifying if notification delivery is enabled for the workflow. If true, notification delivery is enabled by default for all channels. This setting can be overridden by the channel preferences.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="readOnly">
        /// A flag specifying if the preference is read-only. If true, the preference cannot be changed by the Subscriber.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowPreferenceDto(
            bool enabled,
            bool readOnly)
        {
            this.Enabled = enabled;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPreferenceDto" /> class.
        /// </summary>
        public WorkflowPreferenceDto()
        {
        }
    }
}