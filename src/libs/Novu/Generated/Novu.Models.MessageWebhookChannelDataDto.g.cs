
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessageWebhookChannelDataDto
    {
        /// <summary>
        /// Channel endpoint type, for example `slack_channel` or `webhook`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Identifier of the channel endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identifier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identifier { get; set; }

        /// <summary>
        /// Provider-specific endpoint payload. Secrets such as tokens are redacted when present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Endpoint { get; set; }

        /// <summary>
        /// Redacted provider token when required by the endpoint type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Microsoft Teams tenant identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriberTenantId")]
        public string? SubscriberTenantId { get; set; }

        /// <summary>
        /// Microsoft Teams client identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookChannelDataDto" /> class.
        /// </summary>
        /// <param name="type">
        /// Channel endpoint type, for example `slack_channel` or `webhook`
        /// </param>
        /// <param name="identifier">
        /// Identifier of the channel endpoint
        /// </param>
        /// <param name="endpoint">
        /// Provider-specific endpoint payload. Secrets such as tokens are redacted when present.
        /// </param>
        /// <param name="token">
        /// Redacted provider token when required by the endpoint type
        /// </param>
        /// <param name="subscriberTenantId">
        /// Microsoft Teams tenant identifier
        /// </param>
        /// <param name="clientId">
        /// Microsoft Teams client identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageWebhookChannelDataDto(
            string type,
            string identifier,
            object endpoint,
            string? token,
            string? subscriberTenantId,
            string? clientId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Identifier = identifier ?? throw new global::System.ArgumentNullException(nameof(identifier));
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Token = token;
            this.SubscriberTenantId = subscriberTenantId;
            this.ClientId = clientId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWebhookChannelDataDto" /> class.
        /// </summary>
        public MessageWebhookChannelDataDto()
        {
        }

    }
}