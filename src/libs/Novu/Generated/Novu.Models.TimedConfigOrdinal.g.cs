
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum TimedConfigOrdinal
    {
        /// <summary>
        /// 
        /// </summary>
        x1,
        /// <summary>
        /// 
        /// </summary>
        x2,
        /// <summary>
        /// 
        /// </summary>
        x3,
        /// <summary>
        /// 
        /// </summary>
        x4,
        /// <summary>
        /// 
        /// </summary>
        x5,
        /// <summary>
        /// 
        /// </summary>
        Last,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TimedConfigOrdinalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimedConfigOrdinal value)
        {
            return value switch
            {
                TimedConfigOrdinal.x1 => "1",
                TimedConfigOrdinal.x2 => "2",
                TimedConfigOrdinal.x3 => "3",
                TimedConfigOrdinal.x4 => "4",
                TimedConfigOrdinal.x5 => "5",
                TimedConfigOrdinal.Last => "last",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimedConfigOrdinal? ToEnum(string value)
        {
            return value switch
            {
                "1" => TimedConfigOrdinal.x1,
                "2" => TimedConfigOrdinal.x2,
                "3" => TimedConfigOrdinal.x3,
                "4" => TimedConfigOrdinal.x4,
                "5" => TimedConfigOrdinal.x5,
                "last" => TimedConfigOrdinal.Last,
                _ => null,
            };
        }
    }
}