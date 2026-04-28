
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestDomainRouteResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matched")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Matched { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DryRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoDomainStatusJsonConverter))]
        public global::Novu.TestDomainRouteResponseDtoDomainStatus? DomainStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mxRecordConfigured")]
        public bool? MxRecordConfigured { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.TestDomainRouteResponseDtoTypeJsonConverter))]
        public global::Novu.TestDomainRouteResponseDtoType? Type { get; set; }

        /// <summary>
        /// Human-readable delivery target summary in dry-run mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wouldDeliverTo")]
        public string? WouldDeliverTo { get; set; }

        /// <summary>
        /// The outbound payload (dry-run only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        public object? Payload { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::Novu.TestDomainRouteWebhookResultDto? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::Novu.TestDomainRouteAgentResultDto? Agent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDomainRouteResponseDto" /> class.
        /// </summary>
        /// <param name="matched"></param>
        /// <param name="dryRun"></param>
        /// <param name="domainStatus"></param>
        /// <param name="mxRecordConfigured"></param>
        /// <param name="type"></param>
        /// <param name="wouldDeliverTo">
        /// Human-readable delivery target summary in dry-run mode.
        /// </param>
        /// <param name="payload">
        /// The outbound payload (dry-run only).
        /// </param>
        /// <param name="webhook"></param>
        /// <param name="agent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestDomainRouteResponseDto(
            bool matched,
            bool dryRun,
            global::Novu.TestDomainRouteResponseDtoDomainStatus? domainStatus,
            bool? mxRecordConfigured,
            global::Novu.TestDomainRouteResponseDtoType? type,
            string? wouldDeliverTo,
            object? payload,
            global::Novu.TestDomainRouteWebhookResultDto? webhook,
            global::Novu.TestDomainRouteAgentResultDto? agent)
        {
            this.Matched = matched;
            this.DryRun = dryRun;
            this.DomainStatus = domainStatus;
            this.MxRecordConfigured = mxRecordConfigured;
            this.Type = type;
            this.WouldDeliverTo = wouldDeliverTo;
            this.Payload = payload;
            this.Webhook = webhook;
            this.Agent = agent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestDomainRouteResponseDto" /> class.
        /// </summary>
        public TestDomainRouteResponseDto()
        {
        }
    }
}