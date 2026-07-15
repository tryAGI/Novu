
#nullable enable

namespace Novu
{
    /// <summary>
    /// Novu tool-approval card descriptor (`type: "tool-approval-card"`). Used with `toolApprovalRequest` to render Approve/Deny UI.<br/>
    /// Example: {"type":"tool-approval-card","title":"Approve refund?","subtitle":"issue_refund \u00B7 ORD-42 \u00B7 $25.00","approveLabel":"Approve","denyLabel":"Deny"}
    /// </summary>
    public sealed partial class ToolApprovalCardReplyContentDtoToolApprovalCard
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}