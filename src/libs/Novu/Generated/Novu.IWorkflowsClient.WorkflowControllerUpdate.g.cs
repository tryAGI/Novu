#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Update a workflow<br/>
        /// Updates the details of an existing workflow, here **workflowId** is the identifier of the workflow
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerUpdateResponse> WorkflowControllerUpdateAsync(
            string workflowId,

            global::Novu.UpdateWorkflowDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a workflow<br/>
        /// Updates the details of an existing workflow, here **workflowId** is the identifier of the workflow
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.AutoSDKHttpResponse<global::Novu.WorkflowControllerUpdateResponse>> WorkflowControllerUpdateAsResponseAsync(
            string workflowId,

            global::Novu.UpdateWorkflowDto request,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a workflow<br/>
        /// Updates the details of an existing workflow, here **workflowId** is the identifier of the workflow
        /// </summary>
        /// <param name="workflowId"></param>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="description">
        /// Description of the workflow
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow
        /// </param>
        /// <param name="active">
        /// Whether the workflow is active<br/>
        /// Default Value: false
        /// </param>
        /// <param name="validatePayload">
        /// Enable or disable payload schema validation
        /// </param>
        /// <param name="payloadSchema">
        /// The payload JSON Schema for the workflow
        /// </param>
        /// <param name="isTranslationEnabled">
        /// Enable or disable translations for this workflow<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestWorkflowId">
        /// Workflow ID (allowed only for code-first workflows)
        /// </param>
        /// <param name="steps">
        /// Steps of the workflow
        /// </param>
        /// <param name="preferences">
        /// Workflow preferences
        /// </param>
        /// <param name="origin">
        /// Origin of the layout
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerUpdateResponse> WorkflowControllerUpdateAsync(
            string workflowId,
            string name,
            global::System.Collections.Generic.IList<global::Novu.StepsItem3> steps,
            global::Novu.PreferencesRequestDto preferences,
            global::Novu.ResourceOriginEnum origin,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? active = default,
            bool? validatePayload = default,
            object? payloadSchema = default,
            bool? isTranslationEnabled = default,
            string? requestWorkflowId = default,
            global::Novu.SeverityLevelEnum? severity = default,
            global::Novu.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}