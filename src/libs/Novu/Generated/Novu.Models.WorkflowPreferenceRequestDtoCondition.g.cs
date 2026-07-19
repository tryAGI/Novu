
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional JSON Logic condition evaluated at fan-out time against trigger payload, subscriber profile, actor, and context (for example, `{ "var": "payload.tier" }`, `{ "var": "subscriber.data.plan" }`, or `{ "var": "actor.data.role" }`)<br/>
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