#nullable enable

namespace Novu
{
    public partial interface IEnvironmentsClient
    {
        /// <summary>
        /// Publish resources to target environment<br/>
        /// Publishes all workflows and resources from the development environment to the target environment. Optionally specify specific resources to publish or use dryRun mode to preview changes.
        /// </summary>
        /// <param name="targetEnvironmentId">
        /// Example: 6615943e7ace93b0540ae377
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerPublishEnvironmentResponse> PublishAsync(
            string targetEnvironmentId,

            global::Novu.PublishEnvironmentRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish resources to target environment<br/>
        /// Publishes all workflows and resources from the development environment to the target environment. Optionally specify specific resources to publish or use dryRun mode to preview changes.
        /// </summary>
        /// <param name="targetEnvironmentId">
        /// Example: 6615943e7ace93b0540ae377
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.EnvironmentsControllerPublishEnvironmentResponse>> PublishAsResponseAsync(
            string targetEnvironmentId,

            global::Novu.PublishEnvironmentRequestDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish resources to target environment<br/>
        /// Publishes all workflows and resources from the development environment to the target environment. Optionally specify specific resources to publish or use dryRun mode to preview changes.
        /// </summary>
        /// <param name="targetEnvironmentId">
        /// Example: 6615943e7ace93b0540ae377
        /// </param>
        /// <param name="sourceEnvironmentId">
        /// Source environment ID. Only the Development environment is currently supported; defaults to Development if omitted.<br/>
        /// Example: 507f1f77bcf86cd799439011
        /// </param>
        /// <param name="dryRun">
        /// Perform a dry run without making actual changes<br/>
        /// Default Value: false
        /// </param>
        /// <param name="resources">
        /// Array of specific resources to publish. If not provided, all resources will be published.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.EnvironmentsControllerPublishEnvironmentResponse> PublishAsync(
            string targetEnvironmentId,
            string? sourceEnvironmentId = default,
            bool? dryRun = default,
            global::System.Collections.Generic.IList<global::Novu.ResourceToPublishDto>? resources = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}