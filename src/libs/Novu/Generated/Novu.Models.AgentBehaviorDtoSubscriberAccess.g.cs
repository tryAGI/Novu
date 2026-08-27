
#nullable enable

namespace Novu
{
    /// <summary>
    /// Controls whether the agent accepts inbound messages from senders not yet linked to a subscriber, across all channels. "open" on managed agents auto-creates a lightweight subscriber so the agent can reply; on custom-code / self-hosted agents, the turn is forwarded to the bridge with a null subscriber. "restricted" rejects unknown senders with a managed denial reply (any runtime). Optional on update (partial PATCH). Persisted agents always have a value — managed create defaults to "open"; self-hosted create defaults to "restricted".
    /// </summary>
    public enum AgentBehaviorDtoSubscriberAccess
    {
        /// <summary>
        ///
        /// </summary>
        Open,
        /// <summary>
        ///
        /// </summary>
        Restricted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentBehaviorDtoSubscriberAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBehaviorDtoSubscriberAccess value)
        {
            return value switch
            {
                AgentBehaviorDtoSubscriberAccess.Open => "open",
                AgentBehaviorDtoSubscriberAccess.Restricted => "restricted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBehaviorDtoSubscriberAccess? ToEnum(string value)
        {
            return value switch
            {
                "open" => AgentBehaviorDtoSubscriberAccess.Open,
                "restricted" => AgentBehaviorDtoSubscriberAccess.Restricted,
                _ => null,
            };
        }
    }
}