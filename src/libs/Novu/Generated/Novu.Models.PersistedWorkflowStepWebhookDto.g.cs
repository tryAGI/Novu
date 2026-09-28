
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PersistedWorkflowStepWebhookDto
    {
        /// <summary>
        /// Database identifier of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Stable UUID of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Step identifier used when triggering and correlating events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepId")]
        public string? StepId { get; set; }

        /// <summary>
        /// Display name of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Database identifier of the message template for this step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Whether the step is active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replyCallback")]
        public global::Novu.WorkflowWebhookReplyCallbackDto? ReplyCallback { get; set; }

        /// <summary>
        /// Persisted message template for this step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public object? Template { get; set; }

        /// <summary>
        /// Step filters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<object>? Filters { get; set; }

        /// <summary>
        /// Parent step identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Digest, delay, or throttle metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether execution should stop if this step fails
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldStopOnFail")]
        public bool? ShouldStopOnFail { get; set; }

        /// <summary>
        /// Bridge URL for framework-backed steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bridgeUrl")]
        public string? BridgeUrl { get; set; }

        /// <summary>
        /// Control values stored on the step in non-production environments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlVariables")]
        public object? ControlVariables { get; set; }

        /// <summary>
        /// Control schemas stored on the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        public object? Controls { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::Novu.StepIssuesDto? Issues { get; set; }

        /// <summary>
        /// Step variants
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::System.Collections.Generic.IList<object>? Variants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedWorkflowStepWebhookDto" /> class.
        /// </summary>
        /// <param name="templateId">
        /// Database identifier of the message template for this step
        /// </param>
        /// <param name="id">
        /// Database identifier of the step
        /// </param>
        /// <param name="uuid">
        /// Stable UUID of the step
        /// </param>
        /// <param name="stepId">
        /// Step identifier used when triggering and correlating events
        /// </param>
        /// <param name="name">
        /// Display name of the step
        /// </param>
        /// <param name="active">
        /// Whether the step is active
        /// </param>
        /// <param name="replyCallback"></param>
        /// <param name="template">
        /// Persisted message template for this step
        /// </param>
        /// <param name="filters">
        /// Step filters
        /// </param>
        /// <param name="parentId">
        /// Parent step identifier
        /// </param>
        /// <param name="metadata">
        /// Digest, delay, or throttle metadata
        /// </param>
        /// <param name="shouldStopOnFail">
        /// Whether execution should stop if this step fails
        /// </param>
        /// <param name="bridgeUrl">
        /// Bridge URL for framework-backed steps
        /// </param>
        /// <param name="controlVariables">
        /// Control values stored on the step in non-production environments
        /// </param>
        /// <param name="controls">
        /// Control schemas stored on the step
        /// </param>
        /// <param name="issues"></param>
        /// <param name="variants">
        /// Step variants
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PersistedWorkflowStepWebhookDto(
            string templateId,
            string? id,
            string? uuid,
            string? stepId,
            string? name,
            bool? active,
            global::Novu.WorkflowWebhookReplyCallbackDto? replyCallback,
            object? template,
            global::System.Collections.Generic.IList<object>? filters,
            string? parentId,
            object? metadata,
            bool? shouldStopOnFail,
            string? bridgeUrl,
            object? controlVariables,
            object? controls,
            global::Novu.StepIssuesDto? issues,
            global::System.Collections.Generic.IList<object>? variants)
        {
            this.Id = id;
            this.Uuid = uuid;
            this.StepId = stepId;
            this.Name = name;
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.Active = active;
            this.ReplyCallback = replyCallback;
            this.Template = template;
            this.Filters = filters;
            this.ParentId = parentId;
            this.Metadata = metadata;
            this.ShouldStopOnFail = shouldStopOnFail;
            this.BridgeUrl = bridgeUrl;
            this.ControlVariables = controlVariables;
            this.Controls = controls;
            this.Issues = issues;
            this.Variants = variants;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersistedWorkflowStepWebhookDto" /> class.
        /// </summary>
        public PersistedWorkflowStepWebhookDto()
        {
        }

    }
}