
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TopicDto
    {
        /// <summary>
        /// The internal unique identifier of the topic<br/>
        /// Example: 64f5e95d3d7946d80d0cb677
        /// </summary>
        /// <example>64f5e95d3d7946d80d0cb677</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The key identifier of the topic used in your application. Should be unique on the environment level.<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDto" /> class.
        /// </summary>
        /// <param name="id">
        /// The internal unique identifier of the topic<br/>
        /// Example: 64f5e95d3d7946d80d0cb677
        /// </param>
        /// <param name="key">
        /// The key identifier of the topic used in your application. Should be unique on the environment level.<br/>
        /// Example: product-updates
        /// </param>
        /// <param name="name">
        /// The name of the topic<br/>
        /// Example: Product Updates
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TopicDto(
            string id,
            string key,
            string? name)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TopicDto" /> class.
        /// </summary>
        public TopicDto()
        {
        }
    }
}