#nullable enable

namespace Novu
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Compare resources between environments<br/>
        /// Compares workflows and other resources between the source and target environments, returning detailed diff information including additions, modifications, and deletions.
        /// </summary>
        /// <param name="targetEnvironmentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerDiffEnvironmentResponse> EnvironmentsControllerDiffEnvironmentAsync(
            string targetEnvironmentId,

            global::Novu.DiffEnvironmentRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compare resources between environments<br/>
        /// Compares workflows and other resources between the source and target environments, returning detailed diff information including additions, modifications, and deletions.
        /// </summary>
        /// <param name="targetEnvironmentId"></param>
        /// <param name="sourceEnvironmentId">
        /// Source environment ID to compare from. Defaults to the Development environment if not provided.<br/>
        /// Example: 507f1f77bcf86cd799439011
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerDiffEnvironmentResponse> EnvironmentsControllerDiffEnvironmentAsync(
            string targetEnvironmentId,
            string? sourceEnvironmentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}