
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscribersControllerCompleteNotificationActionActionType
    {
        /// <summary>
        /// 
        /// </summary>
        Primary,
        /// <summary>
        /// 
        /// </summary>
        Secondary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscribersControllerCompleteNotificationActionActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscribersControllerCompleteNotificationActionActionType value)
        {
            return value switch
            {
                SubscribersControllerCompleteNotificationActionActionType.Primary => "primary",
                SubscribersControllerCompleteNotificationActionActionType.Secondary => "secondary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscribersControllerCompleteNotificationActionActionType? ToEnum(string value)
        {
            return value switch
            {
                "primary" => SubscribersControllerCompleteNotificationActionActionType.Primary,
                "secondary" => SubscribersControllerCompleteNotificationActionActionType.Secondary,
                _ => null,
            };
        }
    }
}