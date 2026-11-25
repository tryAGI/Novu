
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum ActivityControllerGetWorkflowRunsSeverityItem
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActivityControllerGetWorkflowRunsSeverityItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActivityControllerGetWorkflowRunsSeverityItem value)
        {
            return value switch
            {
                ActivityControllerGetWorkflowRunsSeverityItem.High => "high",
                ActivityControllerGetWorkflowRunsSeverityItem.Low => "low",
                ActivityControllerGetWorkflowRunsSeverityItem.Medium => "medium",
                ActivityControllerGetWorkflowRunsSeverityItem.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActivityControllerGetWorkflowRunsSeverityItem? ToEnum(string value)
        {
            return value switch
            {
                "high" => ActivityControllerGetWorkflowRunsSeverityItem.High,
                "low" => ActivityControllerGetWorkflowRunsSeverityItem.Low,
                "medium" => ActivityControllerGetWorkflowRunsSeverityItem.Medium,
                "none" => ActivityControllerGetWorkflowRunsSeverityItem.None,
                _ => null,
            };
        }
    }
}