#nullable enable

namespace Novu
{
    public partial interface IAgentsIntegrationsClient
    {
        /// <summary>
        /// Create an agent integration<br/>
        /// Create a link between an agent (by identifier) and an integration (by integration **identifier**, not the internal _id).
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse> Create2Async(
            string identifier,

            global::Novu.AddAgentIntegrationRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent integration<br/>
        /// Create a link between an agent (by identifier) and an integration (by integration **identifier**, not the internal _id).
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse>> Create2AsResponseAsync(
            string identifier,

            global::Novu.AddAgentIntegrationRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an agent integration<br/>
        /// Create a link between an agent (by identifier) and an integration (by integration **identifier**, not the internal _id).
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="integrationIdentifier">
        /// The integration identifier (same as in the integration store), not the internal document _id.
        /// </param>
        /// <param name="providerId">
        /// Provider ID to auto-create a dedicated integration (e.g. novu-agent-email). When set, the server creates the integration if one does not already exist for this agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentIntegrationsControllerAddAgentIntegrationResponse> Create2Async(
            string identifier,
            string? integrationIdentifier = default,
            string? providerId = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}