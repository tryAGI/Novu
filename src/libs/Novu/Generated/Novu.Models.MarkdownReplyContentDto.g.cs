
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkdownReplyContentDto
    {
        /// <summary>
        /// Plain text or markdown body. Converted to the platform-native format by Novu.<br/>
        /// Example: **Report ready.** Your weekly summary is attached.
        /// </summary>
        /// <example>**Report ready.** Your weekly summary is attached.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Markdown { get; set; }

        /// <summary>
        /// Optional attachments (max 15). Each file needs exactly one of data or url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Novu.FileRefDto>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownReplyContentDto" /> class.
        /// </summary>
        /// <param name="markdown">
        /// Plain text or markdown body. Converted to the platform-native format by Novu.<br/>
        /// Example: **Report ready.** Your weekly summary is attached.
        /// </param>
        /// <param name="files">
        /// Optional attachments (max 15). Each file needs exactly one of data or url.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarkdownReplyContentDto(
            string markdown,
            global::System.Collections.Generic.IList<global::Novu.FileRefDto>? files)
        {
            this.Markdown = markdown ?? throw new global::System.ArgumentNullException(nameof(markdown));
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownReplyContentDto" /> class.
        /// </summary>
        public MarkdownReplyContentDto()
        {
        }

    }
}