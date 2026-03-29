
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceDiffDto
    {
        /// <summary>
        /// Source resource information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceResource")]
        public global::Novu.ResourceInfoDto? SourceResource { get; set; }

        /// <summary>
        /// Target resource information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetResource")]
        public global::Novu.ResourceInfoDto? TargetResource { get; set; }

        /// <summary>
        /// Type of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// Type of change
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.DiffActionEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DiffActionEnum Action { get; set; }

        /// <summary>
        /// Detailed changes (only for modified resources)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diffs")]
        public global::Novu.ResourceDiffDtoDiffs? Diffs { get; set; }

        /// <summary>
        /// Step type (only for step resources)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stepType")]
        public string? StepType { get; set; }

        /// <summary>
        /// Previous index in steps array (for moved/deleted steps)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previousIndex")]
        public double? PreviousIndex { get; set; }

        /// <summary>
        /// New index in steps array (for moved/added steps)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newIndex")]
        public double? NewIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDiffDto" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Type of the layout
        /// </param>
        /// <param name="action">
        /// Type of change
        /// </param>
        /// <param name="sourceResource">
        /// Source resource information
        /// </param>
        /// <param name="targetResource">
        /// Target resource information
        /// </param>
        /// <param name="diffs">
        /// Detailed changes (only for modified resources)
        /// </param>
        /// <param name="stepType">
        /// Step type (only for step resources)
        /// </param>
        /// <param name="previousIndex">
        /// Previous index in steps array (for moved/deleted steps)
        /// </param>
        /// <param name="newIndex">
        /// New index in steps array (for moved/added steps)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceDiffDto(
            global::Novu.ResourceTypeEnum resourceType,
            global::Novu.DiffActionEnum action,
            global::Novu.ResourceInfoDto? sourceResource,
            global::Novu.ResourceInfoDto? targetResource,
            global::Novu.ResourceDiffDtoDiffs? diffs,
            string? stepType,
            double? previousIndex,
            double? newIndex)
        {
            this.SourceResource = sourceResource;
            this.TargetResource = targetResource;
            this.ResourceType = resourceType;
            this.Action = action;
            this.Diffs = diffs;
            this.StepType = stepType;
            this.PreviousIndex = previousIndex;
            this.NewIndex = newIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDiffDto" /> class.
        /// </summary>
        public ResourceDiffDto()
        {
        }
    }
}