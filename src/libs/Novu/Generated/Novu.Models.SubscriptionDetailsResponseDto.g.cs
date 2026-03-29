
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionDetailsResponseDto
    {
        /// <summary>
        /// The unique identifier of the subscription<br/>
        /// Example: 64f5e95d3d7946d80d0cb679
        /// </summary>
        /// <example>64f5e95d3d7946d80d0cb679</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The identifier of the subscription<br/>
        /// Example: subscription-identifier
        /// </summary>
        /// <example>subscription-identifier</example>
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
        /// The preferences/rules for the subscription
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDetailsResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the subscription<br/>
        /// Example: 64f5e95d3d7946d80d0cb679
        /// </param>
        /// <param name="identifier">
        /// The identifier of the subscription<br/>
        /// Example: subscription-identifier
        /// </param>
        /// <param name="name">
        /// The name of the subscription<br/>
        /// Example: My Subscription
        /// </param>
        /// <param name="preferences">
        /// The preferences/rules for the subscription
        /// </param>
        /// <param name="contextKeys">
        /// Context keys that scope this subscription (e.g., tenant:org-a, project:proj-123)<br/>
        /// Example: [tenant:org-a, project:proj-123]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionDetailsResponseDto(
            string id,
            string? identifier,
            string? name,
            global::System.Collections.Generic.IList<global::Novu.SubscriptionPreferenceDto>? preferences,
            global::System.Collections.Generic.IList<string>? contextKeys)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Identifier = identifier;
            this.Name = name;
            this.Preferences = preferences;
            this.ContextKeys = contextKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDetailsResponseDto" /> class.
        /// </summary>
        public SubscriptionDetailsResponseDto()
        {
        }
    }
}