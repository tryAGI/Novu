
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuilderFieldTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        Group,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        MultiList,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Statement,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuilderFieldTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuilderFieldTypeEnum value)
        {
            return value switch
            {
                BuilderFieldTypeEnum.Boolean => "BOOLEAN",
                BuilderFieldTypeEnum.Date => "DATE",
                BuilderFieldTypeEnum.Group => "GROUP",
                BuilderFieldTypeEnum.List => "LIST",
                BuilderFieldTypeEnum.MultiList => "MULTI_LIST",
                BuilderFieldTypeEnum.Number => "NUMBER",
                BuilderFieldTypeEnum.Statement => "STATEMENT",
                BuilderFieldTypeEnum.Text => "TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuilderFieldTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => BuilderFieldTypeEnum.Boolean,
                "DATE" => BuilderFieldTypeEnum.Date,
                "GROUP" => BuilderFieldTypeEnum.Group,
                "LIST" => BuilderFieldTypeEnum.List,
                "MULTI_LIST" => BuilderFieldTypeEnum.MultiList,
                "NUMBER" => BuilderFieldTypeEnum.Number,
                "STATEMENT" => BuilderFieldTypeEnum.Statement,
                "TEXT" => BuilderFieldTypeEnum.Text,
                _ => null,
            };
        }
    }
}