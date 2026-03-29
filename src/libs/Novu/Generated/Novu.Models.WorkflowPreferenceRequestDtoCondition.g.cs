
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional condition using JSON Logic rules<br/>
    /// Example: {"and":[{"===":[{"var":"tier"},"premium"]}]}
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