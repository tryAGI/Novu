
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: opsgenie_integration
    /// </summary>
    public enum CreateOpsgenieIntegrationEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        OpsgenieIntegration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOpsgenieIntegrationEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOpsgenieIntegrationEndpointDtoType value)
        {
            return value switch
            {
                CreateOpsgenieIntegrationEndpointDtoType.OpsgenieIntegration => "opsgenie_integration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOpsgenieIntegrationEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "opsgenie_integration" => CreateOpsgenieIntegrationEndpointDtoType.OpsgenieIntegration,
                _ => null,
            };
        }
    }
}