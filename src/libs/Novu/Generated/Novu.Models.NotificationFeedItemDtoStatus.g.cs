
#nullable enable

namespace Novu
{
    /// <summary>
    /// Current status of the notification.<br/>
    /// Example: sent
    /// </summary>
    public enum NotificationFeedItemDtoStatus
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
    public static class NotificationFeedItemDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotificationFeedItemDtoStatus value)
        {
            return value switch
            {
                NotificationFeedItemDtoStatus.Error => "error",
                NotificationFeedItemDtoStatus.Sent => "sent",
                NotificationFeedItemDtoStatus.Warning => "warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotificationFeedItemDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => NotificationFeedItemDtoStatus.Error,
                "sent" => NotificationFeedItemDtoStatus.Sent,
                "warning" => NotificationFeedItemDtoStatus.Warning,
                _ => null,
            };
        }
    }
}