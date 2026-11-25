#nullable enable

namespace Novu
{
    public partial interface IActivityWorkflowRunsClient
    {
        /// <summary>
        /// Retrieve workflow run<br/>
        /// Retrieve detailed information for a specific workflow run by ID.
        /// </summary>
        /// <param name="workflowRunId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.ActivityControllerGetWorkflowRunResponse> Retrieve2Async(
            string workflowRunId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve workflow run<br/>
        /// Retrieve detailed information for a specific workflow run by ID.
        /// </summary>
        /// <param name="workflowRunId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.ActivityControllerGetWorkflowRunResponse>> Retrieve2AsResponseAsync(
            string workflowRunId,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}