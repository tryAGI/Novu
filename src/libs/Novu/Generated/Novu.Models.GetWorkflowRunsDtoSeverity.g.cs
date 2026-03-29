
#nullable enable

namespace Novu
{
    /// <summary>
    /// Severity
    /// </summary>
    public enum GetWorkflowRunsDtoSeverity
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
    public static class GetWorkflowRunsDtoSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowRunsDtoSeverity value)
        {
            return value switch
            {
                GetWorkflowRunsDtoSeverity.High => "high",
                GetWorkflowRunsDtoSeverity.Low => "low",
                GetWorkflowRunsDtoSeverity.Medium => "medium",
                GetWorkflowRunsDtoSeverity.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowRunsDtoSeverity? ToEnum(string value)
        {
            return value switch
            {
                "high" => GetWorkflowRunsDtoSeverity.High,
                "low" => GetWorkflowRunsDtoSeverity.Low,
                "medium" => GetWorkflowRunsDtoSeverity.Medium,
                "none" => GetWorkflowRunsDtoSeverity.None,
                _ => null,
            };
        }
    }
}