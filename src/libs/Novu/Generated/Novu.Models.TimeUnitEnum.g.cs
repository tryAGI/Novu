
#nullable enable

namespace Novu
{
    /// <summary>
    /// Time unit
    /// </summary>
    public enum TimeUnitEnum
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
        /// <summary>
        /// 
        /// </summary>
        Months,
        /// <summary>
        /// 
        /// </summary>
        Seconds,
        /// <summary>
        /// 
        /// </summary>
        Weeks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimeUnitEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimeUnitEnum value)
        {
            return value switch
            {
                TimeUnitEnum.Days => "days",
                TimeUnitEnum.Hours => "hours",
                TimeUnitEnum.Minutes => "minutes",
                TimeUnitEnum.Months => "months",
                TimeUnitEnum.Seconds => "seconds",
                TimeUnitEnum.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimeUnitEnum? ToEnum(string value)
        {
            return value switch
            {
                "days" => TimeUnitEnum.Days,
                "hours" => TimeUnitEnum.Hours,
                "minutes" => TimeUnitEnum.Minutes,
                "months" => TimeUnitEnum.Months,
                "seconds" => TimeUnitEnum.Seconds,
                "weeks" => TimeUnitEnum.Weeks,
                _ => null,
            };
        }
    }
}