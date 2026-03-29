
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateWorkflowDto
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
        /// Unique identifier for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Steps of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.StepsItem2> Steps { get; set; }

        /// <summary>
        /// Source of workflow creation<br/>
        /// Default Value: editor
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("__source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.WorkflowCreationSourceEnumJsonConverter))]
        public global::Novu.WorkflowCreationSourceEnum? Source { get; set; }

        /// <summary>
        /// Workflow preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        public global::Novu.PreferencesRequestDto? Preferences { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateWorkflowDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="workflowId">
        /// Unique identifier for the workflow
        /// </param>
        /// <param name="steps">
        /// Steps of the workflow
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
        /// <param name="source">
        /// Source of workflow creation<br/>
        /// Default Value: editor
        /// </param>
        /// <param name="preferences">
        /// Workflow preferences
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateWorkflowDto(
            string name,
            string workflowId,
            global::System.Collections.Generic.IList<global::Novu.StepsItem2> steps,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            bool? active,
            bool? validatePayload,
            object? payloadSchema,
            bool? isTranslationEnabled,
            global::Novu.WorkflowCreationSourceEnum? source,
            global::Novu.PreferencesRequestDto? preferences,
            global::Novu.SeverityLevelEnum? severity)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Tags = tags;
            this.Active = active;
            this.ValidatePayload = validatePayload;
            this.PayloadSchema = payloadSchema;
            this.IsTranslationEnabled = isTranslationEnabled;
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.Source = source;
            this.Preferences = preferences;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWorkflowDto" /> class.
        /// </summary>
        public CreateWorkflowDto()
        {
        }
    }
}