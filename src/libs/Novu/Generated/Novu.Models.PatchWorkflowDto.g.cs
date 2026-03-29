
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchWorkflowDto
    {
        /// <summary>
        /// Activate or deactivate the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// New name for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Updated description of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Tags associated with the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The payload JSON Schema for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadSchema")]
        public object? PayloadSchema { get; set; }

        /// <summary>
        /// Enable or disable payload schema validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatePayload")]
        public bool? ValidatePayload { get; set; }

        /// <summary>
        /// Enable or disable translations for this workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTranslationEnabled")]
        public bool? IsTranslationEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWorkflowDto" /> class.
        /// </summary>
        /// <param name="active">
        /// Activate or deactivate the workflow
        /// </param>
        /// <param name="name">
        /// New name for the workflow
        /// </param>
        /// <param name="description">
        /// Updated description of the workflow
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow
        /// </param>
        /// <param name="payloadSchema">
        /// The payload JSON Schema for the workflow
        /// </param>
        /// <param name="validatePayload">
        /// Enable or disable payload schema validation
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWorkflowDto(
            bool? active,
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            object? payloadSchema,
            bool? validatePayload,
            bool? isTranslationEnabled)
        {
            this.Active = active;
            this.Name = name;
            this.Description = description;
            this.Tags = tags;
            this.PayloadSchema = payloadSchema;
            this.ValidatePayload = validatePayload;
            this.IsTranslationEnabled = isTranslationEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWorkflowDto" /> class.
        /// </summary>
        public PatchWorkflowDto()
        {
        }
    }
}