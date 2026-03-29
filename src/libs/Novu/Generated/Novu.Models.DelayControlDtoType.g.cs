
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of the delay. Currently only 'regular' is supported by the schema.<br/>
    /// Default Value: regular
    /// </summary>
    public enum DelayControlDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Regular,
        /// <summary>
        /// 
        /// </summary>
        Timed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DelayControlDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DelayControlDtoType value)
        {
            return value switch
            {
                DelayControlDtoType.Regular => "regular",
                DelayControlDtoType.Timed => "timed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DelayControlDtoType? ToEnum(string value)
        {
            return value switch
            {
                "regular" => DelayControlDtoType.Regular,
                "timed" => DelayControlDtoType.Timed,
                _ => null,
            };
        }
    }
}