
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PersistedWorkflowWebhookDto
    {
        /// <summary>
        /// Database identifier of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Whether the workflow is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Whether the workflow is a draft
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferenceSettings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.PreferenceChannelsDto PreferenceSettings { get; set; }

        /// <summary>
        /// Whether the workflow ignores subscriber preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("critical")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Critical { get; set; }

        /// <summary>
        /// Tags assigned to the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Persisted workflow steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.PersistedWorkflowStepWebhookDto> Steps { get; set; }

        /// <summary>
        /// Organization identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object OrganizationId { get; set; }

        /// <summary>
        /// User who created the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_creatorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorId { get; set; }

        /// <summary>
        /// Environment identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object EnvironmentId { get; set; }

        /// <summary>
        /// Workflow triggers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerDto> Triggers { get; set; }

        /// <summary>
        /// Notification group identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_notificationGroupId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationGroupId { get; set; }

        /// <summary>
        /// Parent workflow identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Deletion state captured before workflow.deleted is processed. The deleted event normally carries `false` here.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Soft-delete timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        public string? DeletedAt { get; set; }

        /// <summary>
        /// User who deleted the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedBy")]
        public string? DeletedBy { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Last updated timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// User who last updated the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_updatedBy")]
        public string? UpdatedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedBy")]
        public global::Novu.UserResponseDto? UpdatedBy2 { get; set; }

        /// <summary>
        /// Whether the workflow is a blueprint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isBlueprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBlueprint { get; set; }

        /// <summary>
        /// Blueprint identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blueprintId")]
        public string? BlueprintId { get; set; }

        /// <summary>
        /// Custom workflow data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Resource type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter))]
        public global::Novu.ResourceTypeEnum? Type { get; set; }

        /// <summary>
        /// Workflow origin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter))]
        public global::Novu.ResourceOriginEnum? Origin { get; set; }

        /// <summary>
        /// Raw workflow data retained for legacy workflows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawData")]
        public object? RawData { get; set; }

        /// <summary>
        /// Payload JSON Schema for the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadSchema")]
        public object? PayloadSchema { get; set; }

        /// <summary>
        /// Whether payload schema validation is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validatePayload")]
        public bool? ValidatePayload { get; set; }

        /// <summary>
        /// Whether translations are enabled for this workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTranslationEnabled")]
        public bool? IsTranslationEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Novu.WorkflowAgentConfigDto? Agent { get; set; }

        /// <summary>
        /// Runtime issues recorded on the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.RuntimeIssueDto>> Issues { get; set; }

        /// <summary>
        /// Workflow status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.WorkflowStatusEnumJsonConverter))]
        public global::Novu.WorkflowStatusEnum? Status { get; set; }

        /// <summary>
        /// Timestamp of the last workflow trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastTriggeredAt")]
        public string? LastTriggeredAt { get; set; }

        /// <summary>
        /// Timestamp of the last workflow publication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastPublishedAt")]
        public string? LastPublishedAt { get; set; }

        /// <summary>
        /// User who last published the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_lastPublishedBy")]
        public string? LastPublishedBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastPublishedBy")]
        public global::Novu.UserResponseDto? LastPublishedBy2 { get; set; }

        /// <summary>
        /// User-specific preferences included by workflow patch events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userPreferences")]
        public global::Novu.WorkflowPreferencesDto? UserPreferences { get; set; }

        /// <summary>
        /// Default preferences included by workflow patch events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("defaultPreferences")]
        public global::Novu.WorkflowPreferencesDto? DefaultPreferences { get; set; }

        /// <summary>
        /// Workflow severity
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
        /// Initializes a new instance of the <see cref="PersistedWorkflowWebhookDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Database identifier of the workflow
        /// </param>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="description">
        /// Description of the workflow
        /// </param>
        /// <param name="active">
        /// Whether the workflow is active
        /// </param>
        /// <param name="draft">
        /// Whether the workflow is a draft
        /// </param>
        /// <param name="preferenceSettings"></param>
        /// <param name="critical">
        /// Whether the workflow ignores subscriber preferences
        /// </param>
        /// <param name="tags">
        /// Tags assigned to the workflow
        /// </param>
        /// <param name="steps">
        /// Persisted workflow steps
        /// </param>
        /// <param name="organizationId">
        /// Organization identifier
        /// </param>
        /// <param name="creatorId">
        /// User who created the workflow
        /// </param>
        /// <param name="environmentId">
        /// Environment identifier
        /// </param>
        /// <param name="triggers">
        /// Workflow triggers
        /// </param>
        /// <param name="notificationGroupId">
        /// Notification group identifier
        /// </param>
        /// <param name="deleted">
        /// Deletion state captured before workflow.deleted is processed. The deleted event normally carries `false` here.
        /// </param>
        /// <param name="isBlueprint">
        /// Whether the workflow is a blueprint
        /// </param>
        /// <param name="issues">
        /// Runtime issues recorded on the workflow
        /// </param>
        /// <param name="parentId">
        /// Parent workflow identifier
        /// </param>
        /// <param name="deletedAt">
        /// Soft-delete timestamp
        /// </param>
        /// <param name="deletedBy">
        /// User who deleted the workflow
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="updatedAt">
        /// Last updated timestamp
        /// </param>
        /// <param name="updatedBy">
        /// User who last updated the workflow
        /// </param>
        /// <param name="updatedBy2"></param>
        /// <param name="blueprintId">
        /// Blueprint identifier
        /// </param>
        /// <param name="data">
        /// Custom workflow data
        /// </param>
        /// <param name="type">
        /// Resource type
        /// </param>
        /// <param name="origin">
        /// Workflow origin
        /// </param>
        /// <param name="rawData">
        /// Raw workflow data retained for legacy workflows
        /// </param>
        /// <param name="payloadSchema">
        /// Payload JSON Schema for the workflow
        /// </param>
        /// <param name="validatePayload">
        /// Whether payload schema validation is enabled
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Whether translations are enabled for this workflow
        /// </param>
        /// <param name="agent"></param>
        /// <param name="status">
        /// Workflow status
        /// </param>
        /// <param name="lastTriggeredAt">
        /// Timestamp of the last workflow trigger
        /// </param>
        /// <param name="lastPublishedAt">
        /// Timestamp of the last workflow publication
        /// </param>
        /// <param name="lastPublishedBy">
        /// User who last published the workflow
        /// </param>
        /// <param name="lastPublishedBy2"></param>
        /// <param name="userPreferences">
        /// User-specific preferences included by workflow patch events
        /// </param>
        /// <param name="defaultPreferences">
        /// Default preferences included by workflow patch events
        /// </param>
        /// <param name="severity">
        /// Workflow severity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedWorkflowWebhookDto(
            string id,
            string name,
            string description,
            bool active,
            bool draft,
            global::Novu.PreferenceChannelsDto preferenceSettings,
            bool critical,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Collections.Generic.IList<global::Novu.PersistedWorkflowStepWebhookDto> steps,
            object organizationId,
            string creatorId,
            object environmentId,
            global::System.Collections.Generic.IList<global::Novu.WorkflowWebhookTriggerDto> triggers,
            string notificationGroupId,
            bool deleted,
            bool isBlueprint,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Novu.RuntimeIssueDto>> issues,
            string? parentId,
            string? deletedAt,
            string? deletedBy,
            string? createdAt,
            string? updatedAt,
            string? updatedBy,
            global::Novu.UserResponseDto? updatedBy2,
            string? blueprintId,
            object? data,
            global::Novu.ResourceTypeEnum? type,
            global::Novu.ResourceOriginEnum? origin,
            object? rawData,
            object? payloadSchema,
            bool? validatePayload,
            bool? isTranslationEnabled,
            global::Novu.WorkflowAgentConfigDto? agent,
            global::Novu.WorkflowStatusEnum? status,
            string? lastTriggeredAt,
            string? lastPublishedAt,
            string? lastPublishedBy,
            global::Novu.UserResponseDto? lastPublishedBy2,
            global::Novu.WorkflowPreferencesDto? userPreferences,
            global::Novu.WorkflowPreferencesDto? defaultPreferences,
            global::Novu.SeverityLevelEnum? severity)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Active = active;
            this.Draft = draft;
            this.PreferenceSettings = preferenceSettings ?? throw new global::System.ArgumentNullException(nameof(preferenceSettings));
            this.Critical = critical;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.CreatorId = creatorId ?? throw new global::System.ArgumentNullException(nameof(creatorId));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.Triggers = triggers ?? throw new global::System.ArgumentNullException(nameof(triggers));
            this.NotificationGroupId = notificationGroupId ?? throw new global::System.ArgumentNullException(nameof(notificationGroupId));
            this.ParentId = parentId;
            this.Deleted = deleted;
            this.DeletedAt = deletedAt;
            this.DeletedBy = deletedBy;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.UpdatedBy2 = updatedBy2;
            this.IsBlueprint = isBlueprint;
            this.BlueprintId = blueprintId;
            this.Data = data;
            this.Type = type;
            this.Origin = origin;
            this.RawData = rawData;
            this.PayloadSchema = payloadSchema;
            this.ValidatePayload = validatePayload;
            this.IsTranslationEnabled = isTranslationEnabled;
            this.Agent = agent;
            this.Issues = issues ?? throw new global::System.ArgumentNullException(nameof(issues));
            this.Status = status;
            this.LastTriggeredAt = lastTriggeredAt;
            this.LastPublishedAt = lastPublishedAt;
            this.LastPublishedBy = lastPublishedBy;
            this.LastPublishedBy2 = lastPublishedBy2;
            this.UserPreferences = userPreferences;
            this.DefaultPreferences = defaultPreferences;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedWorkflowWebhookDto" /> class.
        /// </summary>
        public PersistedWorkflowWebhookDto()
        {
        }

    }
}