
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainDiagnosticCheckDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DomainDiagnosticCheckDtoCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DomainDiagnosticCheckDtoStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DomainDiagnosticCheckDtoStatus Status { get; set; }

        /// <summary>
        /// Round-trip time for this check in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LatencyMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainDiagnosticCheckDto" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="status"></param>
        /// <param name="latencyMs">
        /// Round-trip time for this check in milliseconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainDiagnosticCheckDto(
            global::Novu.DomainDiagnosticCheckDtoCode code,
            global::Novu.DomainDiagnosticCheckDtoStatus status,
            double latencyMs)
        {
            this.Code = code;
            this.Status = status;
            this.LatencyMs = latencyMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainDiagnosticCheckDto" /> class.
        /// </summary>
        public DomainDiagnosticCheckDto()
        {
        }
    }
}