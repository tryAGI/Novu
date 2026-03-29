
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSubscriberDto
    {
        /// <summary>
        /// Unique identifier for the organization<br/>
        /// Example: org_123456789
        /// </summary>
        /// <example>org_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Unique identifier for the environment<br/>
        /// Example: env_123456789
        /// </summary>
        /// <example>env_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// Unique identifier for the subscriber<br/>
        /// Example: sub_123456789
        /// </summary>
        /// <example>sub_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// Unique identifier for the topic<br/>
        /// Example: topic_123456789
        /// </summary>
        /// <example>topic_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_topicId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TopicId { get; set; }

        /// <summary>
        /// Key associated with the topic<br/>
        /// Example: my_topic_key
        /// </summary>
        /// <example>my_topic_key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("topicKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TopicKey { get; set; }

        /// <summary>
        /// External identifier for the subscriber<br/>
        /// Example: external_subscriber_123
        /// </summary>
        /// <example>external_subscriber_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalSubscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalSubscriberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriberDto" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// Unique identifier for the organization<br/>
        /// Example: org_123456789
        /// </param>
        /// <param name="environmentId">
        /// Unique identifier for the environment<br/>
        /// Example: env_123456789
        /// </param>
        /// <param name="subscriberId">
        /// Unique identifier for the subscriber<br/>
        /// Example: sub_123456789
        /// </param>
        /// <param name="topicId">
        /// Unique identifier for the topic<br/>
        /// Example: topic_123456789
        /// </param>
        /// <param name="topicKey">
        /// Key associated with the topic<br/>
        /// Example: my_topic_key
        /// </param>
        /// <param name="externalSubscriberId">
        /// External identifier for the subscriber<br/>
        /// Example: external_subscriber_123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicSubscriberDto(
            string organizationId,
            string environmentId,
            string subscriberId,
            string topicId,
            string topicKey,
            string externalSubscriberId)
        {
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.TopicId = topicId ?? throw new global::System.ArgumentNullException(nameof(topicId));
            this.TopicKey = topicKey ?? throw new global::System.ArgumentNullException(nameof(topicKey));
            this.ExternalSubscriberId = externalSubscriberId ?? throw new global::System.ArgumentNullException(nameof(externalSubscriberId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriberDto" /> class.
        /// </summary>
        public TopicSubscriberDto()
        {
        }
    }
}