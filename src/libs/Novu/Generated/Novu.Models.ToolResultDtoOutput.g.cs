
#nullable enable

namespace Novu
{
    /// <summary>
    /// JSON-serializable tool output (or the execution-denied marker).
    /// </summary>
    public sealed partial class ToolResultDtoOutput
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}