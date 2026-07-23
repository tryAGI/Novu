
#nullable enable

namespace Novu
{
    /// <summary>
    /// PagerDuty content overrides. Merged over the default step body at send time. Supported keys are documented in the PagerDuty override schema.<br/>
    /// Example: {"severity":"warning","source":"novu","summary":"{{payload.title}}"}
    /// </summary>
    public sealed partial class ProviderOverridesDtoPagerduty
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}