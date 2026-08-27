
#nullable enable

namespace Novu
{
    /// <summary>
    /// Distinguishes delivery integrations from agent-runtime integrations. Defaults to "delivery". Agent integrations do not require a channel.
    /// </summary>
    public enum CreateIntegrationRequestDtoKind
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Delivery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateIntegrationRequestDtoKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateIntegrationRequestDtoKind value)
        {
            return value switch
            {
                CreateIntegrationRequestDtoKind.Agent => "agent",
                CreateIntegrationRequestDtoKind.Delivery => "delivery",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateIntegrationRequestDtoKind? ToEnum(string value)
        {
            return value switch
            {
                "agent" => CreateIntegrationRequestDtoKind.Agent,
                "delivery" => CreateIntegrationRequestDtoKind.Delivery,
                _ => null,
            };
        }
    }
}