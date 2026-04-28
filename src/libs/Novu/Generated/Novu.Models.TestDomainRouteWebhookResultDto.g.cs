
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestDomainRouteWebhookResultDto
    {
        /// <summary>
        /// True when outbound webhooks are disabled for this environment (nothing was emitted).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        public bool? Skipped { get; set; }

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
        /// Initializes a new instance of the <see cref="TestDomainRouteWebhookResultDto" /> class.
        /// </summary>
        /// <param name="latencyMs"></param>
        /// <param name="skipped">
        /// True when outbound webhooks are disabled for this environment (nothing was emitted).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestDomainRouteWebhookResultDto(
            double latencyMs,
            bool? skipped)
        {
            this.Skipped = skipped;
            this.LatencyMs = latencyMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDomainRouteWebhookResultDto" /> class.
        /// </summary>
        public TestDomainRouteWebhookResultDto()
        {
        }
    }
}