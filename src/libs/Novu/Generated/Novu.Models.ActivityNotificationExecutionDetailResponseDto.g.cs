
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityNotificationExecutionDetailResponseDto
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
        /// Whether the execution is a retry or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isRetry")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRetry { get; set; }

        /// <summary>
        /// Whether the execution is a test or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isTest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTest { get; set; }

        /// <summary>
        /// Provider ID of the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerId")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ProvidersIdEnumJsonConverter))]
        public global::Novu.ProvidersIdEnum? ProviderId { get; set; }

        /// <summary>
        /// Raw data of the execution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public string? Raw { get; set; }

        /// <summary>
        /// Source of the execution detail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ExecutionDetailsSourceEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ExecutionDetailsSourceEnum Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationExecutionDetailResponseDto" /> class.
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
        /// <param name="isRetry">
        /// Whether the execution is a retry or not
        /// </param>
        /// <param name="isTest">
        /// Whether the execution is a test or not
        /// </param>
        /// <param name="source">
        /// Source of the execution detail
        /// </param>
        /// <param name="createdAt">
        /// Creation time of the execution detail
        /// </param>
        /// <param name="providerId">
        /// Provider ID of the job
        /// </param>
        /// <param name="raw">
        /// Raw data of the execution
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityNotificationExecutionDetailResponseDto(
            string id,
            global::Novu.ExecutionDetailsStatusEnum status,
            string detail,
            bool isRetry,
            bool isTest,
            global::Novu.ExecutionDetailsSourceEnum source,
            string? createdAt,
            global::Novu.ProvidersIdEnum? providerId,
            string? raw)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
            this.IsRetry = isRetry;
            this.IsTest = isTest;
            this.ProviderId = providerId;
            this.Raw = raw;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationExecutionDetailResponseDto" /> class.
        /// </summary>
        public ActivityNotificationExecutionDetailResponseDto()
        {
        }
    }
}