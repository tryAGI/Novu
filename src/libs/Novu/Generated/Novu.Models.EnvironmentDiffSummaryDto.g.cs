
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentDiffSummaryDto
    {
        /// <summary>
        /// Total number of entities compared
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalEntities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalEntities { get; set; }

        /// <summary>
        /// Total number of changes detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalChanges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalChanges { get; set; }

        /// <summary>
        /// Whether any changes were detected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hasChanges")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasChanges { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentDiffSummaryDto" /> class.
        /// </summary>
        /// <param name="totalEntities">
        /// Total number of entities compared
        /// </param>
        /// <param name="totalChanges">
        /// Total number of changes detected
        /// </param>
        /// <param name="hasChanges">
        /// Whether any changes were detected
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentDiffSummaryDto(
            double totalEntities,
            double totalChanges,
            bool hasChanges)
        {
            this.TotalEntities = totalEntities;
            this.TotalChanges = totalChanges;
            this.HasChanges = hasChanges;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentDiffSummaryDto" /> class.
        /// </summary>
        public EnvironmentDiffSummaryDto()
        {
        }
    }
}