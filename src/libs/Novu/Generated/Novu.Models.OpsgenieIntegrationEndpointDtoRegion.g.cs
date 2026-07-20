
#nullable enable

namespace Novu
{
    /// <summary>
    /// Opsgenie account region that determines the alert API data-center endpoint.<br/>
    /// Example: us
    /// </summary>
    public enum OpsgenieIntegrationEndpointDtoRegion
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
    public static class OpsgenieIntegrationEndpointDtoRegionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpsgenieIntegrationEndpointDtoRegion value)
        {
            return value switch
            {
                OpsgenieIntegrationEndpointDtoRegion.Eu => "eu",
                OpsgenieIntegrationEndpointDtoRegion.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpsgenieIntegrationEndpointDtoRegion? ToEnum(string value)
        {
            return value switch
            {
                "eu" => OpsgenieIntegrationEndpointDtoRegion.Eu,
                "us" => OpsgenieIntegrationEndpointDtoRegion.Us,
                _ => null,
            };
        }
    }
}