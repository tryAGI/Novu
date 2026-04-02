#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Retrieve workflow step<br/>
        /// Retrieves data for a specific step in a workflow
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="stepId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerGetWorkflowStepDataResponse> WorkflowControllerGetWorkflowStepDataAsync(
            string workflowId,
            string stepId,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve workflow step<br/>
        /// Retrieves data for a specific step in a workflow
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="stepId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.WorkflowControllerGetWorkflowStepDataResponse>> WorkflowControllerGetWorkflowStepDataAsResponseAsync(
            string workflowId,
            string stepId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}