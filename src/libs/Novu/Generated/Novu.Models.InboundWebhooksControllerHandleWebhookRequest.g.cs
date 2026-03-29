
#nullable enable

namespace Novu
{
    /// <summary>
    /// Generic webhook payload from delivery providers
    /// </summary>
    public sealed partial class InboundWebhooksControllerHandleWebhookRequest
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}