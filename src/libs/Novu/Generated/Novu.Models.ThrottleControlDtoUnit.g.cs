
#nullable enable

namespace Novu
{
    /// <summary>
    /// The unit of time for the throttle window (required for fixed type).
    /// </summary>
    public enum ThrottleControlDtoUnit
    {
        /// <summary>
        /// 
        /// </summary>
        Days,
        /// <summary>
        /// 
        /// </summary>
        Hours,
        /// <summary>
        /// 
        /// </summary>
        Minutes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThrottleControlDtoUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThrottleControlDtoUnit value)
        {
            return value switch
            {
                ThrottleControlDtoUnit.Days => "days",
                ThrottleControlDtoUnit.Hours => "hours",
                ThrottleControlDtoUnit.Minutes => "minutes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThrottleControlDtoUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => ThrottleControlDtoUnit.Days,
                "hours" => ThrottleControlDtoUnit.Hours,
                "minutes" => ThrottleControlDtoUnit.Minutes,
                _ => null,
            };
        }
    }
}