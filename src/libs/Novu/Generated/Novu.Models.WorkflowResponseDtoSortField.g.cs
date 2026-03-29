
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public enum WorkflowResponseDtoSortField
    {
        /// <summary>
        /// 
        /// </summary>
        CreatedAt,
        /// <summary>
        /// 
        /// </summary>
        LastTriggeredAt,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowResponseDtoSortFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowResponseDtoSortField value)
        {
            return value switch
            {
                WorkflowResponseDtoSortField.CreatedAt => "createdAt",
                WorkflowResponseDtoSortField.LastTriggeredAt => "lastTriggeredAt",
                WorkflowResponseDtoSortField.Name => "name",
                WorkflowResponseDtoSortField.UpdatedAt => "updatedAt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowResponseDtoSortField? ToEnum(string value)
        {
            return value switch
            {
                "createdAt" => WorkflowResponseDtoSortField.CreatedAt,
                "lastTriggeredAt" => WorkflowResponseDtoSortField.LastTriggeredAt,
                "name" => WorkflowResponseDtoSortField.Name,
                "updatedAt" => WorkflowResponseDtoSortField.UpdatedAt,
                _ => null,
            };
        }
    }
}