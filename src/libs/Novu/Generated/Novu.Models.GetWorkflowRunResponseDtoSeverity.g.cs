
#nullable enable

namespace Novu
{
    /// <summary>
    /// Severity
    /// </summary>
    public enum GetWorkflowRunResponseDtoSeverity
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
    public static class GetWorkflowRunResponseDtoSeverityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetWorkflowRunResponseDtoSeverity value)
        {
            return value switch
            {
                GetWorkflowRunResponseDtoSeverity.High => "high",
                GetWorkflowRunResponseDtoSeverity.Low => "low",
                GetWorkflowRunResponseDtoSeverity.Medium => "medium",
                GetWorkflowRunResponseDtoSeverity.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetWorkflowRunResponseDtoSeverity? ToEnum(string value)
        {
            return value switch
            {
                "high" => GetWorkflowRunResponseDtoSeverity.High,
                "low" => GetWorkflowRunResponseDtoSeverity.Low,
                "medium" => GetWorkflowRunResponseDtoSeverity.Medium,
                "none" => GetWorkflowRunResponseDtoSeverity.None,
                _ => null,
            };
        }
    }
}