
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EditPayloadDto
    {
        /// <summary>
        /// Platform message id of the message to edit.<br/>
        /// Example: 1712345678.123456
        /// </summary>
        /// <example>1712345678.123456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("messageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MessageId { get; set; }

        /// <summary>
        /// Replacement content. Exactly one of markdown, card, or toolApprovalCard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.OneOfJsonConverter<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditPayloadDto" /> class.
        /// </summary>
        /// <param name="messageId">
        /// Platform message id of the message to edit.<br/>
        /// Example: 1712345678.123456
        /// </param>
        /// <param name="content">
        /// Replacement content. Exactly one of markdown, card, or toolApprovalCard.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditPayloadDto(
            string messageId,
            global::Novu.OneOf<global::Novu.MarkdownReplyContentDto, global::Novu.CardReplyContentDto, global::Novu.ToolApprovalCardReplyContentDto> content)
        {
            this.MessageId = messageId ?? throw new global::System.ArgumentNullException(nameof(messageId));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditPayloadDto" /> class.
        /// </summary>
        public EditPayloadDto()
        {
        }

    }
}