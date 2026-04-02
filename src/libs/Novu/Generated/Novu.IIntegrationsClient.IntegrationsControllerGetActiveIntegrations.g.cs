#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List active integrations<br/>
        /// List all the active integrations created in the organization
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>> IntegrationsControllerGetActiveIntegrationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List active integrations<br/>
        /// List all the active integrations created in the organization
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>>> IntegrationsControllerGetActiveIntegrationsAsResponseAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}