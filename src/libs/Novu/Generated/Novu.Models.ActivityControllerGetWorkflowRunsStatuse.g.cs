
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum ActivityControllerGetWorkflowRunsStatuse
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
    public static class ActivityControllerGetWorkflowRunsStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityControllerGetWorkflowRunsStatuse value)
        {
            return value switch
            {
                ActivityControllerGetWorkflowRunsStatuse.Completed => "completed",
                ActivityControllerGetWorkflowRunsStatuse.Error => "error",
                ActivityControllerGetWorkflowRunsStatuse.Processing => "processing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityControllerGetWorkflowRunsStatuse? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ActivityControllerGetWorkflowRunsStatuse.Completed,
                "error" => ActivityControllerGetWorkflowRunsStatuse.Error,
                "processing" => ActivityControllerGetWorkflowRunsStatuse.Processing,
                _ => null,
            };
        }
    }
}