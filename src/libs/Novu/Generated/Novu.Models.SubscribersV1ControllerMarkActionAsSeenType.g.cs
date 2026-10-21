
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscribersV1ControllerMarkActionAsSeenType
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
    public static class SubscribersV1ControllerMarkActionAsSeenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscribersV1ControllerMarkActionAsSeenType value)
        {
            return value switch
            {
                SubscribersV1ControllerMarkActionAsSeenType.Primary => "primary",
                SubscribersV1ControllerMarkActionAsSeenType.Secondary => "secondary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscribersV1ControllerMarkActionAsSeenType? ToEnum(string value)
        {
            return value switch
            {
                "primary" => SubscribersV1ControllerMarkActionAsSeenType.Primary,
                "secondary" => SubscribersV1ControllerMarkActionAsSeenType.Secondary,
                _ => null,
            };
        }
    }
}