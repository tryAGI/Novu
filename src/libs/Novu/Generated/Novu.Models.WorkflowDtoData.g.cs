
#nullable enable

namespace Novu
{
    /// <summary>
    /// Custom data associated with the workflow<br/>
    /// Example: {"category":"onboarding","priority":"high"}
    /// </summary>
    public sealed partial class WorkflowDtoData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}