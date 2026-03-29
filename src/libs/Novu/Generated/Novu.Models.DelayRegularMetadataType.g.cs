
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum DelayRegularMetadataType
    {
        /// <summary>
        /// 
        /// </summary>
        Regular,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DelayRegularMetadataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DelayRegularMetadataType value)
        {
            return value switch
            {
                DelayRegularMetadataType.Regular => "regular",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DelayRegularMetadataType? ToEnum(string value)
        {
            return value switch
            {
                "regular" => DelayRegularMetadataType.Regular,
                _ => null,
            };
        }
    }
}