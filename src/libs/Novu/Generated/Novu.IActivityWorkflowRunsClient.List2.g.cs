#nullable enable

namespace Novu
{
    public partial interface IActivityWorkflowRunsClient
    {
        /// <summary>
        /// List workflow runs<br/>
        /// Retrieve a list of workflow runs with optional filtering and pagination.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="workflowIds"></param>
        /// <param name="subscriberIds"></param>
        /// <param name="transactionIds"></param>
        /// <param name="statuses"></param>
        /// <param name="channels"></param>
        /// <param name="topicKey"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="createdGte"></param>
        /// <param name="createdLte"></param>
        /// <param name="severity"></param>
        /// <param name="contextKeys"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.GetWorkflowRunsResponseDto> List2Async(
            double limit,
            string? cursor = default,
            global::System.Collections.Generic.IList<string>? workflowIds = default,
            global::System.Collections.Generic.IList<string>? subscriberIds = default,
            global::System.Collections.Generic.IList<string>? transactionIds = default,
            global::System.Collections.Generic.IList<global::Novu.ActivityControllerGetWorkflowRunsStatuse>? statuses = default,
            global::System.Collections.Generic.IList<string>? channels = default,
            string? topicKey = default,
            string? subscriptionId = default,
            string? createdGte = default,
            string? createdLte = default,
            global::System.Collections.Generic.IList<global::Novu.ActivityControllerGetWorkflowRunsSeverityItem>? severity = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workflow runs<br/>
        /// Retrieve a list of workflow runs with optional filtering and pagination.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="workflowIds"></param>
        /// <param name="subscriberIds"></param>
        /// <param name="transactionIds"></param>
        /// <param name="statuses"></param>
        /// <param name="channels"></param>
        /// <param name="topicKey"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="createdGte"></param>
        /// <param name="createdLte"></param>
        /// <param name="severity"></param>
        /// <param name="contextKeys"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.GetWorkflowRunsResponseDto>> List2AsResponseAsync(
            double limit,
            string? cursor = default,
            global::System.Collections.Generic.IList<string>? workflowIds = default,
            global::System.Collections.Generic.IList<string>? subscriberIds = default,
            global::System.Collections.Generic.IList<string>? transactionIds = default,
            global::System.Collections.Generic.IList<global::Novu.ActivityControllerGetWorkflowRunsStatuse>? statuses = default,
            global::System.Collections.Generic.IList<string>? channels = default,
            string? topicKey = default,
            string? subscriptionId = default,
            string? createdGte = default,
            string? createdLte = default,
            global::System.Collections.Generic.IList<global::Novu.ActivityControllerGetWorkflowRunsSeverityItem>? severity = default,
            global::System.Collections.Generic.IList<string>? contextKeys = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}