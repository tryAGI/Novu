#nullable enable

namespace Novu
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Create a variable<br/>
        /// Creates a new environment variable. Keys must be uppercase with underscores only (e.g. BASE_URL). Secret variables are encrypted at rest and masked in API responses.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse> EnvironmentVariablesControllerCreateEnvironmentVariableAsync(

            global::Novu.CreateEnvironmentVariableRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a variable<br/>
        /// Creates a new environment variable. Keys must be uppercase with underscores only (e.g. BASE_URL). Secret variables are encrypted at rest and masked in API responses.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse>> EnvironmentVariablesControllerCreateEnvironmentVariableAsResponseAsync(

            global::Novu.CreateEnvironmentVariableRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a variable<br/>
        /// Creates a new environment variable. Keys must be uppercase with underscores only (e.g. BASE_URL). Secret variables are encrypted at rest and masked in API responses.
        /// </summary>
        /// <param name="key">
        /// Unique key for the variable. Must start with a letter and contain only letters, digits, and underscores.
        /// </param>
        /// <param name="type">
        /// The type of the variable
        /// </param>
        /// <param name="isSecret">
        /// Whether this variable is a secret (encrypted at rest, masked in responses)
        /// </param>
        /// <param name="values"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentVariablesControllerCreateEnvironmentVariableResponse> EnvironmentVariablesControllerCreateEnvironmentVariableAsync(
            string key,
            global::Novu.CreateEnvironmentVariableRequestDtoType? type = default,
            bool? isSecret = default,
            global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? values = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}