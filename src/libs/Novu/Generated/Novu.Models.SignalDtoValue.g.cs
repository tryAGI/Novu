
#nullable enable

namespace Novu
{
    /// <summary>
    /// Value for metadata `set` actions. JSON-serializable.
    /// </summary>
    public sealed partial class SignalDtoValue
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}