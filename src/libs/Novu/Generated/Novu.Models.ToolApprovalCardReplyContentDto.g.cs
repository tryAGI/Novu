
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolApprovalCardReplyContentDto
    {
        /// <summary>
        /// Novu tool-approval card descriptor (`type: "tool-approval-card"`). Used with `toolApprovalRequest` to render Approve/Deny UI.<br/>
        /// Example: {"type":"tool-approval-card","title":"Approve refund?","subtitle":"issue_refund \u00B7 ORD-42 \u00B7 $25.00","approveLabel":"Approve","denyLabel":"Deny"}
        /// </summary>
        /// <example>{"type":"tool-approval-card","title":"Approve refund?","subtitle":"issue_refund \u00B7 ORD-42 \u00B7 $25.00","approveLabel":"Approve","denyLabel":"Deny"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolApprovalCard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ToolApprovalCard { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Novu.FileRefDto>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalCardReplyContentDto" /> class.
        /// </summary>
        /// <param name="toolApprovalCard">
        /// Novu tool-approval card descriptor (`type: "tool-approval-card"`). Used with `toolApprovalRequest` to render Approve/Deny UI.<br/>
        /// Example: {"type":"tool-approval-card","title":"Approve refund?","subtitle":"issue_refund \u00B7 ORD-42 \u00B7 $25.00","approveLabel":"Approve","denyLabel":"Deny"}
        /// </param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolApprovalCardReplyContentDto(
            object toolApprovalCard,
            global::System.Collections.Generic.IList<global::Novu.FileRefDto>? files)
        {
            this.ToolApprovalCard = toolApprovalCard ?? throw new global::System.ArgumentNullException(nameof(toolApprovalCard));
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalCardReplyContentDto" /> class.
        /// </summary>
        public ToolApprovalCardReplyContentDto()
        {
        }

    }
}