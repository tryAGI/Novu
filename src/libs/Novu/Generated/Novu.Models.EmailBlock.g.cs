
#nullable enable

namespace Novu
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmailBlock
    {
        /// <summary>
        /// Type of the email block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Novu.JsonConverters.EmailBlockTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Novu.EmailBlockTypeEnum Type { get; set; }

        /// <summary>
        /// Content of the email block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// URL associated with the email block, if any
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Styles applied to the email block
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("styles")]
        public global::Novu.EmailBlockStyles? Styles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the email block
        /// </param>
        /// <param name="content">
        /// Content of the email block
        /// </param>
        /// <param name="url">
        /// URL associated with the email block, if any
        /// </param>
        /// <param name="styles">
        /// Styles applied to the email block
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailBlock(
            global::Novu.EmailBlockTypeEnum type,
            string content,
            string? url,
            global::Novu.EmailBlockStyles? styles)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Url = url;
            this.Styles = styles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailBlock" /> class.
        /// </summary>
        public EmailBlock()
        {
        }
    }
}