
#nullable enable

namespace Novu
{
    /// <summary>
    /// The level of the preference (global or template)
    /// </summary>
    public enum PreferenceLevelEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Global,
        /// <summary>
        /// 
        /// </summary>
        Template,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreferenceLevelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreferenceLevelEnum value)
        {
            return value switch
            {
                PreferenceLevelEnum.Global => "global",
                PreferenceLevelEnum.Template => "template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreferenceLevelEnum? ToEnum(string value)
        {
            return value switch
            {
                "global" => PreferenceLevelEnum.Global,
                "template" => PreferenceLevelEnum.Template,
                _ => null,
            };
        }
    }
}