
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceDiffResultDto
    {
        /// <summary>
        /// Type of the layout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ResourceTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.ResourceTypeEnum ResourceType { get; set; }

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
        /// List of specific changes for this resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto> Changes { get; set; }

        /// <summary>
        /// Summary of changes for this resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.DiffSummaryDto Summary { get; set; }

        /// <summary>
        /// Dependencies that affect this resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        public global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDiffResultDto" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Type of the layout
        /// </param>
        /// <param name="changes">
        /// List of specific changes for this resource
        /// </param>
        /// <param name="summary">
        /// Summary of changes for this resource
        /// </param>
        /// <param name="sourceResource">
        /// Source resource information
        /// </param>
        /// <param name="targetResource">
        /// Target resource information
        /// </param>
        /// <param name="dependencies">
        /// Dependencies that affect this resource
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResourceDiffResultDto(
            global::Novu.ResourceTypeEnum resourceType,
            global::System.Collections.Generic.IList<global::Novu.ResourceDiffDto> changes,
            global::Novu.DiffSummaryDto summary,
            global::Novu.ResourceInfoDto? sourceResource,
            global::Novu.ResourceInfoDto? targetResource,
            global::System.Collections.Generic.IList<global::Novu.ResourceDependencyDto>? dependencies)
        {
            this.ResourceType = resourceType;
            this.SourceResource = sourceResource;
            this.TargetResource = targetResource;
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Dependencies = dependencies;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceDiffResultDto" /> class.
        /// </summary>
        public ResourceDiffResultDto()
        {
        }
    }
}