#nullable enable

namespace Novu
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Send an agent reply<br/>
        /// Send a reply into an existing agent conversation from server-side code. Supports plain text, markdown, cards, edits, reactions, typing indicators, tool results, and conversation resolution signals.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SendReplyAsync(
            string agentId,

            global::Novu.AgentReplyPayloadDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an agent reply<br/>
        /// Send a reply into an existing agent conversation from server-side code. Supports plain text, markdown, cards, edits, reactions, typing indicators, tool results, and conversation resolution signals.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<string>> SendReplyAsResponseAsync(
            string agentId,

            global::Novu.AgentReplyPayloadDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Send an agent reply<br/>
        /// Send a reply into an existing agent conversation from server-side code. Supports plain text, markdown, cards, edits, reactions, typing indicators, tool results, and conversation resolution signals.
        /// </summary>
        /// <param name="agentId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SendReplyAsync(
            string agentId,
            string conversationId,
            string integrationIdentifier,
            global::Novu.ReplyContentDto? reply = default,
            global::Novu.ToolApprovalRequestPayloadDto? toolApprovalRequest = default,
            global::Novu.EditPayloadDto? edit = default,
            global::Novu.ResolveDto? resolve = default,
            global::System.Collections.Generic.IList<global::Novu.SignalDto>? signals = default,
            global::System.Collections.Generic.IList<global::Novu.ToolResultDto>? toolResults = default,
            global::System.Collections.Generic.IList<global::Novu.AddReactionPayloadDto>? addReactions = default,
            global::System.Collections.Generic.IList<global::Novu.DeleteMessagePayloadDto>? deleteMessages = default,
            object? typing = default,
            bool? error = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}