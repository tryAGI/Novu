
#nullable enable

namespace Novu
{
    /// <summary>
    /// Text alignment for the email block
    /// </summary>
    public enum TextAlignEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Center,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextAlignEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextAlignEnum value)
        {
            return value switch
            {
                TextAlignEnum.Center => "center",
                TextAlignEnum.Left => "left",
                TextAlignEnum.Right => "right",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextAlignEnum? ToEnum(string value)
        {
            return value switch
            {
                "center" => TextAlignEnum.Center,
                "left" => TextAlignEnum.Left,
                "right" => TextAlignEnum.Right,
                _ => null,
            };
        }
    }
}