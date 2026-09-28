
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowPublishedWebhookPayloadDto
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WorkflowResponseDto Object { get; set; }

        /// <summary>
        ///
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
        /// Initializes a new instance of the <see cref="WorkflowPublishedWebhookPayloadDto" /> class.
        /// </summary>
        /// <param name="object"></param>
        /// <param name="previousObject"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowPublishedWebhookPayloadDto(
            global::Novu.WorkflowResponseDto @object,
            global::Novu.WorkflowResponseDto previousObject)
        {
            this.Object = @object ?? throw new global::System.ArgumentNullException(nameof(@object));
            this.PreviousObject = previousObject ?? throw new global::System.ArgumentNullException(nameof(previousObject));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowPublishedWebhookPayloadDto" /> class.
        /// </summary>
        public WorkflowPublishedWebhookPayloadDto()
        {
        }

    }
}