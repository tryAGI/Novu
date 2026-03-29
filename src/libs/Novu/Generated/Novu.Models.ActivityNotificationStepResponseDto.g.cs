
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActivityNotificationStepResponseDto
    {
        /// <summary>
        /// Unique identifier of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the step is active or not
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Active { get; set; }

        /// <summary>
        /// Reply callback settings
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replyCallback")]
        public object? ReplyCallback { get; set; }

        /// <summary>
        /// Control variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlVariables")]
        public object? ControlVariables { get; set; }

        /// <summary>
        /// Metadata for the workflow step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Step issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public object? Issues { get; set; }

        /// <summary>
        /// Filter criteria for the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.StepFilterDto> Filters { get; set; }

        /// <summary>
        /// Optional template for the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        public global::Novu.MessageTemplateDto? Template { get; set; }

        /// <summary>
        /// Variants of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::System.Collections.Generic.IList<global::Novu.ActivityNotificationStepResponseDto>? Variants { get; set; }

        /// <summary>
        /// The identifier for the template associated with this step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_templateId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// The name of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The unique identifier for the parent step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationStepResponseDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the step
        /// </param>
        /// <param name="active">
        /// Whether the step is active or not
        /// </param>
        /// <param name="filters">
        /// Filter criteria for the step
        /// </param>
        /// <param name="templateId">
        /// The identifier for the template associated with this step
        /// </param>
        /// <param name="replyCallback">
        /// Reply callback settings
        /// </param>
        /// <param name="controlVariables">
        /// Control variables
        /// </param>
        /// <param name="metadata">
        /// Metadata for the workflow step
        /// </param>
        /// <param name="issues">
        /// Step issues
        /// </param>
        /// <param name="template">
        /// Optional template for the step
        /// </param>
        /// <param name="variants">
        /// Variants of the step
        /// </param>
        /// <param name="name">
        /// The name of the step
        /// </param>
        /// <param name="parentId">
        /// The unique identifier for the parent step
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActivityNotificationStepResponseDto(
            string id,
            bool active,
            global::System.Collections.Generic.IList<global::Novu.StepFilterDto> filters,
            string templateId,
            object? replyCallback,
            object? controlVariables,
            object? metadata,
            object? issues,
            global::Novu.MessageTemplateDto? template,
            global::System.Collections.Generic.IList<global::Novu.ActivityNotificationStepResponseDto>? variants,
            string? name,
            string? parentId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Active = active;
            this.ReplyCallback = replyCallback;
            this.ControlVariables = controlVariables;
            this.Metadata = metadata;
            this.Issues = issues;
            this.Filters = filters ?? throw new global::System.ArgumentNullException(nameof(filters));
            this.Template = template;
            this.Variants = variants;
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.Name = name;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityNotificationStepResponseDto" /> class.
        /// </summary>
        public ActivityNotificationStepResponseDto()
        {
        }
    }
}