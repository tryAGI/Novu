#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// List all workflows<br/>
        /// Retrieves a list of workflows with optional filtering and pagination
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="query"></param>
        /// <param name="tags"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerSearchWorkflowsResponse> ListAsync(
            double? limit = default,
            double? offset = default,
            global::Novu.DirectionEnum? orderDirection = default,
            global::Novu.WorkflowResponseDtoSortField? orderBy = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? status = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all workflows<br/>
        /// Retrieves a list of workflows with optional filtering and pagination
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="orderDirection"></param>
        /// <param name="orderBy"></param>
        /// <param name="query"></param>
        /// <param name="tags"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.WorkflowControllerSearchWorkflowsResponse>> ListAsResponseAsync(
            double? limit = default,
            double? offset = default,
            global::Novu.DirectionEnum? orderDirection = default,
            global::Novu.WorkflowResponseDtoSortField? orderBy = default,
            string? query = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<global::Novu.WorkflowStatusEnum>? status = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}