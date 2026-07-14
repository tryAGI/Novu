
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolApprovalRequestPayloadDto
    {
        /// <summary>
        /// Unique id for this approval request (matches the AI SDK approvalId).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approvalId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApprovalId { get; set; }

        /// <summary>
        /// Id of the tool call awaiting approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolCallId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Name of the gated tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Tool input the model proposed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalRequestPayloadDto" /> class.
        /// </summary>
        /// <param name="approvalId">
        /// Unique id for this approval request (matches the AI SDK approvalId).
        /// </param>
        /// <param name="toolCallId">
        /// Id of the tool call awaiting approval.
        /// </param>
        /// <param name="name">
        /// Name of the gated tool.
        /// </param>
        /// <param name="input">
        /// Tool input the model proposed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolApprovalRequestPayloadDto(
            string approvalId,
            string toolCallId,
            string name,
            object? input)
        {
            this.ApprovalId = approvalId ?? throw new global::System.ArgumentNullException(nameof(approvalId));
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolApprovalRequestPayloadDto" /> class.
        /// </summary>
        public ToolApprovalRequestPayloadDto()
        {
        }

    }
}