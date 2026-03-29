
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceResponseDto
    {
        /// <summary>
        /// Trace identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Event type (e.g., request_received, workflow_execution_started)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eventType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventType { get; set; }

        /// <summary>
        /// Human readable title/message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Detailed message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public object? Message { get; set; }

        /// <summary>
        /// Raw data associated with trace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawData")]
        public object? RawData { get; set; }

        /// <summary>
        /// Trace status (success, error, warning, pending)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Entity type (request, workflow_run, step_run)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityType { get; set; }

        /// <summary>
        /// Entity identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// Organization identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Environment identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// User identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public object? UserId { get; set; }

        /// <summary>
        /// External subscriber identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalSubscriberId")]
        public object? ExternalSubscriberId { get; set; }

        /// <summary>
        /// Subscriber identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        public object? SubscriberId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Trace identifier
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="eventType">
        /// Event type (e.g., request_received, workflow_execution_started)
        /// </param>
        /// <param name="title">
        /// Human readable title/message
        /// </param>
        /// <param name="status">
        /// Trace status (success, error, warning, pending)
        /// </param>
        /// <param name="entityType">
        /// Entity type (request, workflow_run, step_run)
        /// </param>
        /// <param name="entityId">
        /// Entity identifier
        /// </param>
        /// <param name="organizationId">
        /// Organization identifier
        /// </param>
        /// <param name="environmentId">
        /// Environment identifier
        /// </param>
        /// <param name="message">
        /// Detailed message
        /// </param>
        /// <param name="rawData">
        /// Raw data associated with trace
        /// </param>
        /// <param name="userId">
        /// User identifier
        /// </param>
        /// <param name="externalSubscriberId">
        /// External subscriber identifier
        /// </param>
        /// <param name="subscriberId">
        /// Subscriber identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceResponseDto(
            string id,
            string createdAt,
            string eventType,
            string title,
            string status,
            string entityType,
            string entityId,
            string organizationId,
            string environmentId,
            object? message,
            object? rawData,
            object? userId,
            object? externalSubscriberId,
            object? subscriberId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Message = message;
            this.RawData = rawData;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.UserId = userId;
            this.ExternalSubscriberId = externalSubscriberId;
            this.SubscriberId = subscriberId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceResponseDto" /> class.
        /// </summary>
        public TraceResponseDto()
        {
        }
    }
}