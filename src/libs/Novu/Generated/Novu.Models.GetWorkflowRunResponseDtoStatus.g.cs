
#nullable enable

namespace Novu
{
    /// <summary>
    /// Workflow run status
    /// </summary>
    public enum GetWorkflowRunResponseDtoStatus
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
    public static class GetWorkflowRunResponseDtoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowRunResponseDtoStatus value)
        {
            return value switch
            {
                GetWorkflowRunResponseDtoStatus.Completed => "completed",
                GetWorkflowRunResponseDtoStatus.Error => "error",
                GetWorkflowRunResponseDtoStatus.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowRunResponseDtoStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => GetWorkflowRunResponseDtoStatus.Completed,
                "error" => GetWorkflowRunResponseDtoStatus.Error,
                "processing" => GetWorkflowRunResponseDtoStatus.Processing,
                _ => null,
            };
        }
    }
}