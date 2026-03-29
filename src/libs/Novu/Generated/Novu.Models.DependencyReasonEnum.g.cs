
#nullable enable

namespace Novu
{
    /// <summary>
    /// Reason for the dependency
    /// </summary>
    public enum DependencyReasonEnum
    {
        /// <summary>
        /// 
        /// </summary>
        LayoutExistsInTarget,
        /// <summary>
        /// 
        /// </summary>
        LayoutRequiredForWorkflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependencyReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependencyReasonEnum value)
        {
            return value switch
            {
                DependencyReasonEnum.LayoutExistsInTarget => "LAYOUT_EXISTS_IN_TARGET",
                DependencyReasonEnum.LayoutRequiredForWorkflow => "LAYOUT_REQUIRED_FOR_WORKFLOW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependencyReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "LAYOUT_EXISTS_IN_TARGET" => DependencyReasonEnum.LayoutExistsInTarget,
                "LAYOUT_REQUIRED_FOR_WORKFLOW" => DependencyReasonEnum.LayoutRequiredForWorkflow,
                _ => null,
            };
        }
    }
}