#nullable enable

namespace Novu
{
    public partial interface IDomainsRoutesClient
    {
        /// <summary>
        /// List routes for a domain<br/>
        /// Returns a paginated list of routes attached to the domain. Optionally filter by an agent identifier to find routes pointing to a specific agent.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerListDomainRoutesResponse> List2Async(
            string domain,
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.DomainsControllerListDomainRoutesOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? agentId = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List routes for a domain<br/>
        /// Returns a paginated list of routes attached to the domain. Optionally filter by an agent identifier to find routes pointing to a specific agent.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="agentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerListDomainRoutesResponse>> List2AsResponseAsync(
            string domain,
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.DomainsControllerListDomainRoutesOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? agentId = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}