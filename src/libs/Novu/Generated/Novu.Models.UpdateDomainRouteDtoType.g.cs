
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateDomainRouteDtoType
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
    public static class UpdateDomainRouteDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateDomainRouteDtoType value)
        {
            return value switch
            {
                UpdateDomainRouteDtoType.Agent => "agent",
                UpdateDomainRouteDtoType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateDomainRouteDtoType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => UpdateDomainRouteDtoType.Agent,
                "webhook" => UpdateDomainRouteDtoType.Webhook,
                _ => null,
            };
        }
    }
}