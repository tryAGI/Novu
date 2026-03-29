
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimedConfigWeekDay
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimedConfigWeekDayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimedConfigWeekDay value)
        {
            return value switch
            {
                TimedConfigWeekDay.Friday => "friday",
                TimedConfigWeekDay.Monday => "monday",
                TimedConfigWeekDay.Saturday => "saturday",
                TimedConfigWeekDay.Sunday => "sunday",
                TimedConfigWeekDay.Thursday => "thursday",
                TimedConfigWeekDay.Tuesday => "tuesday",
                TimedConfigWeekDay.Wednesday => "wednesday",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimedConfigWeekDay? ToEnum(string value)
        {
            return value switch
            {
                "friday" => TimedConfigWeekDay.Friday,
                "monday" => TimedConfigWeekDay.Monday,
                "saturday" => TimedConfigWeekDay.Saturday,
                "sunday" => TimedConfigWeekDay.Sunday,
                "thursday" => TimedConfigWeekDay.Thursday,
                "tuesday" => TimedConfigWeekDay.Tuesday,
                "wednesday" => TimedConfigWeekDay.Wednesday,
                _ => null,
            };
        }
    }
}