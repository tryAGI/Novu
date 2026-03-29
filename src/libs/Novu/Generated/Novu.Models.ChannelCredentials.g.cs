
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelCredentials
    {
        /// <summary>
        /// Webhook URL used by chat app integrations. The webhook should be obtained from the chat app provider.<br/>
        /// Example: https://example.com/webhook
        /// </summary>
        /// <example>https://example.com/webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// Channel specification for Mattermost chat notifications.<br/>
        /// Example: general
        /// </summary>
        /// <example>general</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// Contains an array of the subscriber device tokens for a given provider. Used on Push integrations.<br/>
        /// Example: [token1, token2, token3]
        /// </summary>
        /// <example>[token1, token2, token3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceTokens")]
        public global::System.Collections.Generic.IList<string>? DeviceTokens { get; set; }

        /// <summary>
        /// Alert UID for Grafana on-call webhook payload.<br/>
        /// Example: 12345-abcde
        /// </summary>
        /// <example>12345-abcde</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("alertUid")]
        public string? AlertUid { get; set; }

        /// <summary>
        /// Title to be used with Grafana on-call webhook.<br/>
        /// Example: Critical Alert
        /// </summary>
        /// <example>Critical Alert</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Image URL property for Grafana on-call webhook.<br/>
        /// Example: https://example.com/image.png
        /// </summary>
        /// <example>https://example.com/image.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageUrl")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// State property for Grafana on-call webhook.<br/>
        /// Example: resolved
        /// </summary>
        /// <example>resolved</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Link to upstream details property for Grafana on-call webhook.<br/>
        /// Example: https://example.com/details
        /// </summary>
        /// <example>https://example.com/details</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalUrl")]
        public string? ExternalUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCredentials" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// Webhook URL used by chat app integrations. The webhook should be obtained from the chat app provider.<br/>
        /// Example: https://example.com/webhook
        /// </param>
        /// <param name="channel">
        /// Channel specification for Mattermost chat notifications.<br/>
        /// Example: general
        /// </param>
        /// <param name="deviceTokens">
        /// Contains an array of the subscriber device tokens for a given provider. Used on Push integrations.<br/>
        /// Example: [token1, token2, token3]
        /// </param>
        /// <param name="alertUid">
        /// Alert UID for Grafana on-call webhook payload.<br/>
        /// Example: 12345-abcde
        /// </param>
        /// <param name="title">
        /// Title to be used with Grafana on-call webhook.<br/>
        /// Example: Critical Alert
        /// </param>
        /// <param name="imageUrl">
        /// Image URL property for Grafana on-call webhook.<br/>
        /// Example: https://example.com/image.png
        /// </param>
        /// <param name="state">
        /// State property for Grafana on-call webhook.<br/>
        /// Example: resolved
        /// </param>
        /// <param name="externalUrl">
        /// Link to upstream details property for Grafana on-call webhook.<br/>
        /// Example: https://example.com/details
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelCredentials(
            string? webhookUrl,
            string? channel,
            global::System.Collections.Generic.IList<string>? deviceTokens,
            string? alertUid,
            string? title,
            string? imageUrl,
            string? state,
            string? externalUrl)
        {
            this.WebhookUrl = webhookUrl;
            this.Channel = channel;
            this.DeviceTokens = deviceTokens;
            this.AlertUid = alertUid;
            this.Title = title;
            this.ImageUrl = imageUrl;
            this.State = state;
            this.ExternalUrl = externalUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCredentials" /> class.
        /// </summary>
        public ChannelCredentials()
        {
        }
    }
}