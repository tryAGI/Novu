
#nullable enable

namespace Novu
{
    /// <summary>
    /// Delivery status stored on the message
    /// </summary>
    public enum MessageWebhookStatusEnum
    {
        /// <summary>
        ///
        /// </summary>
        Error,
        /// <summary>
        ///
        /// </summary>
        Sent,
        /// <summary>
        ///
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageWebhookStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageWebhookStatusEnum value)
        {
            return value switch
            {
                MessageWebhookStatusEnum.Error => "error",
                MessageWebhookStatusEnum.Sent => "sent",
                MessageWebhookStatusEnum.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageWebhookStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "error" => MessageWebhookStatusEnum.Error,
                "sent" => MessageWebhookStatusEnum.Sent,
                "warning" => MessageWebhookStatusEnum.Warning,
                _ => null,
            };
        }
    }
}