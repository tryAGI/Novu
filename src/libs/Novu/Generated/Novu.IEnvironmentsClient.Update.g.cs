#nullable enable

namespace Novu
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Update an environment<br/>
        /// Update an environment by its unique identifier **environmentId**. <br/>
        ///     You can modify the environment name, identifier, color, and other configuration settings.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse> UpdateAsync(
            string environmentId,

            global::Novu.UpdateEnvironmentRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an environment<br/>
        /// Update an environment by its unique identifier **environmentId**. <br/>
        ///     You can modify the environment name, identifier, color, and other configuration settings.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse>> UpdateAsResponseAsync(
            string environmentId,

            global::Novu.UpdateEnvironmentRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an environment<br/>
        /// Update an environment by its unique identifier **environmentId**. <br/>
        ///     You can modify the environment name, identifier, color, and other configuration settings.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="name"></param>
        /// <param name="identifier"></param>
        /// <param name="parentId"></param>
        /// <param name="color"></param>
        /// <param name="dns"></param>
        /// <param name="bridge"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerV1UpdateMyEnvironmentResponse> UpdateAsync(
            string environmentId,
            string? name = default,
            string? identifier = default,
            string? parentId = default,
            string? color = default,
            global::Novu.InBoundParseDomainDto? dns = default,
            global::Novu.BridgeConfigurationDto? bridge = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}