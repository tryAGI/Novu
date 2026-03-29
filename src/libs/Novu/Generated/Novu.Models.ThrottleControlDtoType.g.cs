
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of throttle window.<br/>
    /// Default Value: fixed
    /// </summary>
    public enum ThrottleControlDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Dynamic,
        /// <summary>
        /// 
        /// </summary>
        Fixed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ThrottleControlDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ThrottleControlDtoType value)
        {
            return value switch
            {
                ThrottleControlDtoType.Dynamic => "dynamic",
                ThrottleControlDtoType.Fixed => "fixed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ThrottleControlDtoType? ToEnum(string value)
        {
            return value switch
            {
                "dynamic" => ThrottleControlDtoType.Dynamic,
                "fixed" => ThrottleControlDtoType.Fixed,
                _ => null,
            };
        }
    }
}