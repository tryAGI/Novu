#nullable enable

namespace Novu
{
    public partial interface IDomainsRoutesClient
    {
        /// <summary>
        /// Create a route<br/>
        /// Creates a route on the domain that forwards inbound mail addressed to `&lt;address&gt;@&lt;domain&gt;` to either a webhook or an agent. Each address on a domain may only have a single route.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerCreateDomainRouteResponse> Create2Async(
            string domain,

            global::Novu.DomainRouteDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a route<br/>
        /// Creates a route on the domain that forwards inbound mail addressed to `&lt;address&gt;@&lt;domain&gt;` to either a webhook or an agent. Each address on a domain may only have a single route.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerCreateDomainRouteResponse>> Create2AsResponseAsync(
            string domain,

            global::Novu.DomainRouteDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a route<br/>
        /// Creates a route on the domain that forwards inbound mail addressed to `&lt;address&gt;@&lt;domain&gt;` to either a webhook or an agent. Each address on a domain may only have a single route.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address">
        /// Inbox address local part (e.g. "support", "*")
        /// </param>
        /// <param name="agentId">
        /// Agent identifier; required when type is agent, unused for webhook
        /// </param>
        /// <param name="type"></param>
        /// <param name="data">
        /// Optional string key-value metadata (max 10 keys, 500 characters total for keys+values).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerCreateDomainRouteResponse> Create2Async(
            string domain,
            string address,
            global::Novu.DomainRouteDtoType type,
            string? agentId = default,
            global::System.Collections.Generic.Dictionary<string, string>? data = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}