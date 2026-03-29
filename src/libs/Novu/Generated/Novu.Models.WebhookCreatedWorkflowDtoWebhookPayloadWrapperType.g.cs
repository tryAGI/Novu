
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WebhookCreatedWorkflowDtoWebhookPayloadWrapperType
    {
        /// <summary>
        /// 
        /// </summary>
        WorkflowCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCreatedWorkflowDtoWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCreatedWorkflowDtoWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WebhookCreatedWorkflowDtoWebhookPayloadWrapperType.WorkflowCreated => "workflow.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCreatedWorkflowDtoWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "workflow.created" => WebhookCreatedWorkflowDtoWebhookPayloadWrapperType.WorkflowCreated,
                _ => null,
            };
        }
    }
}