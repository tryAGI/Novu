
#nullable enable

namespace Novu
{
    /// <summary>
    /// Workflow payload for `trigger` signals.
    /// </summary>
    public sealed partial class SignalDtoPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}