#nullable enable

namespace Novu
{
    public partial interface IWorkflowsClient
    {
        /// <summary>
        /// Create a workflow<br/>
        /// Creates a new workflow in the Novu Cloud environment
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Novu.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerCreateResponse> WorkflowControllerCreateAsync(

            global::Novu.CreateWorkflowDto request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a workflow<br/>
        /// Creates a new workflow in the Novu Cloud environment
        /// </summary>
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
        /// <param name="workflowId">
        /// Unique identifier for the workflow
        /// </param>
        /// <param name="steps">
        /// Steps of the workflow
        /// </param>
        /// <param name="source">
        /// Source of workflow creation<br/>
        /// Default Value: editor
        /// </param>
        /// <param name="preferences">
        /// Workflow preferences
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Novu.WorkflowControllerCreateResponse> WorkflowControllerCreateAsync(
            string name,
            string workflowId,
            global::System.Collections.Generic.IList<global::Novu.StepsItem2> steps,
            string? description = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            bool? active = default,
            bool? validatePayload = default,
            object? payloadSchema = default,
            bool? isTranslationEnabled = default,
            global::Novu.WorkflowCreationSourceEnum? source = default,
            global::Novu.PreferencesRequestDto? preferences = default,
            global::Novu.SeverityLevelEnum? severity = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}