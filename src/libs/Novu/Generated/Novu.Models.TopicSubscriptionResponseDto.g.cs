
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSubscriptionResponseDto
    {
        /// <summary>
        /// The identifier of the subscription<br/>
        /// Example: 64da692e9a94fb2e6449ad08
        /// </summary>
        /// <example>64da692e9a94fb2e6449ad08</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The identifier of the subscription<br/>
        /// Example: tk=product-updates:si=subscriber-123
        /// </summary>
        /// <example>tk=product-updates:si=subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// The date and time the subscription was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2021-01-01T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Topic information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.TopicResponseDto Topic { get; set; }

        /// <summary>
        /// Subscriber information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SubscriberDto Subscriber { get; set; }

        /// <summary>
        /// Context keys that scope this subscription (e.g., tenant:org-a, project:proj-123)<br/>
        /// Example: [tenant:org-a, project:proj-123]
        /// </summary>
        /// <example>[tenant:org-a, project:proj-123]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        public global::System.Collections.Generic.IList<string>? ContextKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriptionResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the subscription<br/>
        /// Example: 64da692e9a94fb2e6449ad08
        /// </param>
        /// <param name="identifier">
        /// The identifier of the subscription<br/>
        /// Example: tk=product-updates:si=subscriber-123
        /// </param>
        /// <param name="createdAt">
        /// The date and time the subscription was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </param>
        /// <param name="topic">
        /// Topic information
        /// </param>
        /// <param name="subscriber">
        /// Subscriber information
        /// </param>
        /// <param name="contextKeys">
        /// Context keys that scope this subscription (e.g., tenant:org-a, project:proj-123)<br/>
        /// Example: [tenant:org-a, project:proj-123]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicSubscriptionResponseDto(
            string id,
            string identifier,
            string createdAt,
            global::Novu.TopicResponseDto topic,
            global::Novu.SubscriberDto subscriber,
            global::System.Collections.Generic.IList<string>? contextKeys)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Topic = topic ?? throw new global::System.ArgumentNullException(nameof(topic));
            this.Subscriber = subscriber ?? throw new global::System.ArgumentNullException(nameof(subscriber));
            this.ContextKeys = contextKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriptionResponseDto" /> class.
        /// </summary>
        public TopicSubscriptionResponseDto()
        {
        }
    }
}