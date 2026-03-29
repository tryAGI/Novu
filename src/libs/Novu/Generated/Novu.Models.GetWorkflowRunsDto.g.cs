
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWorkflowRunsDto
    {
        /// <summary>
        /// Workflow run id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Workflow identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Workflow name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowName { get; set; }

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
        /// Internal subscriber identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internalSubscriberId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InternalSubscriberId { get; set; }

        /// <summary>
        /// External subscriber identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberId")]
        public string? SubscriberId { get; set; }

        /// <summary>
        /// Workflow run status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.GetWorkflowRunsDtoStatus Status { get; set; }

        /// <summary>
        /// Workflow run delivery lifecycle status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deliveryLifecycleStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoDeliveryLifecycleStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus DeliveryLifecycleStatus { get; set; }

        /// <summary>
        /// Trigger identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TriggerIdentifier { get; set; }

        /// <summary>
        /// Transaction identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransactionId { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Severity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.GetWorkflowRunsDtoSeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.GetWorkflowRunsDtoSeverity Severity { get; set; }

        /// <summary>
        /// Critical flag
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("critical")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Critical { get; set; }

        /// <summary>
        /// Context (single or multi) in which the workflow run was executed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contextKeys")]
        public global::System.Collections.Generic.IList<string>? ContextKeys { get; set; }

        /// <summary>
        /// Topics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topics")]
        public global::System.Collections.Generic.IList<global::Novu.TopicResponseDto>? Topics { get; set; }

        /// <summary>
        /// Workflow run steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.WorkflowRunStepsDetailsDto> Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowRunsDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Workflow run id
        /// </param>
        /// <param name="workflowId">
        /// Workflow identifier
        /// </param>
        /// <param name="workflowName">
        /// Workflow name
        /// </param>
        /// <param name="organizationId">
        /// Organization identifier
        /// </param>
        /// <param name="environmentId">
        /// Environment identifier
        /// </param>
        /// <param name="internalSubscriberId">
        /// Internal subscriber identifier
        /// </param>
        /// <param name="status">
        /// Workflow run status
        /// </param>
        /// <param name="deliveryLifecycleStatus">
        /// Workflow run delivery lifecycle status
        /// </param>
        /// <param name="triggerIdentifier">
        /// Trigger identifier
        /// </param>
        /// <param name="transactionId">
        /// Transaction identifier
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="updatedAt">
        /// Update timestamp
        /// </param>
        /// <param name="severity">
        /// Severity
        /// </param>
        /// <param name="critical">
        /// Critical flag
        /// </param>
        /// <param name="steps">
        /// Workflow run steps
        /// </param>
        /// <param name="subscriberId">
        /// External subscriber identifier
        /// </param>
        /// <param name="contextKeys">
        /// Context (single or multi) in which the workflow run was executed
        /// </param>
        /// <param name="topics">
        /// Topics
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWorkflowRunsDto(
            string id,
            string workflowId,
            string workflowName,
            string organizationId,
            string environmentId,
            string internalSubscriberId,
            global::Novu.GetWorkflowRunsDtoStatus status,
            global::Novu.GetWorkflowRunsDtoDeliveryLifecycleStatus deliveryLifecycleStatus,
            string triggerIdentifier,
            string transactionId,
            string createdAt,
            string updatedAt,
            global::Novu.GetWorkflowRunsDtoSeverity severity,
            bool critical,
            global::System.Collections.Generic.IList<global::Novu.WorkflowRunStepsDetailsDto> steps,
            string? subscriberId,
            global::System.Collections.Generic.IList<string>? contextKeys,
            global::System.Collections.Generic.IList<global::Novu.TopicResponseDto>? topics)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.WorkflowName = workflowName ?? throw new global::System.ArgumentNullException(nameof(workflowName));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.InternalSubscriberId = internalSubscriberId ?? throw new global::System.ArgumentNullException(nameof(internalSubscriberId));
            this.SubscriberId = subscriberId;
            this.Status = status;
            this.DeliveryLifecycleStatus = deliveryLifecycleStatus;
            this.TriggerIdentifier = triggerIdentifier ?? throw new global::System.ArgumentNullException(nameof(triggerIdentifier));
            this.TransactionId = transactionId ?? throw new global::System.ArgumentNullException(nameof(transactionId));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.Severity = severity;
            this.Critical = critical;
            this.ContextKeys = contextKeys;
            this.Topics = topics;
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWorkflowRunsDto" /> class.
        /// </summary>
        public GetWorkflowRunsDto()
        {
        }
    }
}