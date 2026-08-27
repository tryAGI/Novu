
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum TriggerSignalDtoType
    {
        /// <summary>
        ///
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TriggerSignalDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TriggerSignalDtoType value)
        {
            return value switch
            {
                TriggerSignalDtoType.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TriggerSignalDtoType? ToEnum(string value)
        {
            return value switch
            {
                "trigger" => TriggerSignalDtoType.Trigger,
                _ => null,
            };
        }
    }
}