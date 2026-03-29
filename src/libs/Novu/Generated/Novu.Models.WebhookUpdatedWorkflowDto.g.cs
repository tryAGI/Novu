
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookUpdatedWorkflowDto
    {
        /// <summary>
        /// Current workflow state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowResponseDto Object { get; set; }

        /// <summary>
        /// Previous state of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousObject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowResponseDto PreviousObject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdatedWorkflowDto" /> class.
        /// </summary>
        /// <param name="object">
        /// Current workflow state
        /// </param>
        /// <param name="previousObject">
        /// Previous state of the workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookUpdatedWorkflowDto(
            global::Novu.WorkflowResponseDto @object,
            global::Novu.WorkflowResponseDto previousObject)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.PreviousObject = previousObject ?? throw new global::System.ArgumentNullException(nameof(previousObject));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdatedWorkflowDto" /> class.
        /// </summary>
        public WebhookUpdatedWorkflowDto()
        {
        }
    }
}