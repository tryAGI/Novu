
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTopicRequestDto(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTopicRequestDto" /> class.
        /// </summary>
        public UpdateTopicRequestDto()
        {
        }
    }
}