
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject
    {
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookCreatedWorkflowDtoWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "workflow" => WebhookCreatedWorkflowDtoWebhookPayloadWrapperObject.Workflow,
                _ => null,
            };
        }
    }
}