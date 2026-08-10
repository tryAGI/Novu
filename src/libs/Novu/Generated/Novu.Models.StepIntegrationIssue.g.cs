
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepIntegrationIssue
    {
        /// <summary>
        /// Type of integration issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issueType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.IntegrationIssueEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.IntegrationIssueEnum IssueType { get; set; }

        /// <summary>
        /// Name of the variable related to the issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableName")]
        public string? VariableName { get; set; }

        /// <summary>
        /// Detailed message describing the issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Blocking severity of the issue. `error` (default when omitted) blocks save; `warning` is a non-blocking notice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.StepIssueSeverityEnumJsonConverter))]
        public global::Novu.StepIssueSeverityEnum? Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepIntegrationIssue" /> class.
        /// </summary>
        /// <param name="issueType">
        /// Type of integration issue
        /// </param>
        /// <param name="message">
        /// Detailed message describing the issue
        /// </param>
        /// <param name="variableName">
        /// Name of the variable related to the issue
        /// </param>
        /// <param name="severity">
        /// Blocking severity of the issue. `error` (default when omitted) blocks save; `warning` is a non-blocking notice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepIntegrationIssue(
            global::Novu.IntegrationIssueEnum issueType,
            string message,
            string? variableName,
            global::Novu.StepIssueSeverityEnum? severity)
        {
            this.IssueType = issueType;
            this.VariableName = variableName;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepIntegrationIssue" /> class.
        /// </summary>
        public StepIntegrationIssue()
        {
        }

    }
}