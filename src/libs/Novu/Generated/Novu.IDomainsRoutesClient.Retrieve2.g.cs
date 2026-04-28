#nullable enable

namespace Novu
{
    public partial interface IDomainsRoutesClient
    {
        /// <summary>
        /// Retrieve a route by address<br/>
        /// Returns the route bound to `&lt;address&gt;@&lt;domain&gt;`. Use `*` as the address to retrieve the wildcard route for the domain.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerGetDomainRouteResponse> Retrieve2Async(
            string domain,
            string address,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a route by address<br/>
        /// Returns the route bound to `&lt;address&gt;@&lt;domain&gt;`. Use `*` as the address to retrieve the wildcard route for the domain.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerGetDomainRouteResponse>> Retrieve2AsResponseAsync(
            string domain,
            string address,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}