
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimedConfigOrdinalValue
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Friday,
        /// <summary>
        /// 
        /// </summary>
        Monday,
        /// <summary>
        /// 
        /// </summary>
        Saturday,
        /// <summary>
        /// 
        /// </summary>
        Sunday,
        /// <summary>
        /// 
        /// </summary>
        Thursday,
        /// <summary>
        /// 
        /// </summary>
        Tuesday,
        /// <summary>
        /// 
        /// </summary>
        Wednesday,
        /// <summary>
        /// 
        /// </summary>
        Weekday,
        /// <summary>
        /// 
        /// </summary>
        Weekend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimedConfigOrdinalValueExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimedConfigOrdinalValue value)
        {
            return value switch
            {
                TimedConfigOrdinalValue.Day => "day",
                TimedConfigOrdinalValue.Friday => "friday",
                TimedConfigOrdinalValue.Monday => "monday",
                TimedConfigOrdinalValue.Saturday => "saturday",
                TimedConfigOrdinalValue.Sunday => "sunday",
                TimedConfigOrdinalValue.Thursday => "thursday",
                TimedConfigOrdinalValue.Tuesday => "tuesday",
                TimedConfigOrdinalValue.Wednesday => "wednesday",
                TimedConfigOrdinalValue.Weekday => "weekday",
                TimedConfigOrdinalValue.Weekend => "weekend",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimedConfigOrdinalValue? ToEnum(string value)
        {
            return value switch
            {
                "day" => TimedConfigOrdinalValue.Day,
                "friday" => TimedConfigOrdinalValue.Friday,
                "monday" => TimedConfigOrdinalValue.Monday,
                "saturday" => TimedConfigOrdinalValue.Saturday,
                "sunday" => TimedConfigOrdinalValue.Sunday,
                "thursday" => TimedConfigOrdinalValue.Thursday,
                "tuesday" => TimedConfigOrdinalValue.Tuesday,
                "wednesday" => TimedConfigOrdinalValue.Wednesday,
                "weekday" => TimedConfigOrdinalValue.Weekday,
                "weekend" => TimedConfigOrdinalValue.Weekend,
                _ => null,
            };
        }
    }
}