
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional context object for additional error details.<br/>
    /// Example: {"workflowId":"some_wf_id","stepId":"some_wf_id"}
    /// </summary>
    public sealed partial class PayloadValidationExceptionDtoCtx
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}