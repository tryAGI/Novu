
#nullable enable

namespace Novu
{
    /// <summary>
    /// The source of overrides
    /// </summary>
    public enum PreferenceOverrideSourceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Subscriber,
        /// <summary>
        /// 
        /// </summary>
        Template,
        /// <summary>
        /// 
        /// </summary>
        WorkflowOverride,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreferenceOverrideSourceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreferenceOverrideSourceEnum value)
        {
            return value switch
            {
                PreferenceOverrideSourceEnum.Subscriber => "subscriber",
                PreferenceOverrideSourceEnum.Template => "template",
                PreferenceOverrideSourceEnum.WorkflowOverride => "workflowOverride",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreferenceOverrideSourceEnum? ToEnum(string value)
        {
            return value switch
            {
                "subscriber" => PreferenceOverrideSourceEnum.Subscriber,
                "template" => PreferenceOverrideSourceEnum.Template,
                "workflowOverride" => PreferenceOverrideSourceEnum.WorkflowOverride,
                _ => null,
            };
        }
    }
}