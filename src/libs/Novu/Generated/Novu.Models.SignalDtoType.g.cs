
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum SignalDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
        /// <summary>
        /// 
        /// </summary>
        Trigger,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SignalDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SignalDtoType value)
        {
            return value switch
            {
                SignalDtoType.Metadata => "metadata",
                SignalDtoType.Trigger => "trigger",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SignalDtoType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => SignalDtoType.Metadata,
                "trigger" => SignalDtoType.Trigger,
                _ => null,
            };
        }
    }
}