
#nullable enable

namespace Novu
{
    /// <summary>
    /// Unit of time for the look-back window.
    /// </summary>
    public enum LookBackWindowDtoUnit
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
    public static class LookBackWindowDtoUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LookBackWindowDtoUnit value)
        {
            return value switch
            {
                LookBackWindowDtoUnit.Days => "days",
                LookBackWindowDtoUnit.Hours => "hours",
                LookBackWindowDtoUnit.Minutes => "minutes",
                LookBackWindowDtoUnit.Months => "months",
                LookBackWindowDtoUnit.Seconds => "seconds",
                LookBackWindowDtoUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LookBackWindowDtoUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => LookBackWindowDtoUnit.Days,
                "hours" => LookBackWindowDtoUnit.Hours,
                "minutes" => LookBackWindowDtoUnit.Minutes,
                "months" => LookBackWindowDtoUnit.Months,
                "seconds" => LookBackWindowDtoUnit.Seconds,
                "weeks" => LookBackWindowDtoUnit.Weeks,
                _ => null,
            };
        }
    }
}