
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateWorkflowDto
    {
        /// <summary>
        /// Name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Tags associated with the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Whether the workflow is active<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Enable or disable payload schema validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatePayload")]
        public bool? ValidatePayload { get; set; }

        /// <summary>
        /// The payload JSON Schema for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadSchema")]
        public object? PayloadSchema { get; set; }

        /// <summary>
        /// Enable or disable translations for this workflow<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTranslationEnabled")]
        public bool? IsTranslationEnabled { get; set; }

        /// <summary>
        /// Workflow ID (allowed only for code-first workflows)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        public string? WorkflowId { get; set; }

        /// <summary>
        /// Steps of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.StepsItem3> Steps { get; set; }

        /// <summary>
        /// Workflow preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PreferencesRequestDto Preferences { get; set; }

        /// <summary>
        /// Origin of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceOriginEnum Origin { get; set; }

        /// <summary>
        /// Severity of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter))]
        public global::Novu.SeverityLevelEnum? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkflowDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="steps">
        /// Steps of the workflow
        /// </param>
        /// <param name="preferences">
        /// Workflow preferences
        /// </param>
        /// <param name="origin">
        /// Origin of the layout
        /// </param>
        /// <param name="description">
        /// Description of the workflow
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow
        /// </param>
        /// <param name="active">
        /// Whether the workflow is active<br/>
        /// Default Value: false
        /// </param>
        /// <param name="validatePayload">
        /// Enable or disable payload schema validation
        /// </param>
        /// <param name="payloadSchema">
        /// The payload JSON Schema for the workflow
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this workflow<br/>
        /// Default Value: false
        /// </param>
        /// <param name="workflowId">
        /// Workflow ID (allowed only for code-first workflows)
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateWorkflowDto(
            string name,
            global::System.Collections.Generic.IList<global::Novu.StepsItem3> steps,
            global::Novu.PreferencesRequestDto preferences,
            global::Novu.ResourceOriginEnum origin,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            bool? active,
            bool? validatePayload,
            object? payloadSchema,
            bool? isTranslationEnabled,
            string? workflowId,
            global::Novu.SeverityLevelEnum? severity)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Tags = tags;
            this.Active = active;
            this.ValidatePayload = validatePayload;
            this.PayloadSchema = payloadSchema;
            this.IsTranslationEnabled = isTranslationEnabled;
            this.WorkflowId = workflowId;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.Preferences = preferences ?? throw new global::System.ArgumentNullException(nameof(preferences));
            this.Origin = origin;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWorkflowDto" /> class.
        /// </summary>
        public UpdateWorkflowDto()
        {
        }
    }
}