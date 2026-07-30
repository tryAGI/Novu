
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: grafana_oncall_integration
    /// </summary>
    public enum CreateGrafanaOnCallIntegrationEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        GrafanaOncallIntegration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGrafanaOnCallIntegrationEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGrafanaOnCallIntegrationEndpointDtoType value)
        {
            return value switch
            {
                CreateGrafanaOnCallIntegrationEndpointDtoType.GrafanaOncallIntegration => "grafana_oncall_integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGrafanaOnCallIntegrationEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "grafana_oncall_integration" => CreateGrafanaOnCallIntegrationEndpointDtoType.GrafanaOncallIntegration,
                _ => null,
            };
        }
    }
}