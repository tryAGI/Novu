#nullable enable

namespace Novu
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Create an environment<br/>
        /// Creates a new environment within the current organization. <br/>
        ///     Environments allow you to manage different stages of your application development lifecycle.<br/>
        ///     Each environment has its own set of API keys and configurations.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse> EnvironmentsControllerV1CreateEnvironmentAsync(

            global::Novu.CreateEnvironmentRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an environment<br/>
        /// Creates a new environment within the current organization. <br/>
        ///     Environments allow you to manage different stages of your application development lifecycle.<br/>
        ///     Each environment has its own set of API keys and configurations.
        /// </summary>
        /// <param name="name">
        /// Name of the environment to be created<br/>
        /// Example: Production Environment
        /// </param>
        /// <param name="parentId">
        /// MongoDB ObjectId of the parent environment (optional)<br/>
        /// Example: 60d5ecb8b3b3a30015f3e1a1
        /// </param>
        /// <param name="color">
        /// Hex color code for the environment<br/>
        /// Example: #3498db
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerV1CreateEnvironmentResponse> EnvironmentsControllerV1CreateEnvironmentAsync(
            string name,
            string color,
            string? parentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}