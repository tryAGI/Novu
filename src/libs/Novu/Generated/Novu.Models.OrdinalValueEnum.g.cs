
#nullable enable

namespace Novu
{
    /// <summary>
    /// Value of the ordinal
    /// </summary>
    public enum OrdinalValueEnum
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
    public static class OrdinalValueEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrdinalValueEnum value)
        {
            return value switch
            {
                OrdinalValueEnum.Day => "day",
                OrdinalValueEnum.Friday => "friday",
                OrdinalValueEnum.Monday => "monday",
                OrdinalValueEnum.Saturday => "saturday",
                OrdinalValueEnum.Sunday => "sunday",
                OrdinalValueEnum.Thursday => "thursday",
                OrdinalValueEnum.Tuesday => "tuesday",
                OrdinalValueEnum.Wednesday => "wednesday",
                OrdinalValueEnum.Weekday => "weekday",
                OrdinalValueEnum.Weekend => "weekend",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrdinalValueEnum? ToEnum(string value)
        {
            return value switch
            {
                "day" => OrdinalValueEnum.Day,
                "friday" => OrdinalValueEnum.Friday,
                "monday" => OrdinalValueEnum.Monday,
                "saturday" => OrdinalValueEnum.Saturday,
                "sunday" => OrdinalValueEnum.Sunday,
                "thursday" => OrdinalValueEnum.Thursday,
                "tuesday" => OrdinalValueEnum.Tuesday,
                "wednesday" => OrdinalValueEnum.Wednesday,
                "weekday" => OrdinalValueEnum.Weekday,
                "weekend" => OrdinalValueEnum.Weekend,
                _ => null,
            };
        }
    }
}