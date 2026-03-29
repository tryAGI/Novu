
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of the email block
    /// </summary>
    public enum EmailBlockTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Button,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmailBlockTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmailBlockTypeEnum value)
        {
            return value switch
            {
                EmailBlockTypeEnum.Button => "button",
                EmailBlockTypeEnum.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmailBlockTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "button" => EmailBlockTypeEnum.Button,
                "text" => EmailBlockTypeEnum.Text,
                _ => null,
            };
        }
    }
}