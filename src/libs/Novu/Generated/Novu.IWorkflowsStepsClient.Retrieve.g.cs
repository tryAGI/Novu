#nullable enable

namespace Novu
{
    public partial interface IWorkflowsStepsClient
    {
        /// <summary>
        /// Retrieve workflow step<br/>
        /// Retrieves data for a specific step in a workflow
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="stepId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerGetWorkflowStepDataResponse> RetrieveAsync(
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
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.WorkflowControllerGetWorkflowStepDataResponse>> RetrieveAsResponseAsync(
            string workflowId,
            string stepId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}