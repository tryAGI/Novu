
#nullable enable

namespace Novu
{
    /// <summary>
    /// Per-turn typing/status control. `{ status?: string }` sets the status text (omit for the default "Thinking…"); `"stop"` clears it. Best-effort per platform.
    /// </summary>
    public sealed partial class AgentReplyPayloadDtoTyping
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}