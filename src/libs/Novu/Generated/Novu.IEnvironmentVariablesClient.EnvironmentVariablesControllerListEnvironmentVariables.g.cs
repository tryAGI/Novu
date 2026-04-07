#nullable enable

namespace Novu
{
    public partial interface IEnvironmentVariablesClient
    {
        /// <summary>
        /// List all variables<br/>
        /// Returns all environment variables for the current organization. Secret values are masked.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse> EnvironmentVariablesControllerListEnvironmentVariablesAsync(
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all variables<br/>
        /// Returns all environment variables for the current organization. Secret values are masked.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentVariablesControllerListEnvironmentVariablesResponse>> EnvironmentVariablesControllerListEnvironmentVariablesAsResponseAsync(
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}