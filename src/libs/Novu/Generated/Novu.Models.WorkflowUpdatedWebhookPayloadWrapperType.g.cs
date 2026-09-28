
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WorkflowUpdatedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        WorkflowUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowUpdatedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowUpdatedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WorkflowUpdatedWebhookPayloadWrapperType.WorkflowUpdated => "workflow.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowUpdatedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "workflow.updated" => WorkflowUpdatedWebhookPayloadWrapperType.WorkflowUpdated,
                _ => null,
            };
        }
    }
}