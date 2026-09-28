
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboundEmailWebhookMailDto
    {
        /// <summary>
        /// Sender addresses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto> From { get; set; }

        /// <summary>
        /// Recipient addresses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto> To { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Html { get; set; }

        /// <summary>
        /// Plain text body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Value of the `Message-ID` header
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// Raw mail headers, keyed by lowercase header name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Headers { get; set; }

        /// <summary>
        /// Timestamp taken from the `Date` header, or `null` when the header is invalid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        public global::System.DateTime? Date { get; set; }

        /// <summary>
        /// Value of the `In-Reply-To` header, set on replies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inReplyTo")]
        public string? InReplyTo { get; set; }

        /// <summary>
        /// Value of the `References` header, delivered as a single value or a list depending on the sender
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? References { get; set; }

        /// <summary>
        /// Carbon copy addresses, when the sender set any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cc")]
        public global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto>? Cc { get; set; }

        /// <summary>
        /// Matched SMTP envelope recipient when it is absent from the To and Cc headers. Omitted otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bcc")]
        public global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto>? Bcc { get; set; }

        /// <summary>
        /// Attachments found on the email
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attachments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAttachmentDto> Attachments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookMailDto" /> class.
        /// </summary>
        /// <param name="from">
        /// Sender addresses
        /// </param>
        /// <param name="to">
        /// Recipient addresses
        /// </param>
        /// <param name="subject">
        /// Email subject
        /// </param>
        /// <param name="html">
        /// HTML body
        /// </param>
        /// <param name="text">
        /// Plain text body
        /// </param>
        /// <param name="messageId">
        /// Value of the `Message-ID` header
        /// </param>
        /// <param name="headers">
        /// Raw mail headers, keyed by lowercase header name
        /// </param>
        /// <param name="attachments">
        /// Attachments found on the email
        /// </param>
        /// <param name="date">
        /// Timestamp taken from the `Date` header, or `null` when the header is invalid
        /// </param>
        /// <param name="inReplyTo">
        /// Value of the `In-Reply-To` header, set on replies
        /// </param>
        /// <param name="references">
        /// Value of the `References` header, delivered as a single value or a list depending on the sender
        /// </param>
        /// <param name="cc">
        /// Carbon copy addresses, when the sender set any
        /// </param>
        /// <param name="bcc">
        /// Matched SMTP envelope recipient when it is absent from the To and Cc headers. Omitted otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboundEmailWebhookMailDto(
            global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto> from,
            global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto> to,
            string subject,
            string html,
            string text,
            string messageId,
            object headers,
            global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAttachmentDto> attachments,
            global::System.DateTime? date,
            string? inReplyTo,
            global::Novu.OneOf<string, global::System.Collections.Generic.IList<string>>? references,
            global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto>? cc,
            global::System.Collections.Generic.IList<global::Novu.InboundEmailWebhookAddressDto>? bcc)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.To = to ?? throw new global::System.ArgumentNullException(nameof(to));
            this.Subject = subject ?? throw new global::System.ArgumentNullException(nameof(subject));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.Date = date;
            this.InReplyTo = inReplyTo;
            this.References = references;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Attachments = attachments ?? throw new global::System.ArgumentNullException(nameof(attachments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookMailDto" /> class.
        /// </summary>
        public InboundEmailWebhookMailDto()
        {
        }

    }
}