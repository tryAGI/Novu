
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of channel endpoint<br/>
    /// Example: webhook
    /// </summary>
    public enum CreateWebhookEndpointDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateWebhookEndpointDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateWebhookEndpointDtoType value)
        {
            return value switch
            {
                CreateWebhookEndpointDtoType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateWebhookEndpointDtoType? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => CreateWebhookEndpointDtoType.Webhook,
                _ => null,
            };
        }
    }
}