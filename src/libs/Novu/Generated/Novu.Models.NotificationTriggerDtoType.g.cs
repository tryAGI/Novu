
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of the trigger
    /// </summary>
    public enum NotificationTriggerDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NotificationTriggerDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NotificationTriggerDtoType value)
        {
            return value switch
            {
                NotificationTriggerDtoType.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NotificationTriggerDtoType? ToEnum(string value)
        {
            return value switch
            {
                "event" => NotificationTriggerDtoType.Event,
                _ => null,
            };
        }
    }
}