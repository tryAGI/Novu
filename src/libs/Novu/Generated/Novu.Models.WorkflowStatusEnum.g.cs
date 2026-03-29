
#nullable enable

namespace Novu
{
    /// <summary>
    /// Status of the workflow
    /// </summary>
    public enum WorkflowStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowStatusEnum value)
        {
            return value switch
            {
                WorkflowStatusEnum.Active => "ACTIVE",
                WorkflowStatusEnum.Error => "ERROR",
                WorkflowStatusEnum.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => WorkflowStatusEnum.Active,
                "ERROR" => WorkflowStatusEnum.Error,
                "INACTIVE" => WorkflowStatusEnum.Inactive,
                _ => null,
            };
        }
    }
}