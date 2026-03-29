
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionPreferenceDto
    {
        /// <summary>
        /// The unique identifier of the subscription<br/>
        /// Example: 64f5e95d3d7946d80d0cb679
        /// </summary>
        /// <example>64f5e95d3d7946d80d0cb679</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriptionId { get; set; }

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
        /// Optional condition using JSON Logic rules<br/>
        /// Example: {"and":[{"===":[{"var":"tier"},"premium"]}]}
        /// </summary>
        /// <example>{"and":[{"===":[{"var":"tier"},"premium"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public object? Condition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPreferenceDto" /> class.
        /// </summary>
        /// <param name="subscriptionId">
        /// The unique identifier of the subscription<br/>
        /// Example: 64f5e95d3d7946d80d0cb679
        /// </param>
        /// <param name="enabled">
        /// Whether the preference is enabled<br/>
        /// Example: true
        /// </param>
        /// <param name="workflow">
        /// Workflow information if this is a template-level preference
        /// </param>
        /// <param name="condition">
        /// Optional condition using JSON Logic rules<br/>
        /// Example: {"and":[{"===":[{"var":"tier"},"premium"]}]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionPreferenceDto(
            string subscriptionId,
            bool enabled,
            global::Novu.WorkflowDto? workflow,
            object? condition)
        {
            this.SubscriptionId = subscriptionId ?? throw new global::System.ArgumentNullException(nameof(subscriptionId));
            this.Workflow = workflow;
            this.Enabled = enabled;
            this.Condition = condition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPreferenceDto" /> class.
        /// </summary>
        public SubscriptionPreferenceDto()
        {
        }
    }
}