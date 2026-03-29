
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomStepResponseDto
    {
        /// <summary>
        /// Controls metadata for the custom step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.CustomControlsMetadataResponseDto Controls { get; set; }

        /// <summary>
        /// Control values for the custom step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlValues")]
        public global::Novu.CustomControlDto? ControlValues { get; set; }

        /// <summary>
        /// JSON Schema for variables, follows the JSON Schema standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variables")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Variables { get; set; }

        /// <summary>
        /// Unique identifier of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StepId { get; set; }

        /// <summary>
        /// Database identifier of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Slug of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Type of the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.StepTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.StepTypeEnum Type { get; set; }

        /// <summary>
        /// Origin of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceOriginEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceOriginEnum Origin { get; set; }

        /// <summary>
        /// Workflow identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// Workflow database identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflowDatabaseId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowDatabaseId { get; set; }

        /// <summary>
        /// Issues associated with the step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues")]
        public global::Novu.StepIssuesDto? Issues { get; set; }

        /// <summary>
        /// Hash identifying the deployed Cloudflare Worker for this step
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepResolverHash")]
        public string? StepResolverHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomStepResponseDto" /> class.
        /// </summary>
        /// <param name="controls">
        /// Controls metadata for the custom step
        /// </param>
        /// <param name="variables">
        /// JSON Schema for variables, follows the JSON Schema standard
        /// </param>
        /// <param name="stepId">
        /// Unique identifier of the step
        /// </param>
        /// <param name="id">
        /// Database identifier of the step
        /// </param>
        /// <param name="name">
        /// Name of the step
        /// </param>
        /// <param name="slug">
        /// Slug of the step
        /// </param>
        /// <param name="type">
        /// Type of the step
        /// </param>
        /// <param name="origin">
        /// Origin of the layout
        /// </param>
        /// <param name="workflowId">
        /// Workflow identifier
        /// </param>
        /// <param name="workflowDatabaseId">
        /// Workflow database identifier
        /// </param>
        /// <param name="controlValues">
        /// Control values for the custom step
        /// </param>
        /// <param name="issues">
        /// Issues associated with the step
        /// </param>
        /// <param name="stepResolverHash">
        /// Hash identifying the deployed Cloudflare Worker for this step
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomStepResponseDto(
            global::Novu.CustomControlsMetadataResponseDto controls,
            object variables,
            string stepId,
            string id,
            string name,
            string slug,
            global::Novu.StepTypeEnum type,
            global::Novu.ResourceOriginEnum origin,
            string workflowId,
            string workflowDatabaseId,
            global::Novu.CustomControlDto? controlValues,
            global::Novu.StepIssuesDto? issues,
            string? stepResolverHash)
        {
            this.Controls = controls ?? throw new global::System.ArgumentNullException(nameof(controls));
            this.ControlValues = controlValues;
            this.Variables = variables ?? throw new global::System.ArgumentNullException(nameof(variables));
            this.StepId = stepId ?? throw new global::System.ArgumentNullException(nameof(stepId));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Type = type;
            this.Origin = origin;
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.WorkflowDatabaseId = workflowDatabaseId ?? throw new global::System.ArgumentNullException(nameof(workflowDatabaseId));
            this.Issues = issues;
            this.StepResolverHash = stepResolverHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomStepResponseDto" /> class.
        /// </summary>
        public CustomStepResponseDto()
        {
        }
    }
}