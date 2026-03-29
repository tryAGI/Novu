
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListWorkflowResponse
    {
        /// <summary>
        /// List of workflows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto> Workflows { get; set; }

        /// <summary>
        /// Total number of workflows
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowResponse" /> class.
        /// </summary>
        /// <param name="workflows">
        /// List of workflows
        /// </param>
        /// <param name="totalCount">
        /// Total number of workflows
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListWorkflowResponse(
            global::System.Collections.Generic.IList<global::Novu.WorkflowListResponseDto> workflows,
            double totalCount)
        {
            this.Workflows = workflows ?? throw new global::System.ArgumentNullException(nameof(workflows));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListWorkflowResponse" /> class.
        /// </summary>
        public ListWorkflowResponse()
        {
        }
    }
}