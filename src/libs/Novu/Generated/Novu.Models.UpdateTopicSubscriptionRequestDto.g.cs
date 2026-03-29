
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTopicSubscriptionRequestDto
    {
        /// <summary>
        /// The name of the subscription<br/>
        /// Example: My Subscription
        /// </summary>
        /// <example>My Subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The preferences of the topic. Can be a simple workflow ID string, workflow preference object, or group filter object<br/>
        /// Example: [{"workflowId":"workflow-123","condition":{"===":[{"var":"tier"},"premium"]}}]
        /// </summary>
        /// <example>[{"workflowId":"workflow-123","condition":{"===":[{"var":"tier"},"premium"]}}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? Preferences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTopicSubscriptionRequestDto" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the subscription<br/>
        /// Example: My Subscription
        /// </param>
        /// <param name="preferences">
        /// The preferences of the topic. Can be a simple workflow ID string, workflow preference object, or group filter object<br/>
        /// Example: [{"workflowId":"workflow-123","condition":{"===":[{"var":"tier"},"premium"]}}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTopicSubscriptionRequestDto(
            string? name,
            global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? preferences)
        {
            this.Name = name;
            this.Preferences = preferences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTopicSubscriptionRequestDto" /> class.
        /// </summary>
        public UpdateTopicSubscriptionRequestDto()
        {
        }
    }
}