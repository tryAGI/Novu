
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of editor to use for the body.<br/>
    /// Default Value: block
    /// </summary>
    public enum EmailControlDtoEditorType
    {
        /// <summary>
        /// 
        /// </summary>
        Block,
        /// <summary>
        /// 
        /// </summary>
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailControlDtoEditorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailControlDtoEditorType value)
        {
            return value switch
            {
                EmailControlDtoEditorType.Block => "block",
                EmailControlDtoEditorType.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailControlDtoEditorType? ToEnum(string value)
        {
            return value switch
            {
                "block" => EmailControlDtoEditorType.Block,
                "html" => EmailControlDtoEditorType.Html,
                _ => null,
            };
        }
    }
}