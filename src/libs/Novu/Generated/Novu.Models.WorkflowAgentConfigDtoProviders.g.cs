
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional per-provider overrides keyed by providerId (e.g. novu-email-agent). Today only Novu Email replyTo is supported.
    /// </summary>
    public sealed partial class WorkflowAgentConfigDtoProviders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}