
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReplyContentDto
    {
        /// <summary>
        /// Plain text or markdown body. Mutually exclusive with `card` and `toolApprovalCard`.<br/>
        /// Example: Hello! How can I help?
        /// </summary>
        /// <example>Hello! How can I help?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Interactive Chat SDK card JSON. Mutually exclusive with `markdown` and `toolApprovalCard`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        public object? Card { get; set; }

        /// <summary>
        /// Built-in tool-approval card. Mutually exclusive with `markdown` and `card`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolApprovalCard")]
        public object? ToolApprovalCard { get; set; }

        /// <summary>
        /// Optional file attachments (max 15). Requires markdown, card, or toolApprovalCard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Novu.FileRefDto>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyContentDto" /> class.
        /// </summary>
        /// <param name="markdown">
        /// Plain text or markdown body. Mutually exclusive with `card` and `toolApprovalCard`.<br/>
        /// Example: Hello! How can I help?
        /// </param>
        /// <param name="card">
        /// Interactive Chat SDK card JSON. Mutually exclusive with `markdown` and `toolApprovalCard`.
        /// </param>
        /// <param name="toolApprovalCard">
        /// Built-in tool-approval card. Mutually exclusive with `markdown` and `card`.
        /// </param>
        /// <param name="files">
        /// Optional file attachments (max 15). Requires markdown, card, or toolApprovalCard.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplyContentDto(
            string? markdown,
            object? card,
            object? toolApprovalCard,
            global::System.Collections.Generic.IList<global::Novu.FileRefDto>? files)
        {
            this.Markdown = markdown;
            this.Card = card;
            this.ToolApprovalCard = toolApprovalCard;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyContentDto" /> class.
        /// </summary>
        public ReplyContentDto()
        {
        }

    }
}