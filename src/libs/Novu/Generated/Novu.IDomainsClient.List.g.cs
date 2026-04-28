#nullable enable

namespace Novu
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// List domains for an environment<br/>
        /// Returns a paginated list of inbound-email domains in the current environment. Supports cursor pagination and a name contains filter.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerListDomainsResponse> ListAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.DomainsControllerListDomainsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? name = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List domains for an environment<br/>
        /// Returns a paginated list of inbound-email domains in the current environment. Supports cursor pagination and a name contains filter.
        /// </summary>
        /// <param name="after"></param>
        /// <param name="before"></param>
        /// <param name="limit"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeCursor"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerListDomainsResponse>> ListAsResponseAsync(
            string? after = default,
            string? before = default,
            double? limit = default,
            global::Novu.DomainsControllerListDomainsOrderDirection? orderDirection = default,
            string? orderBy = default,
            bool? includeCursor = default,
            string? name = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}