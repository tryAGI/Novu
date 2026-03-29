
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WebhookDeletedWorkflowDtoWebhookPayloadWrapperType
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeletedWorkflowDtoWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeletedWorkflowDtoWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WebhookDeletedWorkflowDtoWebhookPayloadWrapperType.WorkflowDeleted => "workflow.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeletedWorkflowDtoWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "workflow.deleted" => WebhookDeletedWorkflowDtoWebhookPayloadWrapperType.WorkflowDeleted,
                _ => null,
            };
        }
    }
}