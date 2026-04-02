#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Delete an integration<br/>
        /// Delete an integration by its unique key identifier **integrationId**. <br/>
        ///     This action is irreversible.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerRemoveIntegrationResponse> IntegrationsControllerRemoveIntegrationAsync(
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an integration<br/>
        /// Delete an integration by its unique key identifier **integrationId**. <br/>
        ///     This action is irreversible.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerRemoveIntegrationResponse>> IntegrationsControllerRemoveIntegrationAsResponseAsync(
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}