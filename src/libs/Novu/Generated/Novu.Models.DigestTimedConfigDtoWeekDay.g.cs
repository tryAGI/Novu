
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DigestTimedConfigDtoWeekDay
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
    public static class DigestTimedConfigDtoWeekDayExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DigestTimedConfigDtoWeekDay value)
        {
            return value switch
            {
                DigestTimedConfigDtoWeekDay.Friday => "friday",
                DigestTimedConfigDtoWeekDay.Monday => "monday",
                DigestTimedConfigDtoWeekDay.Saturday => "saturday",
                DigestTimedConfigDtoWeekDay.Sunday => "sunday",
                DigestTimedConfigDtoWeekDay.Thursday => "thursday",
                DigestTimedConfigDtoWeekDay.Tuesday => "tuesday",
                DigestTimedConfigDtoWeekDay.Wednesday => "wednesday",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DigestTimedConfigDtoWeekDay? ToEnum(string value)
        {
            return value switch
            {
                "friday" => DigestTimedConfigDtoWeekDay.Friday,
                "monday" => DigestTimedConfigDtoWeekDay.Monday,
                "saturday" => DigestTimedConfigDtoWeekDay.Saturday,
                "sunday" => DigestTimedConfigDtoWeekDay.Sunday,
                "thursday" => DigestTimedConfigDtoWeekDay.Thursday,
                "tuesday" => DigestTimedConfigDtoWeekDay.Tuesday,
                "wednesday" => DigestTimedConfigDtoWeekDay.Wednesday,
                _ => null,
            };
        }
    }
}