
#nullable enable

namespace Novu
{
    /// <summary>
    /// Per-provider content overrides keyed by providerId. Stored separately from controlValues and merged over the default body at send time. Keys are ChatProviderIdEnum / ToolProviderIdEnum values (e.g. `slack`, `whatsapp-business`, `pagerduty`).<br/>
    /// Example: {"slack":{"text":"{{payload.title}}","blocks":[{"type":"divider"}]},"whatsapp-business":{"type":"text","text":{"body":"{{payload.title}}"}},"pagerduty":{"severity":"warning","source":"novu","summary":"{{payload.title}}"}}
    /// </summary>
    public sealed partial class ToolStepResponseDtoProviderOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}