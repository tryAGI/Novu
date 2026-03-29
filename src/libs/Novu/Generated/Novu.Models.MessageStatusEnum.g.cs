
#nullable enable

namespace Novu
{
    /// <summary>
    /// Status of the message
    /// </summary>
    public enum MessageStatusEnum
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
    public static class MessageStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStatusEnum value)
        {
            return value switch
            {
                MessageStatusEnum.Error => "error",
                MessageStatusEnum.Sent => "sent",
                MessageStatusEnum.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "error" => MessageStatusEnum.Error,
                "sent" => MessageStatusEnum.Sent,
                "warning" => MessageStatusEnum.Warning,
                _ => null,
            };
        }
    }
}