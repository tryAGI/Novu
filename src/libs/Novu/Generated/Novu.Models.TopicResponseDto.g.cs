
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicResponseDto
    {
        /// <summary>
        /// The identifier of the topic<br/>
        /// Example: 64da692e9a94fb2e6449ad06
        /// </summary>
        /// <example>64da692e9a94fb2e6449ad06</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The unique key of the topic<br/>
        /// Example: product-updates
        /// </summary>
        /// <example>product-updates</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The name of the topic<br/>
        /// Example: Product Updates
        /// </summary>
        /// <example>Product Updates</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The date the topic was created<br/>
        /// Example: 2023-08-15T00:00:00.000Z
        /// </summary>
        /// <example>2023-08-15T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// The date the topic was last updated<br/>
        /// Example: 2023-08-15T00:00:00.000Z
        /// </summary>
        /// <example>2023-08-15T00:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier of the topic<br/>
        /// Example: 64da692e9a94fb2e6449ad06
        /// </param>
        /// <param name="key">
        /// The unique key of the topic<br/>
        /// Example: product-updates
        /// </param>
        /// <param name="name">
        /// The name of the topic<br/>
        /// Example: Product Updates
        /// </param>
        /// <param name="createdAt">
        /// The date the topic was created<br/>
        /// Example: 2023-08-15T00:00:00.000Z
        /// </param>
        /// <param name="updatedAt">
        /// The date the topic was last updated<br/>
        /// Example: 2023-08-15T00:00:00.000Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicResponseDto(
            string id,
            string key,
            string? name,
            string? createdAt,
            string? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicResponseDto" /> class.
        /// </summary>
        public TopicResponseDto()
        {
        }
    }
}