
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowRunStepsDetailsDto
    {
        /// <summary>
        /// Step run identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Step identifier
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.WorkflowRunStepsDetailsDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowRunStepsDetailsDtoStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunStepsDetailsDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Step run identifier
        /// </param>
        /// <param name="stepRunId">
        /// Step identifier
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
        /// <param name="providerId">
        /// Provider identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowRunStepsDetailsDto(
            string id,
            string stepRunId,
            string stepId,
            string stepType,
            global::Novu.WorkflowRunStepsDetailsDtoStatus status,
            string? providerId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.StepRunId = stepRunId ?? throw new global::System.ArgumentNullException(nameof(stepRunId));
            this.StepId = stepId ?? throw new global::System.ArgumentNullException(nameof(stepId));
            this.StepType = stepType ?? throw new global::System.ArgumentNullException(nameof(stepType));
            this.ProviderId = providerId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowRunStepsDetailsDto" /> class.
        /// </summary>
        public WorkflowRunStepsDetailsDto()
        {
        }
    }
}