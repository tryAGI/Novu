
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject
    {
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "workflow" => WebhookUpdatedWorkflowDtoWebhookPayloadWrapperObject.Workflow,
                _ => null,
            };
        }
    }
}