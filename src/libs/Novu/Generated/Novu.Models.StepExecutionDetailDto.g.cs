
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepExecutionDetailDto
    {
        /// <summary>
        /// Unique identifier of the execution detail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Creation time of the execution detail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Status of the execution detail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ExecutionDetailsStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ExecutionDetailsStatusEnum Status { get; set; }

        /// <summary>
        /// Detailed information about the execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Provider identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// Raw data of the execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public object? Raw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepExecutionDetailDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the execution detail
        /// </param>
        /// <param name="status">
        /// Status of the execution detail
        /// </param>
        /// <param name="detail">
        /// Detailed information about the execution
        /// </param>
        /// <param name="createdAt">
        /// Creation time of the execution detail
        /// </param>
        /// <param name="providerId">
        /// Provider identifier
        /// </param>
        /// <param name="raw">
        /// Raw data of the execution
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepExecutionDetailDto(
            string id,
            global::Novu.ExecutionDetailsStatusEnum status,
            string detail,
            string? createdAt,
            string? providerId,
            object? raw)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.ProviderId = providerId;
            this.Raw = raw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepExecutionDetailDto" /> class.
        /// </summary>
        public StepExecutionDetailDto()
        {
        }
    }
}