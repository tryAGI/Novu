#nullable enable

namespace Novu
{
    public partial interface IDomainsRoutesClient
    {
        /// <summary>
        /// Test an inbound route<br/>
        /// Sends a synthetic inbound email through the same delivery path as production (outbound webhooks for webhook routes, signed HTTP to the agent for agent routes). Use `dryRun: true` to preview the payload without delivering.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerTestDomainRouteResponse> TestAsync(
            string domain,
            string address,

            global::Novu.TestDomainRouteDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test an inbound route<br/>
        /// Sends a synthetic inbound email through the same delivery path as production (outbound webhooks for webhook routes, signed HTTP to the agent for agent routes). Use `dryRun: true` to preview the payload without delivering.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.DomainsControllerTestDomainRouteResponse>> TestAsResponseAsync(
            string domain,
            string address,

            global::Novu.TestDomainRouteDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test an inbound route<br/>
        /// Sends a synthetic inbound email through the same delivery path as production (outbound webhooks for webhook routes, signed HTTP to the agent for agent routes). Use `dryRun: true` to preview the payload without delivering.
        /// </summary>
        /// <param name="domain"></param>
        /// <param name="address"></param>
        /// <param name="from"></param>
        /// <param name="subject"></param>
        /// <param name="text"></param>
        /// <param name="html"></param>
        /// <param name="dryRun">
        /// When true, returns the payload that would be delivered without invoking outbound webhooks or the agent HTTP endpoint.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.DomainsControllerTestDomainRouteResponse> TestAsync(
            string domain,
            string address,
            global::Novu.TestDomainRouteFromDto from,
            string subject,
            string? text = default,
            string? html = default,
            bool? dryRun = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}