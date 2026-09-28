
#nullable enable

namespace Novu
{
    /// <summary>
    /// Variable value type
    /// </summary>
    public enum TemplateVariableTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Array,
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TemplateVariableTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TemplateVariableTypeEnum value)
        {
            return value switch
            {
                TemplateVariableTypeEnum.Array => "Array",
                TemplateVariableTypeEnum.Boolean => "Boolean",
                TemplateVariableTypeEnum.String => "String",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TemplateVariableTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "Array" => TemplateVariableTypeEnum.Array,
                "Boolean" => TemplateVariableTypeEnum.Boolean,
                "String" => TemplateVariableTypeEnum.String,
                _ => null,
            };
        }
    }
}