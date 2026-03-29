
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChannelCredentialsDto
    {
        /// <summary>
        /// The URL for the webhook associated with the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhookUrl")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// An array of device tokens for push notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceTokens")]
        public global::System.Collections.Generic.IList<string>? DeviceTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCredentialsDto" /> class.
        /// </summary>
        /// <param name="webhookUrl">
        /// The URL for the webhook associated with the channel.
        /// </param>
        /// <param name="deviceTokens">
        /// An array of device tokens for push notifications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChannelCredentialsDto(
            string? webhookUrl,
            global::System.Collections.Generic.IList<string>? deviceTokens)
        {
            this.WebhookUrl = webhookUrl;
            this.DeviceTokens = deviceTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChannelCredentialsDto" /> class.
        /// </summary>
        public ChannelCredentialsDto()
        {
        }
    }
}