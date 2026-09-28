
#nullable enable

namespace Novu
{
    /// <summary>
    /// Raw mail headers, keyed by lowercase header name
    /// </summary>
    public sealed partial class InboundEmailWebhookMailDtoHeaders
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}