#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update an integration<br/>
        /// Update an integration by its unique key identifier **integrationId**. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details. Only integration metadata is returned, credentials field is returned as an empty object.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse> IntegrationsControllerUpdateIntegrationByIdAsync(
            string integrationId,

            global::Novu.UpdateIntegrationRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an integration<br/>
        /// Update an integration by its unique key identifier **integrationId**. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details. Only integration metadata is returned, credentials field is returned as an empty object.
        /// </summary>
        /// <param name="integrationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerUpdateIntegrationByIdResponse>> IntegrationsControllerUpdateIntegrationByIdAsResponseAsync(
            string integrationId,

            global::Novu.UpdateIntegrationRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an integration<br/>
        /// Update an integration by its unique key identifier **integrationId**. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details. Only integration metadata is returned, credentials field is returned as an empty object.
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
        /// <param name="rules">
        /// JSONLogic used at send time to select this integration. Takes precedence over `conditions`.<br/>
        /// Example: {"==":[{"var":"context.tenant.id"},"acme"]}
        /// </param>
        /// <param name="configurations">
        /// Configurations for the integration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            object? rules = default,
            object? configurations = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}