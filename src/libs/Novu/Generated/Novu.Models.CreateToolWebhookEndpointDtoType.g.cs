
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: tool_webhook
    /// </summary>
    public enum CreateToolWebhookEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateToolWebhookEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateToolWebhookEndpointDtoType value)
        {
            return value switch
            {
                CreateToolWebhookEndpointDtoType.ToolWebhook => "tool_webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateToolWebhookEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "tool_webhook" => CreateToolWebhookEndpointDtoType.ToolWebhook,
                _ => null,
            };
        }
    }
}