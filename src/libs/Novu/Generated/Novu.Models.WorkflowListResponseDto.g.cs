
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowListResponseDto
    {
        /// <summary>
        /// Name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tags associated with the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

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
        /// Unique database identifier
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
        /// Workflow slug
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Status of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowStatusEnum Status { get; set; }

        /// <summary>
        /// Origin of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceOriginEnum Origin { get; set; }

        /// <summary>
        /// Timestamp of the last workflow trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastTriggeredAt")]
        public string? LastTriggeredAt { get; set; }

        /// <summary>
        /// Overview of step types in the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepTypeOverviews")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.StepTypeEnum> StepTypeOverviews { get; set; }

        /// <summary>
        /// Is translation enabled for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTranslationEnabled")]
        public bool? IsTranslationEnabled { get; set; }

        /// <summary>
        /// Steps of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.StepListResponseDto> Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowListResponseDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="updatedAt">
        /// Last updated timestamp
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="id">
        /// Unique database identifier
        /// </param>
        /// <param name="workflowId">
        /// Workflow identifier
        /// </param>
        /// <param name="slug">
        /// Workflow slug
        /// </param>
        /// <param name="status">
        /// Status of the workflow
        /// </param>
        /// <param name="origin">
        /// Origin of the layout
        /// </param>
        /// <param name="stepTypeOverviews">
        /// Overview of step types in the workflow
        /// </param>
        /// <param name="steps">
        /// Steps of the workflow
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow
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
        /// <param name="lastTriggeredAt">
        /// Timestamp of the last workflow trigger
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Is translation enabled for the workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowListResponseDto(
            string name,
            string updatedAt,
            string createdAt,
            string id,
            string workflowId,
            string slug,
            global::Novu.WorkflowStatusEnum status,
            global::Novu.ResourceOriginEnum origin,
            global::System.Collections.Generic.IList<global::Novu.StepTypeEnum> stepTypeOverviews,
            global::System.Collections.Generic.IList<global::Novu.StepListResponseDto> steps,
            global::System.Collections.Generic.IList<string>? tags,
            global::Novu.UserResponseDto? updatedBy,
            string? lastPublishedAt,
            global::Novu.UserResponseDto? lastPublishedBy,
            string? lastTriggeredAt,
            bool? isTranslationEnabled)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Tags = tags;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedBy = updatedBy;
            this.LastPublishedAt = lastPublishedAt;
            this.LastPublishedBy = lastPublishedBy;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Status = status;
            this.Origin = origin;
            this.LastTriggeredAt = lastTriggeredAt;
            this.StepTypeOverviews = stepTypeOverviews ?? throw new global::System.ArgumentNullException(nameof(stepTypeOverviews));
            this.IsTranslationEnabled = isTranslationEnabled;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowListResponseDto" /> class.
        /// </summary>
        public WorkflowListResponseDto()
        {
        }
    }
}