#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List all integrations<br/>
        /// List all the channels integrations created in the organization
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>> IntegrationsControllerListIntegrationsAsync(
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all integrations<br/>
        /// List all the channels integrations created in the organization
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>>> IntegrationsControllerListIntegrationsAsResponseAsync(
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}