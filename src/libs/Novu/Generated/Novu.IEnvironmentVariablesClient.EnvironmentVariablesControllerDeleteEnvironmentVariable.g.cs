#nullable enable

namespace Novu
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// Delete a variable<br/>
        /// Deletes an environment variable by id.
        /// </summary>
        /// <param name="variableId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task EnvironmentVariablesControllerDeleteEnvironmentVariableAsync(
            string variableId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}