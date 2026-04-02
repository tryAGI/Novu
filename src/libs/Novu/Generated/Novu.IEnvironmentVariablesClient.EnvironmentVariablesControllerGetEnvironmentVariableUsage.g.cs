#nullable enable

namespace Novu
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Get environment variable usage<br/>
        /// Returns the workflows that reference this environment variable via {{env.KEY}} in their step controls.
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse> EnvironmentVariablesControllerGetEnvironmentVariableUsageAsync(
            string variableId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get environment variable usage<br/>
        /// Returns the workflows that reference this environment variable via {{env.KEY}} in their step controls.
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentVariablesControllerGetEnvironmentVariableUsageResponse>> EnvironmentVariablesControllerGetEnvironmentVariableUsageAsResponseAsync(
            string variableId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}