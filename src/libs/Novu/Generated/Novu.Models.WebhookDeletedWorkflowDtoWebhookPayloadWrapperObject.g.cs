
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject
    {
        /// <summary>
        /// 
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeletedWorkflowDtoWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "workflow" => WebhookDeletedWorkflowDtoWebhookPayloadWrapperObject.Workflow,
                _ => null,
            };
        }
    }
}