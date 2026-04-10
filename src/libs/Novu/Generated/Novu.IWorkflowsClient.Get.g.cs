#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Retrieve a workflow<br/>
        /// Fetches details of a specific workflow by its unique identifier **workflowId**
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="environmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerGetWorkflowResponse> GetAsync(
            string workflowId,
            string? environmentId = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a workflow<br/>
        /// Fetches details of a specific workflow by its unique identifier **workflowId**
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="environmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.WorkflowControllerGetWorkflowResponse>> GetAsResponseAsync(
            string workflowId,
            string? environmentId = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}