
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotificationTriggerType
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotificationTriggerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotificationTriggerType value)
        {
            return value switch
            {
                NotificationTriggerType.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotificationTriggerType? ToEnum(string value)
        {
            return value switch
            {
                "event" => NotificationTriggerType.Event,
                _ => null,
            };
        }
    }
}