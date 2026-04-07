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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task EnvironmentVariablesControllerDeleteEnvironmentVariableAsync(
            string variableId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}