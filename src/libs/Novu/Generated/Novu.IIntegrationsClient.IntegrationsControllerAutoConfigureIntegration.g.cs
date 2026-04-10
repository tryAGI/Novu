#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Auto-configure an integration for inbound webhooks<br/>
        /// Auto-configure an integration by its unique key identifier **integrationId** for inbound webhook support. <br/>
        ///     This will automatically generate required webhook signing keys and configure webhook endpoints.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse> IntegrationsControllerAutoConfigureIntegrationAsync(
            string integrationId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Auto-configure an integration for inbound webhooks<br/>
        /// Auto-configure an integration by its unique key identifier **integrationId** for inbound webhook support. <br/>
        ///     This will automatically generate required webhook signing keys and configure webhook endpoints.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerAutoConfigureIntegrationResponse>> IntegrationsControllerAutoConfigureIntegrationAsResponseAsync(
            string integrationId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}