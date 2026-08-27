
#nullable enable

namespace Novu
{
    /// <summary>
    /// Distinguishes delivery integrations from agent-runtime integrations. Defaults to "delivery". Agent integrations do not have a channel.
    /// </summary>
    public enum IntegrationResponseDtoKind
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
    public static class IntegrationResponseDtoKindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationResponseDtoKind value)
        {
            return value switch
            {
                IntegrationResponseDtoKind.Agent => "agent",
                IntegrationResponseDtoKind.Delivery => "delivery",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationResponseDtoKind? ToEnum(string value)
        {
            return value switch
            {
                "agent" => IntegrationResponseDtoKind.Agent,
                "delivery" => IntegrationResponseDtoKind.Delivery,
                _ => null,
            };
        }
    }
}