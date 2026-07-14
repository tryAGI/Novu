#nullable enable

namespace Novu
{
    public partial interface IAgentsIntegrationsClient
    {
        /// <summary>
        /// Update an agent integration<br/>
        /// Update which integration a link points to (by integration **identifier**, not the internal _id).
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="agentIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse> Update2Async(
            string identifier,
            string agentIntegrationId,

            global::Novu.UpdateAgentIntegrationRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent integration<br/>
        /// Update which integration a link points to (by integration **identifier**, not the internal _id).
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="agentIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse>> Update2AsResponseAsync(
            string identifier,
            string agentIntegrationId,

            global::Novu.UpdateAgentIntegrationRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an agent integration<br/>
        /// Update which integration a link points to (by integration **identifier**, not the internal _id).
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="agentIntegrationId"></param>
        /// <param name="integrationIdentifier">
        /// The integration identifier this link should point to (not the internal document _id).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentIntegrationsControllerUpdateAgentIntegrationResponse> Update2Async(
            string identifier,
            string agentIntegrationId,
            string integrationIdentifier,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}