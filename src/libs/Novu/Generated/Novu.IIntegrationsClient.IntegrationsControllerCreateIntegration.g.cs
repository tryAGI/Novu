#nullable enable

namespace Novu
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Create an integration<br/>
        /// Create an integration for the current environment the user is based on the API key provided. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerCreateIntegrationResponse> IntegrationsControllerCreateIntegrationAsync(

            global::Novu.CreateIntegrationRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an integration<br/>
        /// Create an integration for the current environment the user is based on the API key provided. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.IntegrationsControllerCreateIntegrationResponse>> IntegrationsControllerCreateIntegrationAsResponseAsync(

            global::Novu.CreateIntegrationRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an integration<br/>
        /// Create an integration for the current environment the user is based on the API key provided. <br/>
        ///     Each provider supports different credentials, check the provider documentation for more details.
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
        /// The channel type for the integration
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
        /// <param name="conditions">
        /// Conditions for the integration
        /// </param>
        /// <param name="configurations">
        /// Configurations for the integration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.IntegrationsControllerCreateIntegrationResponse> IntegrationsControllerCreateIntegrationAsync(
            string providerId,
            global::Novu.CreateIntegrationRequestDtoChannel channel,
            string? name = default,
            string? identifier = default,
            global::System.Guid? environmentId = default,
            global::Novu.CredentialsDto? credentials = default,
            bool? active = default,
            bool? check = default,
            global::System.Collections.Generic.IList<global::Novu.StepFilterDto>? conditions = default,
            object? configurations = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}