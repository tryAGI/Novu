
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NotificationWorkflowDto
    {
        /// <summary>
        /// Unique identifier of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Workflow identifier used for triggering
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Human-readable name of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this workflow is marked as critical
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("critical")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Critical { get; set; }

        /// <summary>
        /// Tags associated with the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Custom data associated with the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public object? Data { get; set; }

        /// <summary>
        /// Severity of the workflow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.SeverityLevelEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.SeverityLevelEnum Severity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationWorkflowDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the workflow
        /// </param>
        /// <param name="identifier">
        /// Workflow identifier used for triggering
        /// </param>
        /// <param name="name">
        /// Human-readable name of the workflow
        /// </param>
        /// <param name="critical">
        /// Whether this workflow is marked as critical
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow
        /// </param>
        /// <param name="data">
        /// Custom data associated with the workflow
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NotificationWorkflowDto(
            string id,
            string identifier,
            string name,
            bool critical,
            global::Novu.SeverityLevelEnum severity,
            global::System.Collections.Generic.IList<string>? tags,
            object? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Critical = critical;
            this.Tags = tags;
            this.Data = data;
            this.Severity = severity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationWorkflowDto" /> class.
        /// </summary>
        public NotificationWorkflowDto()
        {
        }
    }
}