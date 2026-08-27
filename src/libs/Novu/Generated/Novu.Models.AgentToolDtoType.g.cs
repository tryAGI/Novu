
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentToolDtoType
    {
        /// <summary>
        ///
        /// </summary>
        Builtin,
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolDtoType value)
        {
            return value switch
            {
                AgentToolDtoType.Builtin => "builtin",
                AgentToolDtoType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolDtoType? ToEnum(string value)
        {
            return value switch
            {
                "builtin" => AgentToolDtoType.Builtin,
                "custom" => AgentToolDtoType.Custom,
                _ => null,
            };
        }
    }
}