
#nullable enable

namespace Novu
{
    /// <summary>
    /// Step status
    /// </summary>
    public enum WorkflowRunStepsDetailsDtoStatus
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
    public static class WorkflowRunStepsDetailsDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowRunStepsDetailsDtoStatus value)
        {
            return value switch
            {
                WorkflowRunStepsDetailsDtoStatus.Canceled => "canceled",
                WorkflowRunStepsDetailsDtoStatus.Completed => "completed",
                WorkflowRunStepsDetailsDtoStatus.Delayed => "delayed",
                WorkflowRunStepsDetailsDtoStatus.Failed => "failed",
                WorkflowRunStepsDetailsDtoStatus.Merged => "merged",
                WorkflowRunStepsDetailsDtoStatus.Pending => "pending",
                WorkflowRunStepsDetailsDtoStatus.Queued => "queued",
                WorkflowRunStepsDetailsDtoStatus.Running => "running",
                WorkflowRunStepsDetailsDtoStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowRunStepsDetailsDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "canceled" => WorkflowRunStepsDetailsDtoStatus.Canceled,
                "completed" => WorkflowRunStepsDetailsDtoStatus.Completed,
                "delayed" => WorkflowRunStepsDetailsDtoStatus.Delayed,
                "failed" => WorkflowRunStepsDetailsDtoStatus.Failed,
                "merged" => WorkflowRunStepsDetailsDtoStatus.Merged,
                "pending" => WorkflowRunStepsDetailsDtoStatus.Pending,
                "queued" => WorkflowRunStepsDetailsDtoStatus.Queued,
                "running" => WorkflowRunStepsDetailsDtoStatus.Running,
                "skipped" => WorkflowRunStepsDetailsDtoStatus.Skipped,
                _ => null,
            };
        }
    }
}