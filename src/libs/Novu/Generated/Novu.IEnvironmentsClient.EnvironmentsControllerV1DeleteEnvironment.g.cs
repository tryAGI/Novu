#nullable enable

namespace Novu
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Delete an environment<br/>
        /// Delete an environment by its unique identifier **environmentId**. <br/>
        ///     This action is irreversible and will remove the environment and all its associated data.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task EnvironmentsControllerV1DeleteEnvironmentAsync(
            string environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}