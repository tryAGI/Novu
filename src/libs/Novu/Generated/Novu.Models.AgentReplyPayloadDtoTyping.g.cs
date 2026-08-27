
#nullable enable

namespace Novu
{
    /// <summary>
    /// Clear the typing indicator.
    /// </summary>
    public enum AgentReplyPayloadDtoTyping
    {
        /// <summary>
        ///
        /// </summary>
        Stop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentReplyPayloadDtoTypingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentReplyPayloadDtoTyping value)
        {
            return value switch
            {
                AgentReplyPayloadDtoTyping.Stop => "stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentReplyPayloadDtoTyping? ToEnum(string value)
        {
            return value switch
            {
                "stop" => AgentReplyPayloadDtoTyping.Stop,
                _ => null,
            };
        }
    }
}