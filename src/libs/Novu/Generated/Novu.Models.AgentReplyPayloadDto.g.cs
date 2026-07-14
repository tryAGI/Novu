
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentReplyPayloadDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationIdentifier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply")]
        public global::Novu.ReplyContentDto? Reply { get; set; }

        /// <summary>
        /// Tool-lifecycle ledger row for a gated tool call. Optional reply delivers the approval card.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolApprovalRequest")]
        public global::Novu.ToolApprovalRequestPayloadDto? ToolApprovalRequest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit")]
        public global::Novu.EditPayloadDto? Edit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolve")]
        public global::Novu.ResolveDto? Resolve { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signals")]
        public global::System.Collections.Generic.IList<global::Novu.SignalDto>? Signals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolResults")]
        public global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? ToolResults { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addReactions")]
        public global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? AddReactions { get; set; }

        /// <summary>
        /// Delete previously posted platform messages. Removes the rendered message only — history is preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteMessages")]
        public global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? DeleteMessages { get; set; }

        /// <summary>
        /// Per-turn typing/status control. `{ status?: string }` sets the status text (omit for the default "Thinking…"); `"stop"` clears it. Best-effort per platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typing")]
        public object? Typing { get; set; }

        /// <summary>
        /// Bridge reports the turn failed on the customer runtime. Delivers generic user copy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReplyPayloadDto" /> class.
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="integrationIdentifier"></param>
        /// <param name="reply"></param>
        /// <param name="toolApprovalRequest">
        /// Tool-lifecycle ledger row for a gated tool call. Optional reply delivers the approval card.
        /// </param>
        /// <param name="edit"></param>
        /// <param name="resolve"></param>
        /// <param name="signals"></param>
        /// <param name="toolResults"></param>
        /// <param name="addReactions"></param>
        /// <param name="deleteMessages">
        /// Delete previously posted platform messages. Removes the rendered message only — history is preserved.
        /// </param>
        /// <param name="typing">
        /// Per-turn typing/status control. `{ status?: string }` sets the status text (omit for the default "Thinking…"); `"stop"` clears it. Best-effort per platform.
        /// </param>
        /// <param name="error">
        /// Bridge reports the turn failed on the customer runtime. Delivers generic user copy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentReplyPayloadDto(
            string conversationId,
            string integrationIdentifier,
            global::Novu.ReplyContentDto? reply,
            global::Novu.ToolApprovalRequestPayloadDto? toolApprovalRequest,
            global::Novu.EditPayloadDto? edit,
            global::Novu.ResolveDto? resolve,
            global::System.Collections.Generic.IList<global::Novu.SignalDto>? signals,
            global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? toolResults,
            global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? addReactions,
            global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? deleteMessages,
            object? typing,
            bool? error)
        {
            this.ConversationId = conversationId ?? throw new global::System.ArgumentNullException(nameof(conversationId));
            this.IntegrationIdentifier = integrationIdentifier ?? throw new global::System.ArgumentNullException(nameof(integrationIdentifier));
            this.Reply = reply;
            this.ToolApprovalRequest = toolApprovalRequest;
            this.Edit = edit;
            this.Resolve = resolve;
            this.Signals = signals;
            this.ToolResults = toolResults;
            this.AddReactions = addReactions;
            this.DeleteMessages = deleteMessages;
            this.Typing = typing;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentReplyPayloadDto" /> class.
        /// </summary>
        public AgentReplyPayloadDto()
        {
        }

    }
}