#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update integration as primary<br/>
        /// Update an integration as **primary** by its unique key identifier **integrationId**. <br/>
        ///     This API will set the integration as primary for that channel in the current environment. <br/>
        ///     Primary integration is used to deliver notification for sms and email channels in the workflow.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerSetIntegrationAsPrimaryResponse> IntegrationsControllerSetIntegrationAsPrimaryAsync(
            string integrationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}