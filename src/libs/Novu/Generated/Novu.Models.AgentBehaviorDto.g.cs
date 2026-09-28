
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
        /// How the agent replies in shared rooms. "mention_only" requires an @mention in every shared room. "auto_reply" replies to unmentioned follow-ups in a nested Slack or Teams thread after the agent has joined. "smart" behaves like auto_reply while one person is talking to the agent in a thread, then requires an @mention there once someone else or another agent joins, or the incumbent @mentions another teammate. Create persists "smart". An omitted field on existing agents still means "auto_reply". DMs always reply without a mention. Optional on update (partial PATCH).<br/>
        /// Default Value: auto_reply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replyPolicy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.AgentBehaviorDtoReplyPolicyJsonConverter))]
        public global::Novu.AgentBehaviorDtoReplyPolicy? ReplyPolicy { get; set; }

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
        /// <param name="replyPolicy">
        /// How the agent replies in shared rooms. "mention_only" requires an @mention in every shared room. "auto_reply" replies to unmentioned follow-ups in a nested Slack or Teams thread after the agent has joined. "smart" behaves like auto_reply while one person is talking to the agent in a thread, then requires an @mention there once someone else or another agent joins, or the incumbent @mentions another teammate. Create persists "smart". An omitted field on existing agents still means "auto_reply". DMs always reply without a mention. Optional on update (partial PATCH).<br/>
        /// Default Value: auto_reply
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentBehaviorDto(
            bool? acknowledgeOnReceived,
            object? reactionOnResolved,
            global::Novu.AgentBehaviorDtoSubscriberAccess? subscriberAccess,
            global::Novu.AgentBehaviorDtoReplyPolicy? replyPolicy)
        {
            this.AcknowledgeOnReceived = acknowledgeOnReceived;
            this.ReactionOnResolved = reactionOnResolved;
            this.SubscriberAccess = subscriberAccess;
            this.ReplyPolicy = replyPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentBehaviorDto" /> class.
        /// </summary>
        public AgentBehaviorDto()
        {
        }

    }
}