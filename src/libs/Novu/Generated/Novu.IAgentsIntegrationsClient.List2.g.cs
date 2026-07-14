#nullable enable

namespace Novu
{
    public partial interface IAgentsIntegrationsClient
    {
        /// <summary>
        /// List agent integrations<br/>
        /// Retrieve integration links for an agent identified by its external identifier. Supports cursor pagination via **after**, **before**, **limit**, **orderBy**, and **orderDirection**.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="integrationIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AgentIntegrationsControllerListAgentIntegrationsResponse> List2Async(
            string identifier,
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? integrationIdentifier = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List agent integrations<br/>
        /// Retrieve integration links for an agent identified by its external identifier. Supports cursor pagination via **after**, **before**, **limit**, **orderBy**, and **orderDirection**.
        /// </summary>
        /// <param name="identifier"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="integrationIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.AgentIntegrationsControllerListAgentIntegrationsResponse>> List2AsResponseAsync(
            string identifier,
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.AgentIntegrationsControllerListAgentIntegrationsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? integrationIdentifier = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}