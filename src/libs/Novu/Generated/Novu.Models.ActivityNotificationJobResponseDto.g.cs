
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityNotificationJobResponseDto
    {
        /// <summary>
        /// Unique identifier of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ActivityNotificationJobResponseDtoTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ActivityNotificationJobResponseDtoType Type { get; set; }

        /// <summary>
        /// Optional digest for the job, including metadata and events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public global::Novu.DigestMetadataDto? Digest { get; set; }

        /// <summary>
        /// Execution details of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionDetails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.ActivityNotificationExecutionDetailResponseDto> ExecutionDetails { get; set; }

        /// <summary>
        /// Step details of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ActivityNotificationStepResponseDto Step { get; set; }

        /// <summary>
        /// Optional context object for additional error details.<br/>
        /// Example: {"workflowId":"some_wf_id","stepId":"some_wf_id"}
        /// </summary>
        /// <example>{"workflowId":"some_wf_id","stepId":"some_wf_id"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public object? Overrides { get; set; }

        /// <summary>
        /// Optional payload for the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// Provider ID of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ProvidersIdEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ProvidersIdEnum ProviderId { get; set; }

        /// <summary>
        /// Status of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Updated time of the notification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// The number of times the digest/delay job has been extended to align with the subscribers schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduleExtensionsCount")]
        public double? ScheduleExtensionsCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationJobResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the job
        /// </param>
        /// <param name="type">
        /// Type of the job
        /// </param>
        /// <param name="executionDetails">
        /// Execution details of the job
        /// </param>
        /// <param name="step">
        /// Step details of the job
        /// </param>
        /// <param name="providerId">
        /// Provider ID of the job
        /// </param>
        /// <param name="status">
        /// Status of the job
        /// </param>
        /// <param name="digest">
        /// Optional digest for the job, including metadata and events
        /// </param>
        /// <param name="overrides">
        /// Optional context object for additional error details.<br/>
        /// Example: {"workflowId":"some_wf_id","stepId":"some_wf_id"}
        /// </param>
        /// <param name="payload">
        /// Optional payload for the job
        /// </param>
        /// <param name="updatedAt">
        /// Updated time of the notification
        /// </param>
        /// <param name="scheduleExtensionsCount">
        /// The number of times the digest/delay job has been extended to align with the subscribers schedule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityNotificationJobResponseDto(
            string id,
            global::Novu.ActivityNotificationJobResponseDtoType type,
            global::System.Collections.Generic.IList<global::Novu.ActivityNotificationExecutionDetailResponseDto> executionDetails,
            global::Novu.ActivityNotificationStepResponseDto step,
            global::Novu.ProvidersIdEnum providerId,
            string status,
            global::Novu.DigestMetadataDto? digest,
            object? overrides,
            object? payload,
            string? updatedAt,
            double? scheduleExtensionsCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Digest = digest;
            this.ExecutionDetails = executionDetails ?? throw new global::System.ArgumentNullException(nameof(executionDetails));
            this.Step = step ?? throw new global::System.ArgumentNullException(nameof(step));
            this.Overrides = overrides;
            this.Payload = payload;
            this.ProviderId = providerId;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.UpdatedAt = updatedAt;
            this.ScheduleExtensionsCount = scheduleExtensionsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationJobResponseDto" /> class.
        /// </summary>
        public ActivityNotificationJobResponseDto()
        {
        }
    }
}