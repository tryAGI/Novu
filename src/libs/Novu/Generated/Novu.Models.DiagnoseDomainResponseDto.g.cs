
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiagnoseDomainResponseDto
    {
        /// <summary>
        /// True when there are no error-severity issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ok")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ok { get; set; }

        /// <summary>
        /// ISO timestamp when the diagnostic run finished
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto> Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto> Issues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnoseDomainResponseDto" /> class.
        /// </summary>
        /// <param name="ok">
        /// True when there are no error-severity issues
        /// </param>
        /// <param name="runAt">
        /// ISO timestamp when the diagnostic run finished
        /// </param>
        /// <param name="checks"></param>
        /// <param name="issues"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiagnoseDomainResponseDto(
            bool ok,
            string runAt,
            global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticCheckDto> checks,
            global::System.Collections.Generic.IList<global::Novu.DomainDiagnosticIssueDto> issues)
        {
            this.Ok = ok;
            this.RunAt = runAt ?? throw new global::System.ArgumentNullException(nameof(runAt));
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
            this.Issues = issues ?? throw new global::System.ArgumentNullException(nameof(issues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnoseDomainResponseDto" /> class.
        /// </summary>
        public DiagnoseDomainResponseDto()
        {
        }
    }
}