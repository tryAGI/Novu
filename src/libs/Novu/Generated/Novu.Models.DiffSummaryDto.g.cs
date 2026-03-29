
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiffSummaryDto
    {
        /// <summary>
        /// Number of added resources (workflows and steps)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Added { get; set; }

        /// <summary>
        /// Number of modified resources (workflows and steps)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Modified { get; set; }

        /// <summary>
        /// Number of deleted resources (workflows and steps)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Deleted { get; set; }

        /// <summary>
        /// Number of unchanged resources (workflows and steps)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unchanged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Unchanged { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiffSummaryDto" /> class.
        /// </summary>
        /// <param name="added">
        /// Number of added resources (workflows and steps)
        /// </param>
        /// <param name="modified">
        /// Number of modified resources (workflows and steps)
        /// </param>
        /// <param name="deleted">
        /// Number of deleted resources (workflows and steps)
        /// </param>
        /// <param name="unchanged">
        /// Number of unchanged resources (workflows and steps)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiffSummaryDto(
            double added,
            double modified,
            double deleted,
            double unchanged)
        {
            this.Added = added;
            this.Modified = modified;
            this.Deleted = deleted;
            this.Unchanged = unchanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiffSummaryDto" /> class.
        /// </summary>
        public DiffSummaryDto()
        {
        }
    }
}