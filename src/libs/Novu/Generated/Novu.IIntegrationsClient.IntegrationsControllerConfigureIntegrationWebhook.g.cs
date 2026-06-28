#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Configure a chat integration webhook<br/>
        /// Registers the Novu webhook URL with the chat provider for the specified integration. Telegram is the only supported provider initially.
        /// </summary>
        /// <param name="integrationIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerConfigureIntegrationWebhookResponse> IntegrationsControllerConfigureIntegrationWebhookAsync(
            string integrationIdentifier,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure a chat integration webhook<br/>
        /// Registers the Novu webhook URL with the chat provider for the specified integration. Telegram is the only supported provider initially.
        /// </summary>
        /// <param name="integrationIdentifier"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerConfigureIntegrationWebhookResponse>> IntegrationsControllerConfigureIntegrationWebhookAsResponseAsync(
            string integrationIdentifier,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}