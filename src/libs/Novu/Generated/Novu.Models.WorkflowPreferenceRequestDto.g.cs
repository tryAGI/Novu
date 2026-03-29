
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowPreferenceRequestDto
    {
        /// <summary>
        /// Whether the preference is enabled. Used when condition is not provided.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Optional condition using JSON Logic rules<br/>
        /// Example: {"and":[{"===":[{"var":"tier"},"premium"]}]}
        /// </summary>
        /// <example>{"and":[{"===":[{"var":"tier"},"premium"]}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public object? Condition { get; set; }

        /// <summary>
        /// The workflow identifier<br/>
        /// Example: workflow-123
        /// </summary>
        /// <example>workflow-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPreferenceRequestDto" /> class.
        /// </summary>
        /// <param name="workflowId">
        /// The workflow identifier<br/>
        /// Example: workflow-123
        /// </param>
        /// <param name="enabled">
        /// Whether the preference is enabled. Used when condition is not provided.<br/>
        /// Example: true
        /// </param>
        /// <param name="condition">
        /// Optional condition using JSON Logic rules<br/>
        /// Example: {"and":[{"===":[{"var":"tier"},"premium"]}]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowPreferenceRequestDto(
            string workflowId,
            bool? enabled,
            object? condition)
        {
            this.Enabled = enabled;
            this.Condition = condition;
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPreferenceRequestDto" /> class.
        /// </summary>
        public WorkflowPreferenceRequestDto()
        {
        }
    }
}