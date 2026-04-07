#nullable enable

namespace Novu
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Retrieve a variable<br/>
        /// Returns a single environment variable by id. Secret values are masked.
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse> EnvironmentVariablesControllerGetEnvironmentVariableAsync(
            string variableId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a variable<br/>
        /// Returns a single environment variable by id. Secret values are masked.
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableResponse>> EnvironmentVariablesControllerGetEnvironmentVariableAsResponseAsync(
            string variableId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}