
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("draft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Draft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preferenceSettings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SubscriberPreferenceChannels PreferenceSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("critical")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Critical { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.NotificationStepDto> Steps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_creatorId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.NotificationTrigger> Triggers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_notificationGroupId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NotificationGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletedBy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeletedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notificationGroup")]
        public global::Novu.NotificationGroup? NotificationGroup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowIntegrationStatus")]
        public object? WorkflowIntegrationStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        /// <param name="draft"></param>
        /// <param name="preferenceSettings"></param>
        /// <param name="critical"></param>
        /// <param name="tags"></param>
        /// <param name="steps"></param>
        /// <param name="organizationId"></param>
        /// <param name="creatorId"></param>
        /// <param name="environmentId"></param>
        /// <param name="triggers"></param>
        /// <param name="notificationGroupId"></param>
        /// <param name="deleted"></param>
        /// <param name="deletedAt"></param>
        /// <param name="deletedBy"></param>
        /// <param name="id"></param>
        /// <param name="parentId"></param>
        /// <param name="notificationGroup"></param>
        /// <param name="data"></param>
        /// <param name="workflowIntegrationStatus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowResponse(
            string name,
            string description,
            bool active,
            bool draft,
            global::Novu.SubscriberPreferenceChannels preferenceSettings,
            bool critical,
            global::System.Collections.Generic.IList<string> tags,
            global::System.Collections.Generic.IList<global::Novu.NotificationStepDto> steps,
            string organizationId,
            string creatorId,
            string environmentId,
            global::System.Collections.Generic.IList<global::Novu.NotificationTrigger> triggers,
            string notificationGroupId,
            bool deleted,
            string deletedAt,
            string deletedBy,
            string? id,
            string? parentId,
            global::Novu.NotificationGroup? notificationGroup,
            object? data,
            object? workflowIntegrationStatus)
        {
            this.Id = id;
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
            this.DeletedAt = deletedAt ?? throw new global::System.ArgumentNullException(nameof(deletedAt));
            this.DeletedBy = deletedBy ?? throw new global::System.ArgumentNullException(nameof(deletedBy));
            this.NotificationGroup = notificationGroup;
            this.Data = data;
            this.WorkflowIntegrationStatus = workflowIntegrationStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowResponse" /> class.
        /// </summary>
        public WorkflowResponse()
        {
        }
    }
}