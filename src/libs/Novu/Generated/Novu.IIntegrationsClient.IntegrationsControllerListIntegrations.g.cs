#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// List all integrations<br/>
        /// List all the channels integrations created in the organization
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Novu.IntegrationResponseDto>> IntegrationsControllerListIntegrationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}