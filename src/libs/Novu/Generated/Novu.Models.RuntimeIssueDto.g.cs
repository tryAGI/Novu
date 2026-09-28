
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RuntimeIssueDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issueType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.WorkflowIssueTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowIssueTypeEnum IssueType { get; set; }

        /// <summary>
        /// Variable associated with the issue
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variableName")]
        public string? VariableName { get; set; }

        /// <summary>
        /// Human-readable issue message
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
        /// Initializes a new instance of the <see cref="RuntimeIssueDto" /> class.
        /// </summary>
        /// <param name="issueType"></param>
        /// <param name="message">
        /// Human-readable issue message
        /// </param>
        /// <param name="variableName">
        /// Variable associated with the issue
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RuntimeIssueDto(
            global::Novu.WorkflowIssueTypeEnum issueType,
            string message,
            string? variableName)
        {
            this.IssueType = issueType;
            this.VariableName = variableName;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RuntimeIssueDto" /> class.
        /// </summary>
        public RuntimeIssueDto()
        {
        }

    }
}