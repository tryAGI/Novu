
#nullable enable

namespace Novu
{
    /// <summary>
    /// Trigger type
    /// </summary>
    public enum TriggerTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerTypeEnum value)
        {
            return value switch
            {
                TriggerTypeEnum.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "event" => TriggerTypeEnum.Event,
                _ => null,
            };
        }
    }
}