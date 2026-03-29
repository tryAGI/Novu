
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicSubscriberIdentifierDto
    {
        /// <summary>
        /// Unique identifier for this subscription<br/>
        /// Example: subscriber-123-subscription-a
        /// </summary>
        /// <example>subscriber-123-subscription-a</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// The subscriber ID<br/>
        /// Example: subscriber-123
        /// </summary>
        /// <example>subscriber-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubscriberId { get; set; }

        /// <summary>
        /// The name of the subscription<br/>
        /// Example: My Subscription
        /// </summary>
        /// <example>My Subscription</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriberIdentifierDto" /> class.
        /// </summary>
        /// <param name="identifier">
        /// Unique identifier for this subscription<br/>
        /// Example: subscriber-123-subscription-a
        /// </param>
        /// <param name="subscriberId">
        /// The subscriber ID<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="name">
        /// The name of the subscription<br/>
        /// Example: My Subscription
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicSubscriberIdentifierDto(
            string identifier,
            string subscriberId,
            string? name)
        {
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.SubscriberId = subscriberId ?? throw new global::System.ArgumentNullException(nameof(subscriberId));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicSubscriberIdentifierDto" /> class.
        /// </summary>
        public TopicSubscriberIdentifierDto()
        {
        }
    }
}