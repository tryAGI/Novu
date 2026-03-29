
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTopicSubscriptionsRequestDto
    {
        /// <summary>
        /// List of subscriber IDs to subscribe to the topic (max: 100). @deprecated Use the "subscriptions" property instead.<br/>
        /// Example: [subscriberId1, subscriberId2]
        /// </summary>
        /// <example>[subscriberId1, subscriberId2]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberIds")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? SubscriberIds { get; set; }

        /// <summary>
        /// List of subscriptions to subscribe to the topic (max: 100). Can be either a string array of subscriber IDs or an array of objects with identifier and subscriberId<br/>
        /// Example: [{"identifier":"subscriber-123-subscription-a","subscriberId":"subscriber-123"}, {"identifier":"subscriber-456-subscription-b","subscriberId":"subscriber-456"}]
        /// </summary>
        /// <example>[{"identifier":"subscriber-123-subscription-a","subscriberId":"subscriber-123"}, {"identifier":"subscriber-456-subscription-b","subscriberId":"subscriber-456"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
        public global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? Subscriptions { get; set; }

        /// <summary>
        /// The name of the topic<br/>
        /// Example: My Topic
        /// </summary>
        /// <example>My Topic</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public object? Context { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTopicSubscriptionsRequestDto" /> class.
        /// </summary>
        /// <param name="subscriptions">
        /// List of subscriptions to subscribe to the topic (max: 100). Can be either a string array of subscriber IDs or an array of objects with identifier and subscriberId<br/>
        /// Example: [{"identifier":"subscriber-123-subscription-a","subscriberId":"subscriber-123"}, {"identifier":"subscriber-456-subscription-b","subscriberId":"subscriber-456"}]
        /// </param>
        /// <param name="name">
        /// The name of the topic<br/>
        /// Example: My Topic
        /// </param>
        /// <param name="context"></param>
        /// <param name="preferences">
        /// The preferences of the topic. Can be a simple workflow ID string, workflow preference object, or group filter object<br/>
        /// Example: [{"workflowId":"workflow-123","condition":{"===":[{"var":"tier"},"premium"]}}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTopicSubscriptionsRequestDto(
            global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.TopicSubscriberIdentifierDto>>? subscriptions,
            string? name,
            object? context,
            global::System.Collections.Generic.IList<global::Novu.OneOf<string, global::Novu.WorkflowPreferenceRequestDto, global::Novu.GroupPreferenceFilterDto>>? preferences)
        {
            this.Subscriptions = subscriptions;
            this.Name = name;
            this.Context = context;
            this.Preferences = preferences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTopicSubscriptionsRequestDto" /> class.
        /// </summary>
        public CreateTopicSubscriptionsRequestDto()
        {
        }
    }
}