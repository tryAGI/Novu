
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowResponseDto
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
        /// Database identifier of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Workflow identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Slug of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// User who last updated the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public global::Novu.UserResponseDto? UpdatedBy { get; set; }

        /// <summary>
        /// Timestamp of the last workflow publication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastPublishedAt")]
        public string? LastPublishedAt { get; set; }

        /// <summary>
        /// User who last published the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastPublishedBy")]
        public global::Novu.UserResponseDto? LastPublishedBy { get; set; }

        /// <summary>
        /// Steps of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.StepsItem> Steps { get; set; }

        /// <summary>
        /// Origin of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceOriginEnum Origin { get; set; }

        /// <summary>
        /// Preferences for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferences")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowPreferencesResponseDto Preferences { get; set; }

        /// <summary>
        /// Status of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowStatusEnum Status { get; set; }

        /// <summary>
        /// Runtime issues for workflow creation and update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::System.Collections.Generic.Dictionary<string, global::Novu.RuntimeIssueDto>? Issues { get; set; }

        /// <summary>
        /// Timestamp of the last workflow trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastTriggeredAt")]
        public string? LastTriggeredAt { get; set; }

        /// <summary>
        /// Generated payload example based on the payload schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadExample")]
        public object? PayloadExample { get; set; }

        /// <summary>
        /// Severity of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SeverityLevelEnum Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResponseDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="id">
        /// Database identifier of the workflow
        /// </param>
        /// <param name="workflowId">
        /// Workflow identifier
        /// </param>
        /// <param name="slug">
        /// Slug of the workflow
        /// </param>
        /// <param name="updatedAt">
        /// Last updated timestamp
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="steps">
        /// Steps of the workflow
        /// </param>
        /// <param name="origin">
        /// Origin of the layout
        /// </param>
        /// <param name="preferences">
        /// Preferences for the workflow
        /// </param>
        /// <param name="status">
        /// Status of the workflow
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
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
        /// <param name="updatedBy">
        /// User who last updated the workflow
        /// </param>
        /// <param name="lastPublishedAt">
        /// Timestamp of the last workflow publication
        /// </param>
        /// <param name="lastPublishedBy">
        /// User who last published the workflow
        /// </param>
        /// <param name="issues">
        /// Runtime issues for workflow creation and update
        /// </param>
        /// <param name="lastTriggeredAt">
        /// Timestamp of the last workflow trigger
        /// </param>
        /// <param name="payloadExample">
        /// Generated payload example based on the payload schema
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowResponseDto(
            string name,
            string id,
            string workflowId,
            string slug,
            string updatedAt,
            string createdAt,
            global::System.Collections.Generic.IList<global::Novu.StepsItem> steps,
            global::Novu.ResourceOriginEnum origin,
            global::Novu.WorkflowPreferencesResponseDto preferences,
            global::Novu.WorkflowStatusEnum status,
            global::Novu.SeverityLevelEnum severity,
            string? description,
            global::System.Collections.Generic.IList<string>? tags,
            bool? active,
            bool? validatePayload,
            object? payloadSchema,
            bool? isTranslationEnabled,
            global::Novu.UserResponseDto? updatedBy,
            string? lastPublishedAt,
            global::Novu.UserResponseDto? lastPublishedBy,
            global::System.Collections.Generic.Dictionary<string, global::Novu.RuntimeIssueDto>? issues,
            string? lastTriggeredAt,
            object? payloadExample)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Tags = tags;
            this.Active = active;
            this.ValidatePayload = validatePayload;
            this.PayloadSchema = payloadSchema;
            this.IsTranslationEnabled = isTranslationEnabled;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedBy = updatedBy;
            this.LastPublishedAt = lastPublishedAt;
            this.LastPublishedBy = lastPublishedBy;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.Origin = origin;
            this.Preferences = preferences ?? throw new global::System.ArgumentNullException(nameof(preferences));
            this.Status = status;
            this.Issues = issues;
            this.LastTriggeredAt = lastTriggeredAt;
            this.PayloadExample = payloadExample;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResponseDto" /> class.
        /// </summary>
        public WorkflowResponseDto()
        {
        }
    }
}