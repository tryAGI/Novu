
#nullable enable

namespace Novu
{
    /// <summary>
    /// Type of step content issue
    /// </summary>
    public enum ContentIssueEnum
    {
        /// <summary>
        /// 
        /// </summary>
        IllegalVariableInControlValue,
        /// <summary>
        /// 
        /// </summary>
        InvalidFilterArgInVariable,
        /// <summary>
        /// 
        /// </summary>
        InvalidUrl,
        /// <summary>
        /// 
        /// </summary>
        MissingValue,
        /// <summary>
        /// 
        /// </summary>
        TierLimitExceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentIssueEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentIssueEnum value)
        {
            return value switch
            {
                ContentIssueEnum.IllegalVariableInControlValue => "ILLEGAL_VARIABLE_IN_CONTROL_VALUE",
                ContentIssueEnum.InvalidFilterArgInVariable => "INVALID_FILTER_ARG_IN_VARIABLE",
                ContentIssueEnum.InvalidUrl => "INVALID_URL",
                ContentIssueEnum.MissingValue => "MISSING_VALUE",
                ContentIssueEnum.TierLimitExceeded => "TIER_LIMIT_EXCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentIssueEnum? ToEnum(string value)
        {
            return value switch
            {
                "ILLEGAL_VARIABLE_IN_CONTROL_VALUE" => ContentIssueEnum.IllegalVariableInControlValue,
                "INVALID_FILTER_ARG_IN_VARIABLE" => ContentIssueEnum.InvalidFilterArgInVariable,
                "INVALID_URL" => ContentIssueEnum.InvalidUrl,
                "MISSING_VALUE" => ContentIssueEnum.MissingValue,
                "TIER_LIMIT_EXCEEDED" => ContentIssueEnum.TierLimitExceeded,
                _ => null,
            };
        }
    }
}