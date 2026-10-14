
#nullable enable

namespace Novu
{
    /// <summary>
    /// Per-integration content overrides keyed by providerId, then by integration identifier. Each entry is merged over the matching providerOverrides entry, only for sends through that integration. Trigger-time overrides still take precedence. Entries whose integration does not exist in the environment are kept but not applied.<br/>
    /// Example: {"tool-webhook":{"prod-alerts":{"alert_type":"incident"},"staging-alerts":{"alert_type":"test"}}}
    /// </summary>
    public sealed partial class HttpRequestStepResponseDtoIntegrationOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}