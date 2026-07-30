
#nullable enable

namespace Novu
{
    /// <summary>
    /// Optional headers (e.g. auth tokens) sent with every request to this webhook. Header values are encrypted at rest on the channel endpoint (`endpoint` field).<br/>
    /// Example: {"Authorization":"Bearer \u003Ctoken\u003E"}
    /// </summary>
    public sealed partial class ToolWebhookEndpointDtoHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}