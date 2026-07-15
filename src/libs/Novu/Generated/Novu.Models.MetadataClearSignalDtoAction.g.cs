
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetadataClearSignalDtoAction
    {
        /// <summary>
        /// 
        /// </summary>
        Clear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataClearSignalDtoActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataClearSignalDtoAction value)
        {
            return value switch
            {
                MetadataClearSignalDtoAction.Clear => "clear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataClearSignalDtoAction? ToEnum(string value)
        {
            return value switch
            {
                "clear" => MetadataClearSignalDtoAction.Clear,
                _ => null,
            };
        }
    }
}