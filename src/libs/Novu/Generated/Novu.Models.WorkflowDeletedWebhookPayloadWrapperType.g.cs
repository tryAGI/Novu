
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WorkflowDeletedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        WorkflowDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowDeletedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowDeletedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WorkflowDeletedWebhookPayloadWrapperType.WorkflowDeleted => "workflow.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowDeletedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "workflow.deleted" => WorkflowDeletedWebhookPayloadWrapperType.WorkflowDeleted,
                _ => null,
            };
        }
    }
}