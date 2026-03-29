
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DelayScheduledMetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DelayScheduledMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DelayScheduledMetadataType value)
        {
            return value switch
            {
                DelayScheduledMetadataType.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DelayScheduledMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "scheduled" => DelayScheduledMetadataType.Scheduled,
                _ => null,
            };
        }
    }
}