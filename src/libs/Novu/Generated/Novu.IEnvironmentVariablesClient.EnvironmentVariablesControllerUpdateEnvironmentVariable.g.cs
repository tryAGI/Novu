#nullable enable

namespace Novu
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Update a variable<br/>
        /// Updates an existing environment variable. Providing values replaces all existing per-environment values.
        /// </summary>
        /// <param name="variableKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse> EnvironmentVariablesControllerUpdateEnvironmentVariableAsync(
            string variableKey,

            global::Novu.UpdateEnvironmentVariableRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a variable<br/>
        /// Updates an existing environment variable. Providing values replaces all existing per-environment values.
        /// </summary>
        /// <param name="variableKey"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse>> EnvironmentVariablesControllerUpdateEnvironmentVariableAsResponseAsync(
            string variableKey,

            global::Novu.UpdateEnvironmentVariableRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a variable<br/>
        /// Updates an existing environment variable. Providing values replaces all existing per-environment values.
        /// </summary>
        /// <param name="variableKey"></param>
        /// <param name="key">
        /// Unique key for the variable. Must start with a letter and contain only letters, digits, and underscores.
        /// </param>
        /// <param name="type">
        /// The type of the variable
        /// </param>
        /// <param name="isSecret"></param>
        /// <param name="values"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentVariablesControllerUpdateEnvironmentVariableResponse> EnvironmentVariablesControllerUpdateEnvironmentVariableAsync(
            string variableKey,
            string? key = default,
            global::Novu.UpdateEnvironmentVariableRequestDtoType? type = default,
            bool? isSecret = default,
            global::System.Collections.Generic.IList<global::Novu.EnvironmentVariableValueDto>? values = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}