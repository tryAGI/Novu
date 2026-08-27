
#nullable enable

namespace Novu
{
    /// <summary>
    /// Discovery scope of the agent. Always `public` today; reserved for the upcoming private-agents feature.
    /// </summary>
    public enum AgentResponseDtoVisibility
    {
        /// <summary>
        ///
        /// </summary>
        Private,
        /// <summary>
        ///
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVisibility value)
        {
            return value switch
            {
                AgentResponseDtoVisibility.Private => "private",
                AgentResponseDtoVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => AgentResponseDtoVisibility.Private,
                "public" => AgentResponseDtoVisibility.Public,
                _ => null,
            };
        }
    }
}