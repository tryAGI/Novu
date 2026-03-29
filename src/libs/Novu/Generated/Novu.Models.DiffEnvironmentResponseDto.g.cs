
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiffEnvironmentResponseDto
    {
        /// <summary>
        /// Source environment ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceEnvironmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceEnvironmentId { get; set; }

        /// <summary>
        /// Target environment ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetEnvironmentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetEnvironmentId { get; set; }

        /// <summary>
        /// Diff resources by resource type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto> Resources { get; set; }

        /// <summary>
        /// Overall summary
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.EnvironmentDiffSummaryDto Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiffEnvironmentResponseDto" /> class.
        /// </summary>
        /// <param name="sourceEnvironmentId">
        /// Source environment ID
        /// </param>
        /// <param name="targetEnvironmentId">
        /// Target environment ID
        /// </param>
        /// <param name="resources">
        /// Diff resources by resource type
        /// </param>
        /// <param name="summary">
        /// Overall summary
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiffEnvironmentResponseDto(
            string sourceEnvironmentId,
            string targetEnvironmentId,
            global::System.Collections.Generic.IList<global::Novu.ResourceDiffResultDto> resources,
            global::Novu.EnvironmentDiffSummaryDto summary)
        {
            this.SourceEnvironmentId = sourceEnvironmentId ?? throw new global::System.ArgumentNullException(nameof(sourceEnvironmentId));
            this.TargetEnvironmentId = targetEnvironmentId ?? throw new global::System.ArgumentNullException(nameof(targetEnvironmentId));
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiffEnvironmentResponseDto" /> class.
        /// </summary>
        public DiffEnvironmentResponseDto()
        {
        }
    }
}