
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainRouteResponseDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DomainRouteResponseDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainRouteResponseDtoType value)
        {
            return value switch
            {
                DomainRouteResponseDtoType.Agent => "agent",
                DomainRouteResponseDtoType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainRouteResponseDtoType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => DomainRouteResponseDtoType.Agent,
                "webhook" => DomainRouteResponseDtoType.Webhook,
                _ => null,
            };
        }
    }
}