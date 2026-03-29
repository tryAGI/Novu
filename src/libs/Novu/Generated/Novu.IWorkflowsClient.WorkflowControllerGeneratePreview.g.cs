#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Generate step preview<br/>
        /// Generates a preview for a specific workflow step by its unique identifier **stepId**
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="stepId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerGeneratePreviewResponse> WorkflowControllerGeneratePreviewAsync(
            string workflowId,
            string stepId,

            global::Novu.GeneratePreviewRequestDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate step preview<br/>
        /// Generates a preview for a specific workflow step by its unique identifier **stepId**
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="stepId"></param>
        /// <param name="controlValues">
        /// Optional control values
        /// </param>
        /// <param name="previewPayload">
        /// Optional payload for preview generation
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerGeneratePreviewResponse> WorkflowControllerGeneratePreviewAsync(
            string workflowId,
            string stepId,
            object? controlValues = default,
            global::Novu.PreviewPayloadDto? previewPayload = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}