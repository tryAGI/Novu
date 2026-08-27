
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateAgentRequestDtoRuntime
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
    public static class CreateAgentRequestDtoRuntimeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentRequestDtoRuntime value)
        {
            return value switch
            {
                CreateAgentRequestDtoRuntime.Managed => "managed",
                CreateAgentRequestDtoRuntime.SelfHosted => "self-hosted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentRequestDtoRuntime? ToEnum(string value)
        {
            return value switch
            {
                "managed" => CreateAgentRequestDtoRuntime.Managed,
                "self-hosted" => CreateAgentRequestDtoRuntime.SelfHosted,
                _ => null,
            };
        }
    }
}