
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentPlanUsageDto
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
        /// Total agents in this environment, including inactive ones.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCreated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCreated { get; set; }

        /// <summary>
        /// Hard cap on total agents the organization can create per environment. For plan-limited tiers this is the plan limit plus a small grace buffer; for unlimited tiers it is the platform system limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationLimit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreationLimit { get; set; }

        /// <summary>
        /// Which constraint produced the limits. `plan` limits are lifted by upgrading; `system` limits (platform cap or per-organization override) require contacting the Novu team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limitSource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.AgentPlanUsageDtoLimitSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.AgentPlanUsageDtoLimitSource LimitSource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlanUsageDto" /> class.
        /// </summary>
        /// <param name="used">
        /// Current usage count for the resource in this environment.
        /// </param>
        /// <param name="limit">
        /// Amount included in the organization plan.
        /// </param>
        /// <param name="totalCreated">
        /// Total agents in this environment, including inactive ones.
        /// </param>
        /// <param name="creationLimit">
        /// Hard cap on total agents the organization can create per environment. For plan-limited tiers this is the plan limit plus a small grace buffer; for unlimited tiers it is the platform system limit.
        /// </param>
        /// <param name="limitSource">
        /// Which constraint produced the limits. `plan` limits are lifted by upgrading; `system` limits (platform cap or per-organization override) require contacting the Novu team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentPlanUsageDto(
            double used,
            double limit,
            double totalCreated,
            double creationLimit,
            global::Novu.AgentPlanUsageDtoLimitSource limitSource)
        {
            this.Used = used;
            this.Limit = limit;
            this.TotalCreated = totalCreated;
            this.CreationLimit = creationLimit;
            this.LimitSource = limitSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentPlanUsageDto" /> class.
        /// </summary>
        public AgentPlanUsageDto()
        {
        }

    }
}