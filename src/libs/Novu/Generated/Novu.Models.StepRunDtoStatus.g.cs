
#nullable enable

namespace Novu
{
    /// <summary>
    /// Step status
    /// </summary>
    public enum StepRunDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Delayed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Merged,
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
        Running,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StepRunDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StepRunDtoStatus value)
        {
            return value switch
            {
                StepRunDtoStatus.Canceled => "canceled",
                StepRunDtoStatus.Completed => "completed",
                StepRunDtoStatus.Delayed => "delayed",
                StepRunDtoStatus.Failed => "failed",
                StepRunDtoStatus.Merged => "merged",
                StepRunDtoStatus.Pending => "pending",
                StepRunDtoStatus.Queued => "queued",
                StepRunDtoStatus.Running => "running",
                StepRunDtoStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StepRunDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => StepRunDtoStatus.Canceled,
                "completed" => StepRunDtoStatus.Completed,
                "delayed" => StepRunDtoStatus.Delayed,
                "failed" => StepRunDtoStatus.Failed,
                "merged" => StepRunDtoStatus.Merged,
                "pending" => StepRunDtoStatus.Pending,
                "queued" => StepRunDtoStatus.Queued,
                "running" => StepRunDtoStatus.Running,
                "skipped" => StepRunDtoStatus.Skipped,
                _ => null,
            };
        }
    }
}