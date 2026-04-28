#nullable enable

namespace Novu
{
    public partial interface IDomainsAutoConfigureClient
    {
        /// <summary>
        /// Retrieve auto-configuration availability<br/>
        /// Returns whether DNS auto-configuration (Domain Connect) is available for this domain. When `available` is `false`, `manualRecords` lists the DNS records the customer must add manually.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerGetDomainAutoConfigureResponse> Retrieve3Async(
            string domain,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve auto-configuration availability<br/>
        /// Returns whether DNS auto-configuration (Domain Connect) is available for this domain. When `available` is `false`, `manualRecords` lists the DNS records the customer must add manually.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerGetDomainAutoConfigureResponse>> Retrieve3AsResponseAsync(
            string domain,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}