
#nullable enable

namespace Novu
{
    /// <summary>
    /// PagerDuty account region — determines the events API data-center endpoint.<br/>
    /// Example: us
    /// </summary>
    public enum PagerDutyServiceEndpointDtoRegion
    {
        /// <summary>
        /// 
        /// </summary>
        Eu,
        /// <summary>
        /// 
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PagerDutyServiceEndpointDtoRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PagerDutyServiceEndpointDtoRegion value)
        {
            return value switch
            {
                PagerDutyServiceEndpointDtoRegion.Eu => "eu",
                PagerDutyServiceEndpointDtoRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PagerDutyServiceEndpointDtoRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => PagerDutyServiceEndpointDtoRegion.Eu,
                "us" => PagerDutyServiceEndpointDtoRegion.Us,
                _ => null,
            };
        }
    }
}