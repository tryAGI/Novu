
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplyContentDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        public object? Card { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolApprovalCard")]
        public object? ToolApprovalCard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<string>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyContentDto" /> class.
        /// </summary>
        /// <param name="markdown"></param>
        /// <param name="card"></param>
        /// <param name="toolApprovalCard"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplyContentDto(
            string? markdown,
            object? card,
            object? toolApprovalCard,
            global::System.Collections.Generic.IList<string>? files)
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