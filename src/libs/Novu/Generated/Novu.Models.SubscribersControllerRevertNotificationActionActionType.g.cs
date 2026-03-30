
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscribersControllerRevertNotificationActionActionType
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
    public static class SubscribersControllerRevertNotificationActionActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscribersControllerRevertNotificationActionActionType value)
        {
            return value switch
            {
                SubscribersControllerRevertNotificationActionActionType.Primary => "primary",
                SubscribersControllerRevertNotificationActionActionType.Secondary => "secondary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscribersControllerRevertNotificationActionActionType? ToEnum(string value)
        {
            return value switch
            {
                "primary" => SubscribersControllerRevertNotificationActionActionType.Primary,
                "secondary" => SubscribersControllerRevertNotificationActionActionType.Secondary,
                _ => null,
            };
        }
    }
}