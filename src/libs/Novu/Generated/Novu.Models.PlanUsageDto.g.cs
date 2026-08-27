
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PlanUsageDto
    {
        /// <summary>
        /// Current usage count for the resource in this environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Used { get; set; }

        /// <summary>
        /// Amount included in the organization plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanUsageDto" /> class.
        /// </summary>
        /// <param name="used">
        /// Current usage count for the resource in this environment.
        /// </param>
        /// <param name="limit">
        /// Amount included in the organization plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlanUsageDto(
            double used,
            double limit)
        {
            this.Used = used;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlanUsageDto" /> class.
        /// </summary>
        public PlanUsageDto()
        {
        }

    }
}