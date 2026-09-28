
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkflowWebhookTriggerVariableDto
    {
        /// <summary>
        /// Variable name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default variable value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Variable value type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TemplateVariableTypeEnumJsonConverter))]
        public global::Novu.TemplateVariableTypeEnum? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWebhookTriggerVariableDto" /> class.
        /// </summary>
        /// <param name="name">
        /// Variable name
        /// </param>
        /// <param name="value">
        /// Default variable value
        /// </param>
        /// <param name="type">
        /// Variable value type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowWebhookTriggerVariableDto(
            string name,
            object? value,
            global::Novu.TemplateVariableTypeEnum? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWebhookTriggerVariableDto" /> class.
        /// </summary>
        public WorkflowWebhookTriggerVariableDto()
        {
        }

    }
}