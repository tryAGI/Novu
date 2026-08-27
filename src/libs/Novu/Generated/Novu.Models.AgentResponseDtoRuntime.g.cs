
#nullable enable

namespace Novu
{
    /// <summary>
    /// Whether the agent brain is self-hosted (bridge) or managed by a third-party provider
    /// </summary>
    public enum AgentResponseDtoRuntime
    {
        /// <summary>
        ///
        /// </summary>
        Managed,
        /// <summary>
        ///
        /// </summary>
        SelfHosted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoRuntime value)
        {
            return value switch
            {
                AgentResponseDtoRuntime.Managed => "managed",
                AgentResponseDtoRuntime.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoRuntime? ToEnum(string value)
        {
            return value switch
            {
                "managed" => AgentResponseDtoRuntime.Managed,
                "self-hosted" => AgentResponseDtoRuntime.SelfHosted,
                _ => null,
            };
        }
    }
}