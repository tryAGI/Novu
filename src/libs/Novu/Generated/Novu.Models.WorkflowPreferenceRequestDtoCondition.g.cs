
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional JSON Logic condition evaluated against the trigger payload at fan-out time (for example, `{ "var": "payload.tier" }`)<br/>
    /// Example: {"and":[{"===":[{"var":"payload.tier"},"premium"]}]}
    /// </summary>
    public sealed partial class WorkflowPreferenceRequestDtoCondition
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}