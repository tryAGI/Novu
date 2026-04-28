#nullable enable

namespace Novu
{
    public partial interface IDomainsClient
    {
        /// <summary>
        /// Retrieve a domain by name<br/>
        /// Returns the domain configuration and the DNS records that must be in place. This is a pure read; call `domains.verify` to refresh verification status from DNS.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerGetDomainResponse> RetrieveAsync(
            string domain,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a domain by name<br/>
        /// Returns the domain configuration and the DNS records that must be in place. This is a pure read; call `domains.verify` to refresh verification status from DNS.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerGetDomainResponse>> RetrieveAsResponseAsync(
            string domain,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}