
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetadataDeleteSignalDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataDeleteSignalDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataDeleteSignalDtoType value)
        {
            return value switch
            {
                MetadataDeleteSignalDtoType.Metadata => "metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataDeleteSignalDtoType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => MetadataDeleteSignalDtoType.Metadata,
                _ => null,
            };
        }
    }
}