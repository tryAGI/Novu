
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of monthly schedule
    /// </summary>
    public enum MonthlyTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Each,
        /// <summary>
        /// 
        /// </summary>
        On,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MonthlyTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MonthlyTypeEnum value)
        {
            return value switch
            {
                MonthlyTypeEnum.Each => "each",
                MonthlyTypeEnum.On => "on",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MonthlyTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "each" => MonthlyTypeEnum.Each,
                "on" => MonthlyTypeEnum.On,
                _ => null,
            };
        }
    }
}