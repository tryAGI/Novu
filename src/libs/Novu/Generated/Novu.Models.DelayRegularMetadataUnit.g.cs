
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DelayRegularMetadataUnit
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
    public static class DelayRegularMetadataUnitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DelayRegularMetadataUnit value)
        {
            return value switch
            {
                DelayRegularMetadataUnit.Days => "days",
                DelayRegularMetadataUnit.Hours => "hours",
                DelayRegularMetadataUnit.Minutes => "minutes",
                DelayRegularMetadataUnit.Months => "months",
                DelayRegularMetadataUnit.Seconds => "seconds",
                DelayRegularMetadataUnit.Weeks => "weeks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DelayRegularMetadataUnit? ToEnum(string value)
        {
            return value switch
            {
                "days" => DelayRegularMetadataUnit.Days,
                "hours" => DelayRegularMetadataUnit.Hours,
                "minutes" => DelayRegularMetadataUnit.Minutes,
                "months" => DelayRegularMetadataUnit.Months,
                "seconds" => DelayRegularMetadataUnit.Seconds,
                "weeks" => DelayRegularMetadataUnit.Weeks,
                _ => null,
            };
        }
    }
}