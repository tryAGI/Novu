
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of button for the action result
    /// </summary>
    public enum ButtonTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Primary,
        /// <summary>
        /// 
        /// </summary>
        Secondary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ButtonTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ButtonTypeEnum value)
        {
            return value switch
            {
                ButtonTypeEnum.Primary => "primary",
                ButtonTypeEnum.Secondary => "secondary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ButtonTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "primary" => ButtonTypeEnum.Primary,
                "secondary" => ButtonTypeEnum.Secondary,
                _ => null,
            };
        }
    }
}