
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestDomainRouteAgentResultDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("httpStatus")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double HttpStatus { get; set; }

        /// <summary>
        /// Parsed JSON body from the agent webhook response when JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agentReply")]
        public object? AgentReply { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LatencyMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDomainRouteAgentResultDto" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="httpStatus"></param>
        /// <param name="latencyMs"></param>
        /// <param name="agentReply">
        /// Parsed JSON body from the agent webhook response when JSON.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestDomainRouteAgentResultDto(
            string agentId,
            double httpStatus,
            double latencyMs,
            object? agentReply)
        {
            this.AgentId = agentId ?? throw new global::System.ArgumentNullException(nameof(agentId));
            this.HttpStatus = httpStatus;
            this.AgentReply = agentReply;
            this.LatencyMs = latencyMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDomainRouteAgentResultDto" /> class.
        /// </summary>
        public TestDomainRouteAgentResultDto()
        {
        }
    }
}