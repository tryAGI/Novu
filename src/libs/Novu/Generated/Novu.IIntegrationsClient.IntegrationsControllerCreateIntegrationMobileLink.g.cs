#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Issue a short-lived mobile setup link for an existing integration<br/>
        /// Returns an opaque, single-use setup token plus a mobile URL for configuring an existing chat integration. Telegram is the only supported provider initially.
        /// </summary>
        /// <param name="integrationIdentifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse> IntegrationsControllerCreateIntegrationMobileLinkAsync(
            string integrationIdentifier,

            global::Novu.IssueIntegrationMobileLinkRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Issue a short-lived mobile setup link for an existing integration<br/>
        /// Returns an opaque, single-use setup token plus a mobile URL for configuring an existing chat integration. Telegram is the only supported provider initially.
        /// </summary>
        /// <param name="integrationIdentifier"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse>> IntegrationsControllerCreateIntegrationMobileLinkAsResponseAsync(
            string integrationIdentifier,

            global::Novu.IssueIntegrationMobileLinkRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Issue a short-lived mobile setup link for an existing integration<br/>
        /// Returns an opaque, single-use setup token plus a mobile URL for configuring an existing chat integration. Telegram is the only supported provider initially.
        /// </summary>
        /// <param name="integrationIdentifier"></param>
        /// <param name="subscriberId">
        /// Optional subscriber to link via `/start` deep link after mobile setup completes. When provided, the consume response may include a ready-to-open Telegram deep link.<br/>
        /// Example: subscriber-123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerCreateIntegrationMobileLinkResponse> IntegrationsControllerCreateIntegrationMobileLinkAsync(
            string integrationIdentifier,
            string? subscriberId = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}