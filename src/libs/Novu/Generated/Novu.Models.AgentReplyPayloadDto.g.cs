
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentReplyPayloadDto
    {
        /// <summary>
        /// Conversation id to reply into. Obtained from the inbound agent event / bridge payload.<br/>
        /// Example: 64f5a1c2e8b7a3d9f0c1b2a3
        /// </summary>
        /// <example>64f5a1c2e8b7a3d9f0c1b2a3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConversationId { get; set; }

        /// <summary>
        /// Channel integration identifier linked to the agent for this conversation (e.g. `slack-support`).<br/>
        /// Example: slack-support
        /// </summary>
        /// <example>slack-support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationIdentifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationIdentifier { get; set; }

        /// <summary>
        /// Outbound message content. Exactly one of `markdown`, `card`, or `toolApprovalCard`. Optional `files` attach to the message. Cannot be combined with `edit`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>))]
        public global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>? Reply { get; set; }

        /// <summary>
        /// Tool-lifecycle ledger row for a gated tool call. Pair with `reply.toolApprovalCard` (or another reply shape) to deliver the approval UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolApprovalRequest")]
        public global::Novu.ToolApprovalRequestPayloadDto? ToolApprovalRequest { get; set; }

        /// <summary>
        /// In-place edit of a previously posted agent message. Cannot be combined with reply, resolve, signals, toolResults, toolApprovalRequest, addReactions, or deleteMessages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edit")]
        public global::Novu.EditPayloadDto? Edit { get; set; }

        /// <summary>
        /// Mark the conversation resolved. May be combined with a final `reply`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolve")]
        public global::Novu.ResolveDto? Resolve { get; set; }

        /// <summary>
        /// Side-effect signals executed during this turn: conversation metadata mutations, Novu workflow triggers, or human-in-the-loop interactions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signals")]
        public global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? Signals { get; set; }

        /// <summary>
        /// Tool-call outcomes to persist in conversation history (typically before the assistant reply).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolResults")]
        public global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? ToolResults { get; set; }

        /// <summary>
        /// Emoji reactions to add to existing platform messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addReactions")]
        public global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? AddReactions { get; set; }

        /// <summary>
        /// Delete previously posted platform messages. Removes the rendered message only — history is preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteMessages")]
        public global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? DeleteMessages { get; set; }

        /// <summary>
        /// Per-turn typing/status control. Pass `{ status?: string }` to set/update the status (omit `status` for "Thinking…"), or `"stop"` to clear it. Best-effort per platform.<br/>
        /// Example: {"status":"Looking up your order\u2026"}
        /// </summary>
        /// <example>{"status":"Looking up your order\u2026"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("typing")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>))]
        public global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>? Typing { get; set; }

        /// <summary>
        /// Bridge reports that the customer runtime failed this turn. Cannot be combined with other actions. Novu delivers generic user-facing error copy.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
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
        /// <param name="conversationId">
        /// Conversation id to reply into. Obtained from the inbound agent event / bridge payload.<br/>
        /// Example: 64f5a1c2e8b7a3d9f0c1b2a3
        /// </param>
        /// <param name="integrationIdentifier">
        /// Channel integration identifier linked to the agent for this conversation (e.g. `slack-support`).<br/>
        /// Example: slack-support
        /// </param>
        /// <param name="reply">
        /// Outbound message content. Exactly one of `markdown`, `card`, or `toolApprovalCard`. Optional `files` attach to the message. Cannot be combined with `edit`.
        /// </param>
        /// <param name="toolApprovalRequest">
        /// Tool-lifecycle ledger row for a gated tool call. Pair with `reply.toolApprovalCard` (or another reply shape) to deliver the approval UI.
        /// </param>
        /// <param name="edit">
        /// In-place edit of a previously posted agent message. Cannot be combined with reply, resolve, signals, toolResults, toolApprovalRequest, addReactions, or deleteMessages.
        /// </param>
        /// <param name="resolve">
        /// Mark the conversation resolved. May be combined with a final `reply`.
        /// </param>
        /// <param name="signals">
        /// Side-effect signals executed during this turn: conversation metadata mutations, Novu workflow triggers, or human-in-the-loop interactions.
        /// </param>
        /// <param name="toolResults">
        /// Tool-call outcomes to persist in conversation history (typically before the assistant reply).
        /// </param>
        /// <param name="addReactions">
        /// Emoji reactions to add to existing platform messages.
        /// </param>
        /// <param name="deleteMessages">
        /// Delete previously posted platform messages. Removes the rendered message only — history is preserved.
        /// </param>
        /// <param name="typing">
        /// Per-turn typing/status control. Pass `{ status?: string }` to set/update the status (omit `status` for "Thinking…"), or `"stop"` to clear it. Best-effort per platform.<br/>
        /// Example: {"status":"Looking up your order\u2026"}
        /// </param>
        /// <param name="error">
        /// Bridge reports that the customer runtime failed this turn. Cannot be combined with other actions. Novu delivers generic user-facing error copy.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentReplyPayloadDto(
            string conversationId,
            string integrationIdentifier,
            global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>? reply,
            global::Novu.ToolApprovalRequestPayloadDto? toolApprovalRequest,
            global::Novu.EditPayloadDto? edit,
            global::Novu.ResolveDto? resolve,
            global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? signals,
            global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? toolResults,
            global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? addReactions,
            global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? deleteMessages,
            global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>? typing,
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