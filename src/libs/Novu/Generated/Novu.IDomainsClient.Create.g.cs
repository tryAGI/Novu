#nullable enable

namespace Novu
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Create a domain<br/>
        /// Registers a new inbound-email domain. The response includes the DNS records customers must add at their DNS provider before the domain can receive mail.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerCreateDomainResponse> CreateAsync(

            global::Novu.CreateDomainDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a domain<br/>
        /// Registers a new inbound-email domain. The response includes the DNS records customers must add at their DNS provider before the domain can receive mail.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerCreateDomainResponse>> CreateAsResponseAsync(

            global::Novu.CreateDomainDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a domain<br/>
        /// Registers a new inbound-email domain. The response includes the DNS records customers must add at their DNS provider before the domain can receive mail.
        /// </summary>
        /// <param name="name">
        /// The domain name (e.g. "recent.dev")
        /// </param>
        /// <param name="data">
        /// Optional string key-value metadata (max 10 keys, 500 characters total for keys+values).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerCreateDomainResponse> CreateAsync(
            string name,
            global::System.Collections.Generic.Dictionary<string, string>? data = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}