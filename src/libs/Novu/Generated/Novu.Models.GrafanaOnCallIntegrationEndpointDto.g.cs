
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GrafanaOnCallIntegrationEndpointDto
    {
        /// <summary>
        /// Grafana IRM/OnCall incoming-webhook (Formatted Webhook) integration URL. The routing secret is embedded in the URL path. Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: https://acme.grafana.net/integrations/v1/formatted_webhook/m12xmIjOcgwH74UF8CN4dk0Dh/
        /// </summary>
        /// <example>https://acme.grafana.net/integrations/v1/formatted_webhook/m12xmIjOcgwH74UF8CN4dk0Dh/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optional Grafana service account bearer token, required when the integration enforces authenticated ingestion. Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: glsa_abc123...
        /// </summary>
        /// <example>glsa_abc123...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("authToken")]
        public string? AuthToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GrafanaOnCallIntegrationEndpointDto" /> class.
        /// </summary>
        /// <param name="url">
        /// Grafana IRM/OnCall incoming-webhook (Formatted Webhook) integration URL. The routing secret is embedded in the URL path. Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: https://acme.grafana.net/integrations/v1/formatted_webhook/m12xmIjOcgwH74UF8CN4dk0Dh/
        /// </param>
        /// <param name="authToken">
        /// Optional Grafana service account bearer token, required when the integration enforces authenticated ingestion. Encrypted at rest on the channel endpoint (`endpoint` field).<br/>
        /// Example: glsa_abc123...
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GrafanaOnCallIntegrationEndpointDto(
            string url,
            string? authToken)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AuthToken = authToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GrafanaOnCallIntegrationEndpointDto" /> class.
        /// </summary>
        public GrafanaOnCallIntegrationEndpointDto()
        {
        }

    }
}