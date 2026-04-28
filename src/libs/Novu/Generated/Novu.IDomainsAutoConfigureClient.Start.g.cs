#nullable enable

namespace Novu
{
    public partial interface IDomainsAutoConfigureClient
    {
        /// <summary>
        /// Start DNS auto-configuration<br/>
        /// Generates a signed redirect URL the customer can follow to apply Novu DNS records at their DNS provider. After the provider completes the flow, it redirects back to `redirectUri`.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerStartDomainAutoConfigureResponse> StartAsync(
            string domain,

            global::Novu.CreateDomainConnectApplyUrlDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start DNS auto-configuration<br/>
        /// Generates a signed redirect URL the customer can follow to apply Novu DNS records at their DNS provider. After the provider completes the flow, it redirects back to `redirectUri`.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerStartDomainAutoConfigureResponse>> StartAsResponseAsync(
            string domain,

            global::Novu.CreateDomainConnectApplyUrlDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Start DNS auto-configuration<br/>
        /// Generates a signed redirect URL the customer can follow to apply Novu DNS records at their DNS provider. After the provider completes the flow, it redirects back to `redirectUri`.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="redirectUri">
        /// Dashboard URL to return to after the DNS provider consent flow completes.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerStartDomainAutoConfigureResponse> StartAsync(
            string domain,
            string? redirectUri = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}