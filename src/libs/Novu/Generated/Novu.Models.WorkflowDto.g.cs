
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowDto
    {
        /// <summary>
        /// Unique identifier of the workflow<br/>
        /// Example: 64a1b2c3d4e5f6g7h8i9j0k1
        /// </summary>
        /// <example>64a1b2c3d4e5f6g7h8i9j0k1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Workflow identifier used for triggering<br/>
        /// Example: welcome-email
        /// </summary>
        /// <example>welcome-email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Human-readable name of the workflow<br/>
        /// Example: Welcome Email Workflow
        /// </summary>
        /// <example>Welcome Email Workflow</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this workflow is marked as critical<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("critical")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Critical { get; set; }

        /// <summary>
        /// Tags associated with the workflow<br/>
        /// Example: [user-onboarding, email]
        /// </summary>
        /// <example>[user-onboarding, email]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Custom data associated with the workflow<br/>
        /// Example: {"category":"onboarding","priority":"high"}
        /// </summary>
        /// <example>{"category":"onboarding","priority":"high"}</example>
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
        /// Initializes a new instance of the <see cref="WorkflowDto" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the workflow<br/>
        /// Example: 64a1b2c3d4e5f6g7h8i9j0k1
        /// </param>
        /// <param name="identifier">
        /// Workflow identifier used for triggering<br/>
        /// Example: welcome-email
        /// </param>
        /// <param name="name">
        /// Human-readable name of the workflow<br/>
        /// Example: Welcome Email Workflow
        /// </param>
        /// <param name="critical">
        /// Whether this workflow is marked as critical<br/>
        /// Example: false
        /// </param>
        /// <param name="severity">
        /// Severity of the workflow
        /// </param>
        /// <param name="tags">
        /// Tags associated with the workflow<br/>
        /// Example: [user-onboarding, email]
        /// </param>
        /// <param name="data">
        /// Custom data associated with the workflow<br/>
        /// Example: {"category":"onboarding","priority":"high"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowDto(
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
        /// Initializes a new instance of the <see cref="WorkflowDto" /> class.
        /// </summary>
        public WorkflowDto()
        {
        }
    }
}