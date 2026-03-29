#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Update a workflow<br/>
        /// Partially updates a workflow by its unique identifier **workflowId**
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerPatchWorkflowResponse> WorkflowControllerPatchWorkflowAsync(
            string workflowId,

            global::Novu.PatchWorkflowDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a workflow<br/>
        /// Partially updates a workflow by its unique identifier **workflowId**
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="active">
        /// Activate or deactivate the workflow
        /// </param>
        /// <param name="name">
        /// New name for the workflow
        /// </param>
        /// <param name="description">
        /// Updated description of the workflow
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow
        /// </param>
        /// <param name="payloadSchema">
        /// The payload JSON Schema for the workflow
        /// </param>
        /// <param name="validatePayload">
        /// Enable or disable payload schema validation
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this workflow
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerPatchWorkflowResponse> WorkflowControllerPatchWorkflowAsync(
            string workflowId,
            bool? active = default,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            object? payloadSchema = default,
            bool? validatePayload = default,
            bool? isTranslationEnabled = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}