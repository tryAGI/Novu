
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentSkillInputDtoType
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentSkillInputDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentSkillInputDtoType value)
        {
            return value switch
            {
                AgentSkillInputDtoType.Anthropic => "anthropic",
                AgentSkillInputDtoType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentSkillInputDtoType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AgentSkillInputDtoType.Anthropic,
                "custom" => AgentSkillInputDtoType.Custom,
                _ => null,
            };
        }
    }
}