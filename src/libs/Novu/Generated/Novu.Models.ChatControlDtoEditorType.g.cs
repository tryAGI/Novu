
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of editor to use for the body. When omitted, inferred from the body: Maily JSON is "block", otherwise "text".
    /// </summary>
    public enum ChatControlDtoEditorType
    {
        /// <summary>
        /// Maily JSON is "block", otherwise "text".
        /// </summary>
        Block,
        /// <summary>
        /// Maily JSON is "block", otherwise "text".
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatControlDtoEditorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatControlDtoEditorType value)
        {
            return value switch
            {
                ChatControlDtoEditorType.Block => "block",
                ChatControlDtoEditorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatControlDtoEditorType? ToEnum(string value)
        {
            return value switch
            {
                "block" => ChatControlDtoEditorType.Block,
                "text" => ChatControlDtoEditorType.Text,
                _ => null,
            };
        }
    }
}