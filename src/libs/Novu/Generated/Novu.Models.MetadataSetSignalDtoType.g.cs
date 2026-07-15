
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetadataSetSignalDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Metadata,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSetSignalDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSetSignalDtoType value)
        {
            return value switch
            {
                MetadataSetSignalDtoType.Metadata => "metadata",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSetSignalDtoType? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => MetadataSetSignalDtoType.Metadata,
                _ => null,
            };
        }
    }
}