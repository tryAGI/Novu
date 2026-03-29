
#nullable enable

namespace Novu
{
    /// <summary>
    /// Editor type of the layout.
    /// </summary>
    public enum EmailControlsDtoEditorType
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
    public static class EmailControlsDtoEditorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailControlsDtoEditorType value)
        {
            return value switch
            {
                EmailControlsDtoEditorType.Block => "block",
                EmailControlsDtoEditorType.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailControlsDtoEditorType? ToEnum(string value)
        {
            return value switch
            {
                "block" => EmailControlsDtoEditorType.Block,
                "html" => EmailControlsDtoEditorType.Html,
                _ => null,
            };
        }
    }
}