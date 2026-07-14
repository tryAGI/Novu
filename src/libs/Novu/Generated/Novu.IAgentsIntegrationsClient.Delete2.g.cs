#nullable enable

namespace Novu
{
    public partial interface IAgentsIntegrationsClient
    {
        /// <summary>
        /// Delete an agent integration<br/>
        /// Delete a specific agent-integration link by its document id.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="agentIntegrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task Delete2Async(
            string identifier,
            string agentIntegrationId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an agent integration<br/>
        /// Delete a specific agent-integration link by its document id.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="agentIntegrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse> Delete2AsResponseAsync(
            string identifier,
            string agentIntegrationId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}