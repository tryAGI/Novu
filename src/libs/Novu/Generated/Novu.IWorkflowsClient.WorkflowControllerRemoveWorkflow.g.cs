#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Delete a workflow<br/>
        /// Removes a specific workflow by its unique identifier **workflowId**
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task WorkflowControllerRemoveWorkflowAsync(
            string workflowId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}