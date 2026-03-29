
#nullable enable

namespace Novu
{
    /// <summary>
    /// Workflow run status
    /// </summary>
    public enum GetWorkflowRunsDtoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetWorkflowRunsDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowRunsDtoStatus value)
        {
            return value switch
            {
                GetWorkflowRunsDtoStatus.Completed => "completed",
                GetWorkflowRunsDtoStatus.Error => "error",
                GetWorkflowRunsDtoStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowRunsDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetWorkflowRunsDtoStatus.Completed,
                "error" => GetWorkflowRunsDtoStatus.Error,
                "processing" => GetWorkflowRunsDtoStatus.Processing,
                _ => null,
            };
        }
    }
}