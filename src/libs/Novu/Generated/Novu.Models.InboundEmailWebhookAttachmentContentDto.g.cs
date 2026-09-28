
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class InboundEmailWebhookAttachmentContentDto
    {
        /// <summary>
        /// Legacy Node.js buffer marker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.InboundEmailWebhookAttachmentContentDtoTypeJsonConverter))]
        public global::Novu.InboundEmailWebhookAttachmentContentDtoType Type { get; set; }

        /// <summary>
        /// Raw attachment bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookAttachmentContentDto" /> class.
        /// </summary>
        /// <param name="data">
        /// Raw attachment bytes
        /// </param>
        /// <param name="type">
        /// Legacy Node.js buffer marker
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InboundEmailWebhookAttachmentContentDto(
            global::System.Collections.Generic.IList<double> data,
            global::Novu.InboundEmailWebhookAttachmentContentDtoType type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InboundEmailWebhookAttachmentContentDto" /> class.
        /// </summary>
        public InboundEmailWebhookAttachmentContentDto()
        {
        }

    }
}