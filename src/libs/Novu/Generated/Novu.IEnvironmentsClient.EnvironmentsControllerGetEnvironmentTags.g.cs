#nullable enable

namespace Novu
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// List environment tags<br/>
        /// Retrieve all unique tags used in workflows within the specified environment. These tags can be used for filtering workflows.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse> EnvironmentsControllerGetEnvironmentTagsAsync(
            string environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List environment tags<br/>
        /// Retrieve all unique tags used in workflows within the specified environment. These tags can be used for filtering workflows.
        /// </summary>
        /// <param name="environmentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentsControllerGetEnvironmentTagsResponse>> EnvironmentsControllerGetEnvironmentTagsAsResponseAsync(
            string environmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}