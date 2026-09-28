
#nullable enable

namespace Novu
{
    /// <summary>
    /// The type of object the event relates to.
    /// </summary>
    public enum WorkflowCreatedWebhookPayloadWrapperObject
    {
        /// <summary>
        ///
        /// </summary>
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowCreatedWebhookPayloadWrapperObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowCreatedWebhookPayloadWrapperObject value)
        {
            return value switch
            {
                WorkflowCreatedWebhookPayloadWrapperObject.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowCreatedWebhookPayloadWrapperObject? ToEnum(string value)
        {
            return value switch
            {
                "workflow" => WorkflowCreatedWebhookPayloadWrapperObject.Workflow,
                _ => null,
            };
        }
    }
}