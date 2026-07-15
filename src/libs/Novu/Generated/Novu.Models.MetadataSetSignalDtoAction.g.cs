
#nullable enable

namespace Novu
{
    /// <summary>
    /// Defaults to `set` when omitted.<br/>
    /// Default Value: set
    /// </summary>
    public enum MetadataSetSignalDtoAction
    {
        /// <summary>
        /// 
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetadataSetSignalDtoActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetadataSetSignalDtoAction value)
        {
            return value switch
            {
                MetadataSetSignalDtoAction.Set => "set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetadataSetSignalDtoAction? ToEnum(string value)
        {
            return value switch
            {
                "set" => MetadataSetSignalDtoAction.Set,
                _ => null,
            };
        }
    }
}