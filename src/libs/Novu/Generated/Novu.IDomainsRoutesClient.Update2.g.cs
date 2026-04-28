#nullable enable

namespace Novu
{
    public partial interface IDomainsRoutesClient
    {
        /// <summary>
        /// Update a route<br/>
        /// Updates the destination of the route bound to `&lt;address&gt;@&lt;domain&gt;`. The address itself is the resource identity and cannot be changed; delete and recreate the route to rename it.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerUpdateDomainRouteResponse> Update2Async(
            string domain,
            string address,

            global::Novu.UpdateDomainRouteDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a route<br/>
        /// Updates the destination of the route bound to `&lt;address&gt;@&lt;domain&gt;`. The address itself is the resource identity and cannot be changed; delete and recreate the route to rename it.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerUpdateDomainRouteResponse>> Update2AsResponseAsync(
            string domain,
            string address,

            global::Novu.UpdateDomainRouteDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a route<br/>
        /// Updates the destination of the route bound to `&lt;address&gt;@&lt;domain&gt;`. The address itself is the resource identity and cannot be changed; delete and recreate the route to rename it.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="agentId">
        /// Agent identifier; required when type is agent, ignored when type is webhook.
        /// </param>
        /// <param name="type"></param>
        /// <param name="data">
        /// Replaces route metadata when provided (max 10 keys, 500 characters total for keys+values).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerUpdateDomainRouteResponse> Update2Async(
            string domain,
            string address,
            string? agentId = default,
            global::Novu.UpdateDomainRouteDtoType? type = default,
            global::System.Collections.Generic.Dictionary<string, string>? data = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}