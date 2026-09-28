
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WorkflowPublishedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        WorkflowPublished,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowPublishedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowPublishedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WorkflowPublishedWebhookPayloadWrapperType.WorkflowPublished => "workflow.published",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowPublishedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "workflow.published" => WorkflowPublishedWebhookPayloadWrapperType.WorkflowPublished,
                _ => null,
            };
        }
    }
}