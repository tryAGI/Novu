
#nullable enable

namespace Novu
{
    /// <summary>
    /// Opsgenie content overrides. Merged over the default step body at send time. Supported keys are documented in the Opsgenie override schema.<br/>
    /// Example: {"priority":"P2","message":"{{payload.title}}"}
    /// </summary>
    public sealed partial class ProviderOverridesDtoOpsgenie
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}