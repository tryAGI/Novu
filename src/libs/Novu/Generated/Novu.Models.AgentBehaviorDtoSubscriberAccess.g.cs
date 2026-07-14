
#nullable enable

namespace Novu
{
    /// <summary>
    /// Controls whether the agent accepts inbound messages from senders not yet linked to a subscriber. "open" auto-creates a lightweight subscriber from the sender email so the agent can reply; "restricted" rejects unknown senders. Defaults to "restricted" when unset. Newly provisioned email integrations default to "open".
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