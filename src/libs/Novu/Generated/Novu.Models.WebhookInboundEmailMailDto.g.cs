
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookInboundEmailMailDto
    {
        /// <summary>
        /// Sender address info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.WebhookInboundEmailAddressDto From { get; set; }

        /// <summary>
        /// Recipient address info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.WebhookInboundEmailAddressDto> To { get; set; }

        /// <summary>
        /// Email subject
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subject { get; set; }

        /// <summary>
        /// HTML body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Plain text body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Message ID header
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInboundEmailMailDto" /> class.
        /// </summary>
        /// <param name="from">
        /// Sender address info
        /// </param>
        /// <param name="to">
        /// Recipient address info
        /// </param>
        /// <param name="subject">
        /// Email subject
        /// </param>
        /// <param name="messageId">
        /// Message ID header
        /// </param>
        /// <param name="html">
        /// HTML body
        /// </param>
        /// <param name="text">
        /// Plain text body
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookInboundEmailMailDto(
            global::Novu.WebhookInboundEmailAddressDto from,
            global::System.Collections.Generic.IList<global::Novu.WebhookInboundEmailAddressDto> to,
            string subject,
            string messageId,
            string? html,
            string? text)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Html = html;
            this.Text = text;
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookInboundEmailMailDto" /> class.
        /// </summary>
        public WebhookInboundEmailMailDto()
        {
        }
    }
}