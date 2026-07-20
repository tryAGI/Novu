
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: pagerduty_service
    /// </summary>
    public enum CreatePagerDutyServiceEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        PagerdutyService,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreatePagerDutyServiceEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePagerDutyServiceEndpointDtoType value)
        {
            return value switch
            {
                CreatePagerDutyServiceEndpointDtoType.PagerdutyService => "pagerduty_service",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePagerDutyServiceEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "pagerduty_service" => CreatePagerDutyServiceEndpointDtoType.PagerdutyService,
                _ => null,
            };
        }
    }
}