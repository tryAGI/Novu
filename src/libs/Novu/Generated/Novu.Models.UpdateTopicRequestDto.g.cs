
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTopicRequestDto
    {
        /// <summary>
        /// The display name for the topic<br/>
        /// Example: Updated Topic Name
        /// </summary>
        /// <example>Updated Topic Name</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional custom data associated with the topic. Flat key-value pairs of scalars (string, number, boolean, string[]). Maximum size: 64KB. Pass null to clear.<br/>
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
        /// Initializes a new instance of the <see cref="UpdateTopicRequestDto" /> class.
        /// </summary>
        /// <param name="name">
        /// The display name for the topic<br/>
        /// Example: Updated Topic Name
        /// </param>
        /// <param name="data">
        /// Additional custom data associated with the topic. Flat key-value pairs of scalars (string, number, boolean, string[]). Maximum size: 64KB. Pass null to clear.<br/>
        /// Example: {"category":"product","priority":1}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTopicRequestDto(
            string? name,
            object? data)
        {
            this.Name = name;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTopicRequestDto" /> class.
        /// </summary>
        public UpdateTopicRequestDto()
        {
        }

    }
}