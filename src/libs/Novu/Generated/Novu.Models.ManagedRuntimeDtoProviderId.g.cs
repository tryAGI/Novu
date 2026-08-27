
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum ManagedRuntimeDtoProviderId
    {
        /// <summary>
        ///
        /// </summary>
        Anthropic,
        /// <summary>
        ///
        /// </summary>
        AnthropicAws,
        /// <summary>
        ///
        /// </summary>
        NovuAnthropic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManagedRuntimeDtoProviderIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManagedRuntimeDtoProviderId value)
        {
            return value switch
            {
                ManagedRuntimeDtoProviderId.Anthropic => "anthropic",
                ManagedRuntimeDtoProviderId.AnthropicAws => "anthropic-aws",
                ManagedRuntimeDtoProviderId.NovuAnthropic => "novu-anthropic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManagedRuntimeDtoProviderId? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ManagedRuntimeDtoProviderId.Anthropic,
                "anthropic-aws" => ManagedRuntimeDtoProviderId.AnthropicAws,
                "novu-anthropic" => ManagedRuntimeDtoProviderId.NovuAnthropic,
                _ => null,
            };
        }
    }
}