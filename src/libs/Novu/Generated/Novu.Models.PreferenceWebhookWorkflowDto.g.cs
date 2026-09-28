
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PreferenceWebhookWorkflowDto
    {
        /// <summary>
        /// Database identifier of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Workflow identifier used when triggering the workflow. May be absent for subscription preferences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        public string? Identifier { get; set; }

        /// <summary>
        /// Name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the workflow ignores subscriber preferences
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("critical")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Critical { get; set; }

        /// <summary>
        /// Workflow severity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SeverityLevelEnum Severity { get; set; }

        /// <summary>
        /// Tags assigned to the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Custom workflow data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookWorkflowDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Database identifier of the workflow
        /// </param>
        /// <param name="name">
        /// Name of the workflow
        /// </param>
        /// <param name="critical">
        /// Whether the workflow ignores subscriber preferences
        /// </param>
        /// <param name="severity">
        /// Workflow severity
        /// </param>
        /// <param name="identifier">
        /// Workflow identifier used when triggering the workflow. May be absent for subscription preferences.
        /// </param>
        /// <param name="tags">
        /// Tags assigned to the workflow
        /// </param>
        /// <param name="data">
        /// Custom workflow data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreferenceWebhookWorkflowDto(
            string id,
            string name,
            bool critical,
            global::Novu.SeverityLevelEnum severity,
            string? identifier,
            global::System.Collections.Generic.IList<string>? tags,
            object? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Identifier = identifier;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Critical = critical;
            this.Severity = severity;
            this.Tags = tags;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PreferenceWebhookWorkflowDto" /> class.
        /// </summary>
        public PreferenceWebhookWorkflowDto()
        {
        }

    }
}