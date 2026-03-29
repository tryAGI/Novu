
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionResponseDto
    {
        /// <summary>
        /// The unique identifier of the subscription<br/>
        /// Example: 64f5e95d3d7946d80d0cb679
        /// </summary>
        /// <example>64f5e95d3d7946d80d0cb679</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The identifier of the subscription<br/>
        /// Example: tk=product-updates:si=subscriber-123
        /// </summary>
        /// <example>tk=product-updates:si=subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// The name of the subscription<br/>
        /// Example: My Subscription
        /// </summary>
        /// <example>My Subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The topic information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TopicDto Topic { get; set; }

        /// <summary>
        /// The subscriber information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber")]
        public global::Novu.SubscriberDto? Subscriber { get; set; }

        /// <summary>
        /// The preferences for workflows in this subscription
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        public global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? Preferences { get; set; }

        /// <summary>
        /// Context keys that scope this subscription (e.g., tenant:org-a, project:proj-123)<br/>
        /// Example: [tenant:org-a, project:proj-123]
        /// </summary>
        /// <example>[tenant:org-a, project:proj-123]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        public global::System.Collections.Generic.IList<string>? ContextKeys { get; set; }

        /// <summary>
        /// The creation date of the subscription<br/>
        /// Example: 2025-04-24T05:40:21Z
        /// </summary>
        /// <example>2025-04-24T05:40:21Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The last update date of the subscription<br/>
        /// Example: 2025-04-24T05:40:21Z
        /// </summary>
        /// <example>2025-04-24T05:40:21Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the subscription<br/>
        /// Example: 64f5e95d3d7946d80d0cb679
        /// </param>
        /// <param name="topic">
        /// The topic information
        /// </param>
        /// <param name="createdAt">
        /// The creation date of the subscription<br/>
        /// Example: 2025-04-24T05:40:21Z
        /// </param>
        /// <param name="updatedAt">
        /// The last update date of the subscription<br/>
        /// Example: 2025-04-24T05:40:21Z
        /// </param>
        /// <param name="identifier">
        /// The identifier of the subscription<br/>
        /// Example: tk=product-updates:si=subscriber-123
        /// </param>
        /// <param name="name">
        /// The name of the subscription<br/>
        /// Example: My Subscription
        /// </param>
        /// <param name="subscriber">
        /// The subscriber information
        /// </param>
        /// <param name="preferences">
        /// The preferences for workflows in this subscription
        /// </param>
        /// <param name="contextKeys">
        /// Context keys that scope this subscription (e.g., tenant:org-a, project:proj-123)<br/>
        /// Example: [tenant:org-a, project:proj-123]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionResponseDto(
            string id,
            global::Novu.TopicDto topic,
            string createdAt,
            string updatedAt,
            string? identifier,
            string? name,
            global::Novu.SubscriberDto? subscriber,
            global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? preferences,
            global::System.Collections.Generic.IList<string>? contextKeys)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Identifier = identifier;
            this.Name = name;
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
            this.Subscriber = subscriber;
            this.Preferences = preferences;
            this.ContextKeys = contextKeys;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponseDto" /> class.
        /// </summary>
        public SubscriptionResponseDto()
        {
        }
    }
}