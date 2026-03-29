
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookUpdatedWorkflowDtoWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType.WorkflowUpdated => "workflow.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "workflow.updated" => WebhookUpdatedWorkflowDtoWebhookPayloadWrapperType.WorkflowUpdated,
                _ => null,
            };
        }
    }
}