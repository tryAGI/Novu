#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update an integration<br/>
        /// Update an integration by its unique key identifier **integrationId**. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse> IntegrationsControllerUpdateIntegrationByIdAsync(
            string integrationId,

            global::Novu.UpdateIntegrationRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an integration<br/>
        /// Update an integration by its unique key identifier **integrationId**. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse>> IntegrationsControllerUpdateIntegrationByIdAsResponseAsync(
            string integrationId,

            global::Novu.UpdateIntegrationRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an integration<br/>
        /// Update an integration by its unique key identifier **integrationId**. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="name"></param>
        /// <param name="identifier"></param>
        /// <param name="environmentId"></param>
        /// <param name="active">
        /// If the integration is active the validation on the credentials field will run
        /// </param>
        /// <param name="credentials"></param>
        /// <param name="check"></param>
        /// <param name="conditions"></param>
        /// <param name="configurations">
        /// Configurations for the integration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse> IntegrationsControllerUpdateIntegrationByIdAsync(
            string integrationId,
            string? name = default,
            string? identifier = default,
            string? environmentId = default,
            bool? active = default,
            global::Novu.CredentialsDto? credentials = default,
            bool? check = default,
            global::System.Collections.Generic.IList<global::Novu.StepFilterDto>? conditions = default,
            object? configurations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}