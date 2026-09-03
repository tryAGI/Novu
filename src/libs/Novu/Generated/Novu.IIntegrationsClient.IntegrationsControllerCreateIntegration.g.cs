#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Create an integration<br/>
        /// Create an integration for the current environment the user is based on the API key provided. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details. Only integration metadata is returned, credentials field is returned as an empty object.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerCreateIntegrationResponse> IntegrationsControllerCreateIntegrationAsync(

            global::Novu.CreateIntegrationRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an integration<br/>
        /// Create an integration for the current environment the user is based on the API key provided. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details. Only integration metadata is returned, credentials field is returned as an empty object.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerCreateIntegrationResponse>> IntegrationsControllerCreateIntegrationAsResponseAsync(

            global::Novu.CreateIntegrationRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an integration<br/>
        /// Create an integration for the current environment the user is based on the API key provided. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details. Only integration metadata is returned, credentials field is returned as an empty object.
        /// </summary>
        /// <param name="name">
        /// The name of the integration
        /// </param>
        /// <param name="identifier">
        /// The unique identifier for the integration
        /// </param>
        /// <param name="environmentId">
        /// The ID of the associated environment
        /// </param>
        /// <param name="providerId">
        /// The provider ID for the integration
        /// </param>
        /// <param name="channel">
        /// The channel type for the integration. Not required for agent-kind integrations.
        /// </param>
        /// <param name="kind">
        /// Distinguishes delivery integrations from agent-runtime integrations. Defaults to "delivery". Agent integrations do not require a channel.
        /// </param>
        /// <param name="credentials">
        /// The credentials for the integration
        /// </param>
        /// <param name="active">
        /// If the integration is active, the validation on the credentials field will run
        /// </param>
        /// <param name="check">
        /// Flag to check the integration status
        /// </param>
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
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerCreateIntegrationResponse> IntegrationsControllerCreateIntegrationAsync(
            string? name = default,
            string? identifier = default,
            global::System.Guid? environmentId = default,
            string? providerId = default,
            global::Novu.CreateIntegrationRequestDtoChannel? channel = default,
            global::Novu.CreateIntegrationRequestDtoKind? kind = default,
            global::Novu.CredentialsDto? credentials = default,
            bool? active = default,
            bool? check = default,
            object? rules = default,
            object? configurations = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}