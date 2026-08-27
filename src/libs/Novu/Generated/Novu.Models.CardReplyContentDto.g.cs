
#nullable enable

namespace Novu
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CardReplyContentDto
    {
        /// <summary>
        /// Interactive card as a Chat SDK element tree (`type: "card"`). Prefer building with `@novu/framework` Card helpers when using TypeScript.<br/>
        /// Example: {"type":"card","title":"Order #123","children":[{"type":"text","content":"Your order is ready for pickup."},{"type":"button","id":"confirm","label":"Confirm","style":"primary"}]}
        /// </summary>
        /// <example>{"type":"card","title":"Order #123","children":[{"type":"text","content":"Your order is ready for pickup."},{"type":"button","id":"confirm","label":"Confirm","style":"primary"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("card")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Card { get; set; }

        /// <summary>
        /// Optional attachments (max 15). Supported alongside cards on platforms that allow it (e.g. WhatsApp).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<global::Novu.FileRefDto>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CardReplyContentDto" /> class.
        /// </summary>
        /// <param name="card">
        /// Interactive card as a Chat SDK element tree (`type: "card"`). Prefer building with `@novu/framework` Card helpers when using TypeScript.<br/>
        /// Example: {"type":"card","title":"Order #123","children":[{"type":"text","content":"Your order is ready for pickup."},{"type":"button","id":"confirm","label":"Confirm","style":"primary"}]}
        /// </param>
        /// <param name="files">
        /// Optional attachments (max 15). Supported alongside cards on platforms that allow it (e.g. WhatsApp).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CardReplyContentDto(
            object card,
            global::System.Collections.Generic.IList<global::Novu.FileRefDto>? files)
        {
            this.Card = card ?? throw new global::System.ArgumentNullException(nameof(card));
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardReplyContentDto" /> class.
        /// </summary>
        public CardReplyContentDto()
        {
        }

    }
}