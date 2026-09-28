
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkflowIssueTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        DuplicatedValue,
        /// <summary>
        ///
        /// </summary>
        LimitReached,
        /// <summary>
        ///
        /// </summary>
        MaxLengthAccessed,
        /// <summary>
        ///
        /// </summary>
        MissingValue,
        /// <summary>
        ///
        /// </summary>
        WorkflowIdAlreadyExists,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowIssueTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowIssueTypeEnum value)
        {
            return value switch
            {
                WorkflowIssueTypeEnum.DuplicatedValue => "DUPLICATED_VALUE",
                WorkflowIssueTypeEnum.LimitReached => "LIMIT_REACHED",
                WorkflowIssueTypeEnum.MaxLengthAccessed => "MAX_LENGTH_ACCESSED",
                WorkflowIssueTypeEnum.MissingValue => "MISSING_VALUE",
                WorkflowIssueTypeEnum.WorkflowIdAlreadyExists => "WORKFLOW_ID_ALREADY_EXISTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowIssueTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "DUPLICATED_VALUE" => WorkflowIssueTypeEnum.DuplicatedValue,
                "LIMIT_REACHED" => WorkflowIssueTypeEnum.LimitReached,
                "MAX_LENGTH_ACCESSED" => WorkflowIssueTypeEnum.MaxLengthAccessed,
                "MISSING_VALUE" => WorkflowIssueTypeEnum.MissingValue,
                "WORKFLOW_ID_ALREADY_EXISTS" => WorkflowIssueTypeEnum.WorkflowIdAlreadyExists,
                _ => null,
            };
        }
    }
}