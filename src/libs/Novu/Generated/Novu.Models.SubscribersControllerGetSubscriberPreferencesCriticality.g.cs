
#nullable enable

namespace Novu
{
    /// <summary>
    /// Default Value: nonCritical
    /// </summary>
    public enum SubscribersControllerGetSubscriberPreferencesCriticality
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        NonCritical,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscribersControllerGetSubscriberPreferencesCriticalityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscribersControllerGetSubscriberPreferencesCriticality value)
        {
            return value switch
            {
                SubscribersControllerGetSubscriberPreferencesCriticality.All => "all",
                SubscribersControllerGetSubscriberPreferencesCriticality.Critical => "critical",
                SubscribersControllerGetSubscriberPreferencesCriticality.NonCritical => "nonCritical",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscribersControllerGetSubscriberPreferencesCriticality? ToEnum(string value)
        {
            return value switch
            {
                "all" => SubscribersControllerGetSubscriberPreferencesCriticality.All,
                "critical" => SubscribersControllerGetSubscriberPreferencesCriticality.Critical,
                "nonCritical" => SubscribersControllerGetSubscriberPreferencesCriticality.NonCritical,
                _ => null,
            };
        }
    }
}