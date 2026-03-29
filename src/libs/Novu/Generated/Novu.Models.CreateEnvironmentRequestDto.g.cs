
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEnvironmentRequestDto
    {
        /// <summary>
        /// Name of the environment to be created<br/>
        /// Example: Production Environment
        /// </summary>
        /// <example>Production Environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// MongoDB ObjectId of the parent environment (optional)<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a1
        /// </summary>
        /// <example>60d5ecb8b3b3a30015f3e1a1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Hex color code for the environment<br/>
        /// Example: #3498db
        /// </summary>
        /// <example>#3498db</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequestDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment to be created<br/>
        /// Example: Production Environment
        /// </param>
        /// <param name="color">
        /// Hex color code for the environment<br/>
        /// Example: #3498db
        /// </param>
        /// <param name="parentId">
        /// MongoDB ObjectId of the parent environment (optional)<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEnvironmentRequestDto(
            string name,
            string color,
            string? parentId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentId = parentId;
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequestDto" /> class.
        /// </summary>
        public CreateEnvironmentRequestDto()
        {
        }
    }
}