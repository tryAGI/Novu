
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetadataDeleteSignalDtoAction
    {
        /// <summary>
        /// 
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataDeleteSignalDtoActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataDeleteSignalDtoAction value)
        {
            return value switch
            {
                MetadataDeleteSignalDtoAction.Delete => "delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataDeleteSignalDtoAction? ToEnum(string value)
        {
            return value switch
            {
                "delete" => MetadataDeleteSignalDtoAction.Delete,
                _ => null,
            };
        }
    }
}