
#nullable enable

namespace Novu
{
    /// <summary>
    /// How the agent replies in shared rooms. "mention_only" requires an @mention in every shared room. "auto_reply" replies to unmentioned follow-ups in a nested Slack or Teams thread after the agent has joined. "smart" behaves like auto_reply while one person is talking to the agent in a thread, then requires an @mention there once someone else or another agent joins, or the incumbent @mentions another teammate. Create persists "smart". An omitted field on existing agents still means "auto_reply". DMs always reply without a mention. Optional on update (partial PATCH).<br/>
    /// Default Value: auto_reply
    /// </summary>
    public enum AgentBehaviorDtoReplyPolicy
    {
        /// <summary>
        ///
        /// </summary>
        AutoReply,
        /// <summary>
        ///
        /// </summary>
        MentionOnly,
        /// <summary>
        ///
        /// </summary>
        Smart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentBehaviorDtoReplyPolicyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentBehaviorDtoReplyPolicy value)
        {
            return value switch
            {
                AgentBehaviorDtoReplyPolicy.AutoReply => "auto_reply",
                AgentBehaviorDtoReplyPolicy.MentionOnly => "mention_only",
                AgentBehaviorDtoReplyPolicy.Smart => "smart",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentBehaviorDtoReplyPolicy? ToEnum(string value)
        {
            return value switch
            {
                "auto_reply" => AgentBehaviorDtoReplyPolicy.AutoReply,
                "mention_only" => AgentBehaviorDtoReplyPolicy.MentionOnly,
                "smart" => AgentBehaviorDtoReplyPolicy.Smart,
                _ => null,
            };
        }
    }
}