
#nullable enable

namespace Novu
{
    /// <summary>
    /// Arbitrary payload forwarded to the workflow.<br/>
    /// Example: {"orderId":"ORD-42"}
    /// </summary>
    public sealed partial class TriggerSignalDtoPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}