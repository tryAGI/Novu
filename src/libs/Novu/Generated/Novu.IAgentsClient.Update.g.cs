#nullable enable

namespace Novu
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an agent<br/>
        /// Update an agent by its external identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentsControllerUpdateAgentResponse> UpdateAsync(
            string identifier,

            global::Novu.UpdateAgentRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent<br/>
        /// Update an agent by its external identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.AgentsControllerUpdateAgentResponse>> UpdateAsResponseAsync(
            string identifier,

            global::Novu.UpdateAgentRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent<br/>
        /// Update an agent by its external identifier.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="active"></param>
        /// <param name="behavior"></param>
        /// <param name="bridgeUrl">
        /// Production bridge URL for this agent
        /// </param>
        /// <param name="devBridgeUrl">
        /// Development bridge URL (set by npx novu dev)
        /// </param>
        /// <param name="devBridgeActive">
        /// Whether the dev bridge override is active
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentsControllerUpdateAgentResponse> UpdateAsync(
            string identifier,
            string? name = default,
            string? description = default,
            bool? active = default,
            global::Novu.AgentBehaviorDto? behavior = default,
            string? bridgeUrl = default,
            string? devBridgeUrl = default,
            bool? devBridgeActive = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}