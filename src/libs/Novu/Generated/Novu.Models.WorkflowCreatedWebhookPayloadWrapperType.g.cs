
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of the webhook event.
    /// </summary>
    public enum WorkflowCreatedWebhookPayloadWrapperType
    {
        /// <summary>
        ///
        /// </summary>
        WorkflowCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowCreatedWebhookPayloadWrapperTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowCreatedWebhookPayloadWrapperType value)
        {
            return value switch
            {
                WorkflowCreatedWebhookPayloadWrapperType.WorkflowCreated => "workflow.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowCreatedWebhookPayloadWrapperType? ToEnum(string value)
        {
            return value switch
            {
                "workflow.created" => WorkflowCreatedWebhookPayloadWrapperType.WorkflowCreated,
                _ => null,
            };
        }
    }
}