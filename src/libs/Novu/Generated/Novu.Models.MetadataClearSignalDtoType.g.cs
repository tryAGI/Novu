
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum MetadataClearSignalDtoType
    {
        /// <summary>
        ///
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataClearSignalDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataClearSignalDtoType value)
        {
            return value switch
            {
                MetadataClearSignalDtoType.Metadata => "metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataClearSignalDtoType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => MetadataClearSignalDtoType.Metadata,
                _ => null,
            };
        }
    }
}