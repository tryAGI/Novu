
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboundEmailWebhookAttachmentDto
    {
        /// <summary>
        /// File name of the attachment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// MIME type of the attachment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentType")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// File size in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Size { get; set; }

        /// <summary>
        /// Presigned download URL. Absent on self-hosted deployments without S3, where `content` carries the bytes instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// ISO timestamp when `url` stops being valid. Present when Novu signed the URL for webhook delivery.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Deprecated, use `url`. Raw content in the legacy `{ type: "Buffer", data: number[] }` format, or `null` when rehydration failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Novu.InboundEmailWebhookAttachmentContentDto? Content { get; set; }

        /// <summary>
        /// Deprecated, use `size`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contentBytes")]
        public double? ContentBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookAttachmentDto" /> class.
        /// </summary>
        /// <param name="filename">
        /// File name of the attachment
        /// </param>
        /// <param name="contentType">
        /// MIME type of the attachment
        /// </param>
        /// <param name="size">
        /// File size in bytes
        /// </param>
        /// <param name="url">
        /// Presigned download URL. Absent on self-hosted deployments without S3, where `content` carries the bytes instead.
        /// </param>
        /// <param name="expiresAt">
        /// ISO timestamp when `url` stops being valid. Present when Novu signed the URL for webhook delivery.
        /// </param>
        /// <param name="content">
        /// Deprecated, use `url`. Raw content in the legacy `{ type: "Buffer", data: number[] }` format, or `null` when rehydration failed.
        /// </param>
        /// <param name="contentBytes">
        /// Deprecated, use `size`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboundEmailWebhookAttachmentDto(
            string filename,
            string contentType,
            double size,
            string? url,
            global::System.DateTime? expiresAt,
            global::Novu.InboundEmailWebhookAttachmentContentDto? content,
            double? contentBytes)
        {
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Size = size;
            this.Url = url;
            this.ExpiresAt = expiresAt;
            this.Content = content;
            this.ContentBytes = contentBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookAttachmentDto" /> class.
        /// </summary>
        public InboundEmailWebhookAttachmentDto()
        {
        }

    }
}