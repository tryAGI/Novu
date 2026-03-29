
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotificationStepDto
    {
        /// <summary>
        /// Unique identifier for the notification step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// Universally unique identifier for the notification step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Name of the notification step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of the template associated with this notification step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_templateId")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// Indicates whether the notification step is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Determines if the process should stop on failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shouldStopOnFail")]
        public bool? ShouldStopOnFail { get; set; }

        /// <summary>
        /// Message template used in this notification step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Novu.MessageTemplate? Template { get; set; }

        /// <summary>
        /// Filters applied to this notification step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.IList<global::Novu.StepFilterDto>? Filters { get; set; }

        /// <summary>
        /// ID of the parent notification step, if applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Metadata associated with the workflow step. Can vary based on the type of step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>))]
        public global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>? Metadata { get; set; }

        /// <summary>
        /// Callback information for replies, including whether it is active and the callback URL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replyCallback")]
        public global::Novu.ReplyCallback? ReplyCallback { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::System.Collections.Generic.IList<global::Novu.NotificationStepData>? Variants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationStepDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the notification step.
        /// </param>
        /// <param name="uuid">
        /// Universally unique identifier for the notification step.
        /// </param>
        /// <param name="name">
        /// Name of the notification step.
        /// </param>
        /// <param name="templateId">
        /// ID of the template associated with this notification step.
        /// </param>
        /// <param name="active">
        /// Indicates whether the notification step is active.
        /// </param>
        /// <param name="shouldStopOnFail">
        /// Determines if the process should stop on failure.
        /// </param>
        /// <param name="template">
        /// Message template used in this notification step.
        /// </param>
        /// <param name="filters">
        /// Filters applied to this notification step.
        /// </param>
        /// <param name="parentId">
        /// ID of the parent notification step, if applicable.
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the workflow step. Can vary based on the type of step.
        /// </param>
        /// <param name="replyCallback">
        /// Callback information for replies, including whether it is active and the callback URL.
        /// </param>
        /// <param name="variants"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotificationStepDto(
            string? id,
            string? uuid,
            string? name,
            string? templateId,
            bool? active,
            bool? shouldStopOnFail,
            global::Novu.MessageTemplate? template,
            global::System.Collections.Generic.IList<global::Novu.StepFilterDto>? filters,
            string? parentId,
            global::Novu.OneOf<global::Novu.DigestRegularMetadata, global::Novu.DigestTimedMetadata, global::Novu.DelayRegularMetadata, global::Novu.DelayScheduledMetadata>? metadata,
            global::Novu.ReplyCallback? replyCallback,
            global::System.Collections.Generic.IList<global::Novu.NotificationStepData>? variants)
        {
            this.Id = id;
            this.Uuid = uuid;
            this.Name = name;
            this.TemplateId = templateId;
            this.Active = active;
            this.ShouldStopOnFail = shouldStopOnFail;
            this.Template = template;
            this.Filters = filters;
            this.ParentId = parentId;
            this.Metadata = metadata;
            this.ReplyCallback = replyCallback;
            this.Variants = variants;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationStepDto" /> class.
        /// </summary>
        public NotificationStepDto()
        {
        }
    }
}