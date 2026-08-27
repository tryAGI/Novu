
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateUpdateTopicRequestDto
    {
        /// <summary>
        /// The unique key identifier for the topic. The key must contain only alphanumeric characters (a-z, A-Z, 0-9), hyphens (-), underscores (_), colons (:), or be a valid email address.<br/>
        /// Example: task:12345
        /// </summary>
        /// <example>task:12345</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The display name for the topic<br/>
        /// Example: Task Title
        /// </summary>
        /// <example>Task Title</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional custom data associated with the topic. Flat key-value pairs of scalars (string, number, boolean, string[]). Maximum size: 64KB.<br/>
        /// Example: {"category":"product","priority":1}
        /// </summary>
        /// <example>{"category":"product","priority":1}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdateTopicRequestDto" /> class.
        /// </summary>
        /// <param name="key">
        /// The unique key identifier for the topic. The key must contain only alphanumeric characters (a-z, A-Z, 0-9), hyphens (-), underscores (_), colons (:), or be a valid email address.<br/>
        /// Example: task:12345
        /// </param>
        /// <param name="name">
        /// The display name for the topic<br/>
        /// Example: Task Title
        /// </param>
        /// <param name="data">
        /// Additional custom data associated with the topic. Flat key-value pairs of scalars (string, number, boolean, string[]). Maximum size: 64KB.<br/>
        /// Example: {"category":"product","priority":1}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateUpdateTopicRequestDto(
            string key,
            string? name,
            object? data)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateUpdateTopicRequestDto" /> class.
        /// </summary>
        public CreateUpdateTopicRequestDto()
        {
        }

    }
}