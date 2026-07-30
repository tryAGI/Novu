
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentBehaviorDto
    {
        /// <summary>
        /// Acknowledge incoming messages. On platforms that support a native typing indicator (e.g. Slack, WhatsApp, Microsoft Teams, Telegram), shows a "Typing…" indicator while the agent processes the message. On platforms that do not (e.g. Email), reacts with an "eyes" emoji to the first inbound message in a thread. Default: true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acknowledgeOnReceived")]
        public bool? AcknowledgeOnReceived { get; set; }

        /// <summary>
        /// Cross-platform emoji name for resolved conversations (e.g. "check", "star"). Set to null to disable. Default: "check"<br/>
        /// Default Value: check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactionOnResolved")]
        public object? ReactionOnResolved { get; set; }

        /// <summary>
        /// Controls whether the agent accepts inbound messages from senders not yet linked to a subscriber, across all channels. "open" on managed agents auto-creates a lightweight subscriber so the agent can reply; on custom-code / self-hosted agents, the turn is forwarded to the bridge with a null subscriber. "restricted" rejects unknown senders with a managed denial reply (any runtime). Optional on update (partial PATCH). Persisted agents always have a value — managed create defaults to "open"; self-hosted create defaults to "restricted".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberAccess")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.AgentBehaviorDtoSubscriberAccessJsonConverter))]
        public global::Novu.AgentBehaviorDtoSubscriberAccess? SubscriberAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBehaviorDto" /> class.
        /// </summary>
        /// <param name="acknowledgeOnReceived">
        /// Acknowledge incoming messages. On platforms that support a native typing indicator (e.g. Slack, WhatsApp, Microsoft Teams, Telegram), shows a "Typing…" indicator while the agent processes the message. On platforms that do not (e.g. Email), reacts with an "eyes" emoji to the first inbound message in a thread. Default: true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="reactionOnResolved">
        /// Cross-platform emoji name for resolved conversations (e.g. "check", "star"). Set to null to disable. Default: "check"<br/>
        /// Default Value: check
        /// </param>
        /// <param name="subscriberAccess">
        /// Controls whether the agent accepts inbound messages from senders not yet linked to a subscriber, across all channels. "open" on managed agents auto-creates a lightweight subscriber so the agent can reply; on custom-code / self-hosted agents, the turn is forwarded to the bridge with a null subscriber. "restricted" rejects unknown senders with a managed denial reply (any runtime). Optional on update (partial PATCH). Persisted agents always have a value — managed create defaults to "open"; self-hosted create defaults to "restricted".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBehaviorDto(
            bool? acknowledgeOnReceived,
            object? reactionOnResolved,
            global::Novu.AgentBehaviorDtoSubscriberAccess? subscriberAccess)
        {
            this.AcknowledgeOnReceived = acknowledgeOnReceived;
            this.ReactionOnResolved = reactionOnResolved;
            this.SubscriberAccess = subscriberAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBehaviorDto" /> class.
        /// </summary>
        public AgentBehaviorDto()
        {
        }

    }
}