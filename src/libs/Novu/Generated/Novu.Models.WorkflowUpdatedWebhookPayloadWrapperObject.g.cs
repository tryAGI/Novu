
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WorkflowUpdatedWebhookPayloadWrapperObject
    {
        /// <summary>
        ///
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowUpdatedWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowUpdatedWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WorkflowUpdatedWebhookPayloadWrapperObject.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowUpdatedWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "workflow" => WorkflowUpdatedWebhookPayloadWrapperObject.Workflow,
                _ => null,
            };
        }
    }
}