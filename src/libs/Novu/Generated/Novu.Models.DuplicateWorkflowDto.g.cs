
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DuplicateWorkflowDto
    {
        /// <summary>
        /// Name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Custom workflow identifier for the duplicated workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Tags associated with the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Description of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Enable or disable translations for this workflow<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTranslationEnabled")]
        public bool? IsTranslationEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateWorkflowDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="workflowId">
        /// Custom workflow identifier for the duplicated workflow
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow
        /// </param>
        /// <param name="description">
        /// Description of the workflow
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this workflow<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DuplicateWorkflowDto(
            string? name,
            string? workflowId,
            global::System.Collections.Generic.IList<string>? tags,
            string? description,
            bool? isTranslationEnabled)
        {
            this.Name = name;
            this.WorkflowId = workflowId;
            this.Tags = tags;
            this.Description = description;
            this.IsTranslationEnabled = isTranslationEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateWorkflowDto" /> class.
        /// </summary>
        public DuplicateWorkflowDto()
        {
        }
    }
}