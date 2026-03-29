
#nullable enable

namespace Novu
{
    /// <summary>
    /// Status of the execution detail
    /// </summary>
    public enum ExecutionDetailsStatusEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        ReadConfirmation,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecutionDetailsStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecutionDetailsStatusEnum value)
        {
            return value switch
            {
                ExecutionDetailsStatusEnum.Failed => "Failed",
                ExecutionDetailsStatusEnum.Pending => "Pending",
                ExecutionDetailsStatusEnum.Queued => "Queued",
                ExecutionDetailsStatusEnum.ReadConfirmation => "ReadConfirmation",
                ExecutionDetailsStatusEnum.Success => "Success",
                ExecutionDetailsStatusEnum.Warning => "Warning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecutionDetailsStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "Failed" => ExecutionDetailsStatusEnum.Failed,
                "Pending" => ExecutionDetailsStatusEnum.Pending,
                "Queued" => ExecutionDetailsStatusEnum.Queued,
                "ReadConfirmation" => ExecutionDetailsStatusEnum.ReadConfirmation,
                "Success" => ExecutionDetailsStatusEnum.Success,
                "Warning" => ExecutionDetailsStatusEnum.Warning,
                _ => null,
            };
        }
    }
}