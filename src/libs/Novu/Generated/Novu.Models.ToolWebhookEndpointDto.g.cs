
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolWebhookEndpointDto
    {
        /// <summary>
        /// Destination webhook URL (often a per-subscriber capability URL). Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: https://example.com/tools/incoming
        /// </summary>
        /// <example>https://example.com/tools/incoming</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optional headers (e.g. auth tokens) sent with every request to this webhook. Header values are encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: {"Authorization":"Bearer \u003Ctoken\u003E"}
        /// </summary>
        /// <example>{"Authorization":"Bearer \u003Ctoken\u003E"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public object? Headers { get; set; }

        /// <summary>
        /// Optional HTTP method override for this webhook. Defaults to the integration-level method.<br/>
        /// Example: POST
        /// </summary>
        /// <example>POST</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.ToolWebhookEndpointDtoMethodJsonConverter))]
        public global::Novu.ToolWebhookEndpointDtoMethod? Method { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolWebhookEndpointDto" /> class.
        /// </summary>
        /// <param name="url">
        /// Destination webhook URL (often a per-subscriber capability URL). Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: https://example.com/tools/incoming
        /// </param>
        /// <param name="headers">
        /// Optional headers (e.g. auth tokens) sent with every request to this webhook. Header values are encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: {"Authorization":"Bearer \u003Ctoken\u003E"}
        /// </param>
        /// <param name="method">
        /// Optional HTTP method override for this webhook. Defaults to the integration-level method.<br/>
        /// Example: POST
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolWebhookEndpointDto(
            string url,
            object? headers,
            global::Novu.ToolWebhookEndpointDtoMethod? method)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Headers = headers;
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolWebhookEndpointDto" /> class.
        /// </summary>
        public ToolWebhookEndpointDto()
        {
        }

    }
}