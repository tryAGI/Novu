#nullable enable

namespace Novu
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Update an agent bridge<br/>
        /// Update the bridge URL configuration for an agent. Used by the CLI to register dev tunnel URLs. Refuses to activate dev bridges on production environments.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentsControllerUpdateAgentBridgeResponse> UpdateBridgeAsync(
            string identifier,

            global::Novu.UpdateAgentBridgeRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent bridge<br/>
        /// Update the bridge URL configuration for an agent. Used by the CLI to register dev tunnel URLs. Refuses to activate dev bridges on production environments.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.AgentsControllerUpdateAgentBridgeResponse>> UpdateBridgeAsResponseAsync(
            string identifier,

            global::Novu.UpdateAgentBridgeRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent bridge<br/>
        /// Update the bridge URL configuration for an agent. Used by the CLI to register dev tunnel URLs. Refuses to activate dev bridges on production environments.
        /// </summary>
        /// <param name="identifier"></param>
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
        global::System.Threading.Tasks.Task<global::Novu.AgentsControllerUpdateAgentBridgeResponse> UpdateBridgeAsync(
            string identifier,
            string? bridgeUrl = default,
            string? devBridgeUrl = default,
            bool? devBridgeActive = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}