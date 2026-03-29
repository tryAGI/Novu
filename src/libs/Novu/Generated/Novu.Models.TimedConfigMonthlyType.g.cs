
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimedConfigMonthlyType
    {
        /// <summary>
        /// 
        /// </summary>
        Each,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimedConfigMonthlyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimedConfigMonthlyType value)
        {
            return value switch
            {
                TimedConfigMonthlyType.Each => "each",
                TimedConfigMonthlyType.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimedConfigMonthlyType? ToEnum(string value)
        {
            return value switch
            {
                "each" => TimedConfigMonthlyType.Each,
                "on" => TimedConfigMonthlyType.On,
                _ => null,
            };
        }
    }
}