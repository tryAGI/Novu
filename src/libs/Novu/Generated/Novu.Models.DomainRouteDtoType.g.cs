
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DomainRouteDtoType
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
    public static class DomainRouteDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DomainRouteDtoType value)
        {
            return value switch
            {
                DomainRouteDtoType.Agent => "agent",
                DomainRouteDtoType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DomainRouteDtoType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => DomainRouteDtoType.Agent,
                "webhook" => DomainRouteDtoType.Webhook,
                _ => null,
            };
        }
    }
}