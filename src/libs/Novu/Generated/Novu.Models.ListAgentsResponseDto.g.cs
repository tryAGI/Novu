
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListAgentsResponseDto
    {
        /// <summary>
        /// List of returned agents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.AgentResponseDto> Data { get; set; }

        /// <summary>
        /// The cursor for the next page of results, or null if there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// The cursor for the previous page of results, or null if this is the first page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public string? Previous { get; set; }

        /// <summary>
        /// The total count of items (up to 50,000)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCount { get; set; }

        /// <summary>
        /// Whether there are more than 50,000 results available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalCountCapped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TotalCountCapped { get; set; }

        /// <summary>
        /// Cloud only. Active agent usage in this environment against the organization plan limit. Agents created beyond the limit are flagged with `exceedsPlanLimit` and will not respond to inbound messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planUsage")]
        public global::Novu.AgentPlanUsageDto? PlanUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponseDto" /> class.
        /// </summary>
        /// <param name="data">
        /// List of returned agents
        /// </param>
        /// <param name="totalCount">
        /// The total count of items (up to 50,000)
        /// </param>
        /// <param name="totalCountCapped">
        /// Whether there are more than 50,000 results available
        /// </param>
        /// <param name="next">
        /// The cursor for the next page of results, or null if there are no more pages.
        /// </param>
        /// <param name="previous">
        /// The cursor for the previous page of results, or null if this is the first page.
        /// </param>
        /// <param name="planUsage">
        /// Cloud only. Active agent usage in this environment against the organization plan limit. Agents created beyond the limit are flagged with `exceedsPlanLimit` and will not respond to inbound messages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListAgentsResponseDto(
            global::System.Collections.Generic.IList<global::Novu.AgentResponseDto> data,
            double totalCount,
            bool totalCountCapped,
            string? next,
            string? previous,
            global::Novu.AgentPlanUsageDto? planUsage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Next = next;
            this.Previous = previous;
            this.TotalCount = totalCount;
            this.TotalCountCapped = totalCountCapped;
            this.PlanUsage = planUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListAgentsResponseDto" /> class.
        /// </summary>
        public ListAgentsResponseDto()
        {
        }

    }
}