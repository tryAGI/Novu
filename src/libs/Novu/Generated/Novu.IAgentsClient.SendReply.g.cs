#nullable enable

namespace Novu
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Send an agent reply<br/>
        /// Send a message or side-effect into an existing agent conversation from your backend.<br/>
        /// Use this endpoint when you are not using `@novu/framework` (for example Python, Go, PHP, .NET, or Java SDKs),<br/>
        /// or when a server process outside the bridge needs to post into a live conversation.<br/>
        /// **Message actions**<br/>
        /// - `reply` — markdown, interactive card, or tool-approval card (optional `files`)<br/>
        /// - `edit` — update a previously delivered message in place<br/>
        /// - `deleteMessages` — remove rendered platform messages (history is kept)<br/>
        /// - `addReactions` — add emoji reactions to existing messages<br/>
        /// **Turn control**<br/>
        /// - `typing` — `{ status?: string }` to set status, or `"stop"` to clear<br/>
        /// - `resolve` — mark the conversation resolved (optionally with a final reply)<br/>
        /// - `error: true` — report a customer-runtime failure (cannot combine with other actions)<br/>
        /// **Signals &amp; tools**<br/>
        /// - `signals` — metadata set/delete/clear, or trigger a Novu workflow<br/>
        /// - `toolResults` — persist tool outputs into conversation history<br/>
        /// - `toolApprovalRequest` — ledger a gated tool call (pair with an approval card reply)<br/>
        /// Returns `{ data: { messageId, platformThreadId } }` when a reply or edit is delivered;<br/>
        /// otherwise `{ data: null }`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse> SendReplyAsync(
            string agentId,

            global::Novu.AgentReplyPayloadDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an agent reply<br/>
        /// Send a message or side-effect into an existing agent conversation from your backend.<br/>
        /// Use this endpoint when you are not using `@novu/framework` (for example Python, Go, PHP, .NET, or Java SDKs),<br/>
        /// or when a server process outside the bridge needs to post into a live conversation.<br/>
        /// **Message actions**<br/>
        /// - `reply` — markdown, interactive card, or tool-approval card (optional `files`)<br/>
        /// - `edit` — update a previously delivered message in place<br/>
        /// - `deleteMessages` — remove rendered platform messages (history is kept)<br/>
        /// - `addReactions` — add emoji reactions to existing messages<br/>
        /// **Turn control**<br/>
        /// - `typing` — `{ status?: string }` to set status, or `"stop"` to clear<br/>
        /// - `resolve` — mark the conversation resolved (optionally with a final reply)<br/>
        /// - `error: true` — report a customer-runtime failure (cannot combine with other actions)<br/>
        /// **Signals &amp; tools**<br/>
        /// - `signals` — metadata set/delete/clear, or trigger a Novu workflow<br/>
        /// - `toolResults` — persist tool outputs into conversation history<br/>
        /// - `toolApprovalRequest` — ledger a gated tool call (pair with an approval card reply)<br/>
        /// Returns `{ data: { messageId, platformThreadId } }` when a reply or edit is delivered;<br/>
        /// otherwise `{ data: null }`.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse>> SendReplyAsResponseAsync(
            string agentId,

            global::Novu.AgentReplyPayloadDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an agent reply<br/>
        /// Send a message or side-effect into an existing agent conversation from your backend.<br/>
        /// Use this endpoint when you are not using `@novu/framework` (for example Python, Go, PHP, .NET, or Java SDKs),<br/>
        /// or when a server process outside the bridge needs to post into a live conversation.<br/>
        /// **Message actions**<br/>
        /// - `reply` — markdown, interactive card, or tool-approval card (optional `files`)<br/>
        /// - `edit` — update a previously delivered message in place<br/>
        /// - `deleteMessages` — remove rendered platform messages (history is kept)<br/>
        /// - `addReactions` — add emoji reactions to existing messages<br/>
        /// **Turn control**<br/>
        /// - `typing` — `{ status?: string }` to set status, or `"stop"` to clear<br/>
        /// - `resolve` — mark the conversation resolved (optionally with a final reply)<br/>
        /// - `error: true` — report a customer-runtime failure (cannot combine with other actions)<br/>
        /// **Signals &amp; tools**<br/>
        /// - `signals` — metadata set/delete/clear, or trigger a Novu workflow<br/>
        /// - `toolResults` — persist tool outputs into conversation history<br/>
        /// - `toolApprovalRequest` — ledger a gated tool call (pair with an approval card reply)<br/>
        /// Returns `{ data: { messageId, platformThreadId } }` when a reply or edit is delivered;<br/>
        /// otherwise `{ data: null }`.
        /// </summary>
        /// <param name="agentId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentReplyControllerHandleAgentReplyHandlerResponse> SendReplyAsync(
            string agentId,
            string conversationId,
            string integrationIdentifier,
            global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>? reply = default,
            global::Novu.ToolApprovalRequestPayloadDto? toolApprovalRequest = default,
            global::Novu.EditPayloadDto? edit = default,
            global::Novu.ResolveDto? resolve = default,
            global::System.Collections.Generic.IList<global::Novu.OneOf<global::Novu.MetadataSetSignalDto, global::Novu.MetadataDeleteSignalDto, global::Novu.MetadataClearSignalDto, global::Novu.TriggerSignalDto, global::Novu.HumanSignalDto>>? signals = default,
            global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? toolResults = default,
            global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? addReactions = default,
            global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? deleteMessages = default,
            global::Novu.OneOf<global::Novu.AgentReplyPayloadDtoTyping?, global::Novu.TypingStatusDto>? typing = default,
            bool? error = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}