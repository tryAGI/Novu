
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookEndpointDto
    {
        /// <summary>
        /// Webhook URL<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Optional channel identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpointDto" /> class.
        /// </summary>
        /// <param name="url">
        /// Webhook URL<br/>
        /// Example: https://example.com/webhook
        /// </param>
        /// <param name="channel">
        /// Optional channel identifier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEndpointDto(
            string url,
            string? channel)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Channel = channel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpointDto" /> class.
        /// </summary>
        public WebhookEndpointDto()
        {
        }
    }
}