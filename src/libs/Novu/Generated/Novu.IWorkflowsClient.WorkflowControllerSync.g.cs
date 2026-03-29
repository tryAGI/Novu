#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Sync a workflow<br/>
        /// Synchronizes a workflow to the target environment
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerSyncResponse> WorkflowControllerSyncAsync(
            string workflowId,

            global::Novu.SyncWorkflowDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync a workflow<br/>
        /// Synchronizes a workflow to the target environment
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="targetEnvironmentId">
        /// Target environment identifier to sync the workflow to
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerSyncResponse> WorkflowControllerSyncAsync(
            string workflowId,
            string targetEnvironmentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}