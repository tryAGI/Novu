
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolApprovalRequestPayloadDto
    {
        /// <summary>
        /// Unique id for this approval request (matches the AI SDK approvalId).<br/>
        /// Example: apr_01HZX
        /// </summary>
        /// <example>apr_01HZX</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("approvalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApprovalId { get; set; }

        /// <summary>
        /// Id of the tool call awaiting approval.<br/>
        /// Example: call_refund_1
        /// </summary>
        /// <example>call_refund_1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Name of the gated tool.<br/>
        /// Example: issue_refund
        /// </summary>
        /// <example>issue_refund</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tool input the model proposed.<br/>
        /// Example: {"orderId":"ORD-42","amountCents":2500}
        /// </summary>
        /// <example>{"orderId":"ORD-42","amountCents":2500}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Server-minted approve action id. When omitted, self-hosted tool-approval:* is minted at persist.<br/>
        /// Example: tool-approval:approve:apr_01HZX
        /// </summary>
        /// <example>tool-approval:approve:apr_01HZX</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("approveActionId")]
        public string? ApproveActionId { get; set; }

        /// <summary>
        /// Server-minted deny action id. When omitted, self-hosted tool-approval:* is minted at persist.<br/>
        /// Example: tool-approval:deny:apr_01HZX
        /// </summary>
        /// <example>tool-approval:deny:apr_01HZX</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("denyActionId")]
        public string? DenyActionId { get; set; }

        /// <summary>
        /// MCP server name when the gated tool is from an MCP server (for UI labels).<br/>
        /// Example: GitHub
        /// </summary>
        /// <example>GitHub</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcpServerName")]
        public string? McpServerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalRequestPayloadDto" /> class.
        /// </summary>
        /// <param name="approvalId">
        /// Unique id for this approval request (matches the AI SDK approvalId).<br/>
        /// Example: apr_01HZX
        /// </param>
        /// <param name="toolCallId">
        /// Id of the tool call awaiting approval.<br/>
        /// Example: call_refund_1
        /// </param>
        /// <param name="name">
        /// Name of the gated tool.<br/>
        /// Example: issue_refund
        /// </param>
        /// <param name="input">
        /// Tool input the model proposed.<br/>
        /// Example: {"orderId":"ORD-42","amountCents":2500}
        /// </param>
        /// <param name="approveActionId">
        /// Server-minted approve action id. When omitted, self-hosted tool-approval:* is minted at persist.<br/>
        /// Example: tool-approval:approve:apr_01HZX
        /// </param>
        /// <param name="denyActionId">
        /// Server-minted deny action id. When omitted, self-hosted tool-approval:* is minted at persist.<br/>
        /// Example: tool-approval:deny:apr_01HZX
        /// </param>
        /// <param name="mcpServerName">
        /// MCP server name when the gated tool is from an MCP server (for UI labels).<br/>
        /// Example: GitHub
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolApprovalRequestPayloadDto(
            string approvalId,
            string toolCallId,
            string name,
            object? input,
            string? approveActionId,
            string? denyActionId,
            string? mcpServerName)
        {
            this.ApprovalId = approvalId ?? throw new global::System.ArgumentNullException(nameof(approvalId));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input;
            this.ApproveActionId = approveActionId;
            this.DenyActionId = denyActionId;
            this.McpServerName = mcpServerName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalRequestPayloadDto" /> class.
        /// </summary>
        public ToolApprovalRequestPayloadDto()
        {
        }

    }
}