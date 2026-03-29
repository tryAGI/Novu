
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StepContentIssueDto
    {
        /// <summary>
        /// Type of step content issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issueType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ContentIssueEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ContentIssueEnum IssueType { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StepContentIssueDto" /> class.
        /// </summary>
        /// <param name="issueType">
        /// Type of step content issue
        /// </param>
        /// <param name="message">
        /// Detailed message describing the issue
        /// </param>
        /// <param name="variableName">
        /// Name of the variable related to the issue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StepContentIssueDto(
            global::Novu.ContentIssueEnum issueType,
            string message,
            string? variableName)
        {
            this.IssueType = issueType;
            this.VariableName = variableName;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StepContentIssueDto" /> class.
        /// </summary>
        public StepContentIssueDto()
        {
        }
    }
}