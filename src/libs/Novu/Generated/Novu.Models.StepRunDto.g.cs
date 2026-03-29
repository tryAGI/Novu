
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepRunDto
    {
        /// <summary>
        /// Step run identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepRunId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepRunId { get; set; }

        /// <summary>
        /// Step identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepId { get; set; }

        /// <summary>
        /// Step type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepType { get; set; }

        /// <summary>
        /// Provider identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// Step status
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.StepRunDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.StepRunDtoStatus Status { get; set; }

        /// <summary>
        /// Creation timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Update timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Execution details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionDetails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.StepExecutionDetailDto> ExecutionDetails { get; set; }

        /// <summary>
        /// Optional digest for the job, including metadata and events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        public global::Novu.DigestMetadataDto? Digest { get; set; }

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
        /// Initializes a new instance of the <see cref="StepRunDto" /> class.
        /// </summary>
        /// <param name="stepRunId">
        /// Step run identifier
        /// </param>
        /// <param name="stepId">
        /// Step identifier
        /// </param>
        /// <param name="stepType">
        /// Step type
        /// </param>
        /// <param name="status">
        /// Step status
        /// </param>
        /// <param name="createdAt">
        /// Creation timestamp
        /// </param>
        /// <param name="updatedAt">
        /// Update timestamp
        /// </param>
        /// <param name="executionDetails">
        /// Execution details
        /// </param>
        /// <param name="providerId">
        /// Provider identifier
        /// </param>
        /// <param name="digest">
        /// Optional digest for the job, including metadata and events
        /// </param>
        /// <param name="scheduleExtensionsCount">
        /// The number of times the digest/delay job has been extended to align with the subscribers schedule
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepRunDto(
            string stepRunId,
            string stepId,
            string stepType,
            global::Novu.StepRunDtoStatus status,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Novu.StepExecutionDetailDto> executionDetails,
            string? providerId,
            global::Novu.DigestMetadataDto? digest,
            double? scheduleExtensionsCount)
        {
            this.StepRunId = stepRunId ?? throw new global::System.ArgumentNullException(nameof(stepRunId));
            this.StepId = stepId ?? throw new global::System.ArgumentNullException(nameof(stepId));
            this.StepType = stepType ?? throw new global::System.ArgumentNullException(nameof(stepType));
            this.ProviderId = providerId;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ExecutionDetails = executionDetails ?? throw new global::System.ArgumentNullException(nameof(executionDetails));
            this.Digest = digest;
            this.ScheduleExtensionsCount = scheduleExtensionsCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepRunDto" /> class.
        /// </summary>
        public StepRunDto()
        {
        }
    }
}