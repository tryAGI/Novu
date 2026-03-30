
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscribersControllerGetSubscriberNotificationsSeverityItem
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscribersControllerGetSubscriberNotificationsSeverityItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscribersControllerGetSubscriberNotificationsSeverityItem value)
        {
            return value switch
            {
                SubscribersControllerGetSubscriberNotificationsSeverityItem.High => "high",
                SubscribersControllerGetSubscriberNotificationsSeverityItem.Low => "low",
                SubscribersControllerGetSubscriberNotificationsSeverityItem.Medium => "medium",
                SubscribersControllerGetSubscriberNotificationsSeverityItem.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscribersControllerGetSubscriberNotificationsSeverityItem? ToEnum(string value)
        {
            return value switch
            {
                "high" => SubscribersControllerGetSubscriberNotificationsSeverityItem.High,
                "low" => SubscribersControllerGetSubscriberNotificationsSeverityItem.Low,
                "medium" => SubscribersControllerGetSubscriberNotificationsSeverityItem.Medium,
                "none" => SubscribersControllerGetSubscriberNotificationsSeverityItem.None,
                _ => null,
            };
        }
    }
}