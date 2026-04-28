
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TestDomainRouteResponseDtoType
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
    public static class TestDomainRouteResponseDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestDomainRouteResponseDtoType value)
        {
            return value switch
            {
                TestDomainRouteResponseDtoType.Agent => "agent",
                TestDomainRouteResponseDtoType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestDomainRouteResponseDtoType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => TestDomainRouteResponseDtoType.Agent,
                "webhook" => TestDomainRouteResponseDtoType.Webhook,
                _ => null,
            };
        }
    }
}