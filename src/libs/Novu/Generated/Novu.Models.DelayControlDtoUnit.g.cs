
#nullable enable

namespace Novu
{
    /// <summary>
    /// Unit of time for the delay amount.
    /// </summary>
    public enum DelayControlDtoUnit
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
    public static class DelayControlDtoUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DelayControlDtoUnit value)
        {
            return value switch
            {
                DelayControlDtoUnit.Days => "days",
                DelayControlDtoUnit.Hours => "hours",
                DelayControlDtoUnit.Minutes => "minutes",
                DelayControlDtoUnit.Months => "months",
                DelayControlDtoUnit.Seconds => "seconds",
                DelayControlDtoUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DelayControlDtoUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => DelayControlDtoUnit.Days,
                "hours" => DelayControlDtoUnit.Hours,
                "minutes" => DelayControlDtoUnit.Minutes,
                "months" => DelayControlDtoUnit.Months,
                "seconds" => DelayControlDtoUnit.Seconds,
                "weeks" => DelayControlDtoUnit.Weeks,
                _ => null,
            };
        }
    }
}