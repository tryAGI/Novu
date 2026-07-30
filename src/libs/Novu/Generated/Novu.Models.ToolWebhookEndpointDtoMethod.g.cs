
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional HTTP method override for this webhook. Defaults to the integration-level method.<br/>
    /// Example: POST
    /// </summary>
    public enum ToolWebhookEndpointDtoMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Patch,
        /// <summary>
        /// 
        /// </summary>
        Post,
        /// <summary>
        /// 
        /// </summary>
        Put,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolWebhookEndpointDtoMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolWebhookEndpointDtoMethod value)
        {
            return value switch
            {
                ToolWebhookEndpointDtoMethod.Patch => "PATCH",
                ToolWebhookEndpointDtoMethod.Post => "POST",
                ToolWebhookEndpointDtoMethod.Put => "PUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolWebhookEndpointDtoMethod? ToEnum(string value)
        {
            return value switch
            {
                "PATCH" => ToolWebhookEndpointDtoMethod.Patch,
                "POST" => ToolWebhookEndpointDtoMethod.Post,
                "PUT" => ToolWebhookEndpointDtoMethod.Put,
                _ => null,
            };
        }
    }
}