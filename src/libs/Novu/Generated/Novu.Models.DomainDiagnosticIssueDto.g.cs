
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DomainDiagnosticIssueDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DomainDiagnosticIssueDtoCode Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DomainDiagnosticIssueDtoSeverityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DomainDiagnosticIssueDtoSeverity Severity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Plain-language remediation guidance
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainDiagnosticIssueDto" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="severity"></param>
        /// <param name="message"></param>
        /// <param name="fix">
        /// Plain-language remediation guidance
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DomainDiagnosticIssueDto(
            global::Novu.DomainDiagnosticIssueDtoCode code,
            global::Novu.DomainDiagnosticIssueDtoSeverity severity,
            string message,
            string fix)
        {
            this.Code = code;
            this.Severity = severity;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Fix = fix ?? throw new global::System.ArgumentNullException(nameof(fix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DomainDiagnosticIssueDto" /> class.
        /// </summary>
        public DomainDiagnosticIssueDto()
        {
        }
    }
}